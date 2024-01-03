<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPass.aspx.cs" Inherits="CapaPresentacion.Pages.NewPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cambiar Contraseña</title>
  <link rel="stylesheet" href="../css/newpass.css" />
</head>
<body>
    <form id="form1" runat="server">
      <h2>Cambiar Contraseña</h2>
      <label>Contraseña</label>
      <asp:TextBox ID="txtpass" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
      <label>Nueva Contraseña</label>
      <asp:TextBox ID="txtnewpass" runat="server" CssClass="input" TextMode="Password"></asp:TextBox>
      <asp:Button ID="btncambiar" runat="server" CssClass="btn" Text="Cambiar" OnClick="btncambiar_Click" />
      <asp:Button ID="btncancelar" runat="server" CssClass="btn" Text="Cancelar" OnClick="btncancelar_Click" />
    </form>
</body>
</html>
