<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="CapaPresentacion.Pages.Curso.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Eliminar curso</title>
  <link rel="stylesheet" href="../../css/Curso/Eliminar.css"/>
</head>
<body>
    <form id="form1" runat="server">
      <h2>
        <asp:Label ID="lblcurso" runat="server"></asp:Label>
      </h2>
      <p>Esta seguro de eliminar el curso de su lista</p>
      <asp:Button ID="btnsi" runat="server" CssClass="btn" Text="Si" OnClick="btnsi_Click"/>
      <asp:Button ID="btnno" runat="server" CssClass="btn" Text="No" OnClick="btnno_Click"/>
    </form>
</body>
</html>
