using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using GestionEmpleadosMVC.Controllers;
using Microsoft.IdentityModel.Tokens;

namespace GestionEmpleadosMVC.App_Start
{
    public class JwtHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var auth = request.Headers.Authorization;

            if (auth != null && auth.Scheme == "Bearer" && !string.IsNullOrEmpty(auth.Parameter))
            {
                try
                {
                    var reglas = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(AuthController.ClaveSecreta))
                    };

                    SecurityToken tokenValidado;
                    var usuario = new JwtSecurityTokenHandler()
                        .ValidateToken(auth.Parameter, reglas, out tokenValidado);

                    Thread.CurrentPrincipal = usuario;
                    if (HttpContext.Current != null) HttpContext.Current.User = usuario;
                }
                catch
                {
                    // Gafete falso o vencido: no se identifica a nadie.
                }
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}