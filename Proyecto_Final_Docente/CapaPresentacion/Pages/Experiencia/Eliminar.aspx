<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="CapaPresentacion.Pages.Experiencia.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Eliminar Experiencia</title>
  <link rel="stylesheet" href="../../css/actionExperiencia.css"/>
</head>
<body>
    <form id="form1" runat="server" class="eliminar">
      <h2>Eliminar Experiencia</h2>
      <label>Fecha de inicio</label>
      <label>Fecha de finalizacion</label>
      <asp:TextBox ID="txtfinicio" runat="server" CssClass="input" ReadOnly="true"></asp:TextBox>
      <asp:TextBox ID="txtffin" runat="server" CssClass="input" ReadOnly="true"></asp:TextBox>
      <label>Cargo</label>
      <label>Empresa</label>
      <asp:TextBox ID="txtcargo" runat="server" CssClass="input" ReadOnly="true"></asp:TextBox>
      <asp:TextBox ID="txtempresa" runat="server" CssClass="input" ReadOnly="true"></asp:TextBox>
      <asp:Button ID="btnagregar" runat="server" Text="Agregar Experiencia" CssClass="btn"/>
    </form>
</body>
</html>
