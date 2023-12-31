<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarPass.aspx.cs" Inherits="CapaPresentacion.RecuperarPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Recuperar Contraseña</title>
  <link rel="stylesheet" href="css/password.css" />
  <link rel="shortcut icon" href="imagenes/logo.png"/>
</head>
<body>
  <form id="form1" runat="server">
    <h2>Recuperar Contraseña</h2>
    <label>Ingrese su correo:</label>
    <asp:TextBox ID="txtcorreo" runat="server" CssClass="input" TextMode="Email"></asp:TextBox>
    <span>La contraseña le llegara al correo, si es valido.</span>
    <asp:Button ID="btnrecuperar" runat="server" Text="Enviar" CssClass="btn"/>
  </form>
</body>
</html>
