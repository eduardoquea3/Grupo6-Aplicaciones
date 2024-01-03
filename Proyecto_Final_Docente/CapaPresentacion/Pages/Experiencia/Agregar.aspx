<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="CapaPresentacion.Pages.Experiencia.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Agregar Experiencia</title>
  <link rel="stylesheet" href="../../css/actionExperiencia.css"/>
</head>
<body>
    <form id="form1" runat="server">
      <h2>Agregar Experiencia</h2>
      <label>Fecha de inicio</label>
      <label>Fecha de finalizacion</label>
      <asp:TextBox ID="txtfinicio" runat="server" CssClass="input"></asp:TextBox>
      <asp:TextBox ID="txtffin" runat="server" CssClass="input"></asp:TextBox>
      <label>Cargo</label>
      <label>Empresa</label>
      <asp:TextBox ID="txtcargo" runat="server" CssClass="input"></asp:TextBox>
      <asp:TextBox ID="txtempresa" runat="server" CssClass="input"></asp:TextBox>
      <div>
        <label for="fucerti" class="fileUp">Subir archivo</label>
        <p class="name">hola</p>
        <asp:FileUpload ID="fucerti" runat="server" CssClass="hidden"/>
      </div>
      <asp:Button ID="btnagregar" runat="server" Text="Agregar Experiencia" CssClass="btn"/>
      <asp:Button ID="btncancelar" runat="server" Text="Cancelar" CssClass="btn"/>
    </form>
</body>
</html>
