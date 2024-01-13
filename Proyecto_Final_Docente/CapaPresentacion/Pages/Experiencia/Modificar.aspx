<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="CapaPresentacion.Pages.Experiencia.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Agregar Experiencia</title>
  <link rel="stylesheet" href="../../css/actionExperiencia.css"/>
</head>
<body>
    <form id="form1" runat="server">
      <h2>Editar Experiencia</h2>
      <label>Fecha de inicio</label>
      <label>Fecha de finalizacion</label>
      <asp:TextBox ID="txtfinicio" runat="server" CssClass="input" TextMode="Date"></asp:TextBox>
      <asp:TextBox ID="txtffin" runat="server" CssClass="input" TextMode="Date"></asp:TextBox>
      <label>Cargo</label>
      <label>Empresa</label>
      <asp:TextBox ID="txtcargo" runat="server" CssClass="input"></asp:TextBox>
      <asp:TextBox ID="txtempresa" runat="server" CssClass="input"></asp:TextBox>
      <div>
        <label for="fucerti" class="fileUp">Subir archivo</label>
        <asp:Label ID="lblcerti" runat="server" CssClass="name"></asp:Label>
        <asp:FileUpload ID="fucerti" runat="server" CssClass="hidden" accept=".pdf"/>
      </div>
      <asp:Button ID="btnagregar" runat="server" Text="Editar Experiencia" CssClass="btn" OnClientClick="return validar();" OnClick="btnagregar_Click"/>
      <asp:Button ID="btncancelar" runat="server" Text="Cancelar" CssClass="btn" OnClick="btncancelar_Click"/>
    </form>
  <script src="agregar.js"></script>
</body>
</html>
