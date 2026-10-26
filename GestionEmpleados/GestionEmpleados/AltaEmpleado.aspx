<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AltaEmpleado.aspx.cs" Inherits="GestionEmpleados.AltaEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

           <asp:UpdatePanel ID="UpdatePanel1" runat="server">
               <ContentTemplate>
                   <div>
                    <label>Nombre:</label>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <br /><br />

                    <label>Puesto:</label>
                    <asp:TextBox ID="txtPuesto" runat="server"></asp:TextBox>
                    <br /><br />

                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    <br /><br />

                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </div>
               </ContentTemplate>
           </asp:UpdatePanel>
    </form>
</body>
</html>
