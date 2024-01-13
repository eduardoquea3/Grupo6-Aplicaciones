<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="CapaPresentacion.Pages.Academico.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Agregar Dato Académico</title>
  <link rel="stylesheet" href="../../css/Academico/Agregar.css" />
</head>
<body>
  <form id="form1" runat="server">
    <h2>Agregar dato académico</h2>
    <label>Titulo</label>
    <asp:TextBox ID="txttitulo" runat="server" CssClass="input"></asp:TextBox>
    <label>Centro de estudios</label>
    <asp:TextBox ID="txtcentro" runat="server" CssClass="input"></asp:TextBox>
    <label>Fecha de Grado</label>
    <asp:TextBox ID="txtfgrado" runat="server" TextMode="Date" CssClass="input"></asp:TextBox>
    <div class="file">
      <label for="fupdf">Subir Archivo</label>
      <asp:FileUpload ID="fupdf" runat="server" CssClass="hidden" accept=".pdf" />
    </div>
    <asp:Button ID="btnagregar" runat="server" CssClass="btn" Text="Agregar" OnClick="btnagregar_Click"/>
    <asp:Button ID="btnno" runat="server" CssClass="btn" Text="Cancelar" OnClick="btnno_Click"/>
  </form>
</body>
</html>
