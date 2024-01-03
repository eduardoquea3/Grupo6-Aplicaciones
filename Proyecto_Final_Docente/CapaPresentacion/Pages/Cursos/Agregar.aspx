<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="CapaPresentacion.Pages.Cursos.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Agregar curso</title>
  <link rel="stylesheet" href="../../css/Curso/Agregar.css"/>
</head>
<body>
    <form id="form1" runat="server">
      <asp:CheckBoxList ID="cblcurso" runat="server" CssClass="lista"></asp:CheckBoxList>
      <asp:Button ID="btnagregar" runat="server" CssClass="btn" Text="Agregar Curso(s)" OnClick="btnagregar_Click"/>
      <asp:Button ID="btncancelar" runat="server" CssClass="btn" Text="Cancelar"/>
    </form>
</body>
</html>
