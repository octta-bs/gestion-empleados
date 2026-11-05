using GestionEmpleadosMVC.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GestionEmpleadosMVC.Controllers
{
    public class AuthController : ApiController
    {
        // GET: Auth
        public const string ClaveSecreta = "clave-de-practica-solo-para-aprender-123456";

        public IHttpActionResult Post([FromBody] LoginRequest datos)
        {
            if (datos == null || datos.Usuario != "admin" || datos.Password != "1234")
                return Unauthorized();

            var clave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ClaveSecreta));
            var firma = new SigningCredentials(clave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken (
                claims: new[] { new Claim(ClaimTypes.Name, datos.Usuario) },
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: firma);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token)});
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}