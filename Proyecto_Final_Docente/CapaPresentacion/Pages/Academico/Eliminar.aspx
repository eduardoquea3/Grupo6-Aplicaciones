<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="CapaPresentacion.Pages.Academico.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Eliminar Dato Académico</title>
  <link rel="stylesheet" href="../../css/Academico/Eliminar.css" />
</head>
<body>
  <form id="form1" runat="server">
    <h2>Eliminar dato académico</h2>
    <p>Deseas eliminar este dato académico</p>
    <asp:Label ID="lbldato" runat="server"></asp:Label>
    <asp:Button ID="btneliminar" runat="server" CssClass="btn" Text="Sí" OnClick="btneliminar_Click"/>
    <asp:Button ID="btnno" runat="server" CssClass="btn" Text="No" OnClick="btnno_Click"/>
  </form>
</body>
</html>
