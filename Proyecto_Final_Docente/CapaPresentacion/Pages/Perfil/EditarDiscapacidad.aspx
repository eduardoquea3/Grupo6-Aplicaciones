<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="EditarDiscapacidad.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link rel="stylesheet" href="../css/EditarDiscapacidad.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section>
    <form runat="server">
      <h2>Ingrese su discapacidad</h2>
      <label>Discapacidad</label>
      <asp:TextBox ID="txtdiscapacidad" runat="server"></asp:TextBox>
      <label>Descripcion de la discapacidad</label>
      <asp:TextBox ID="txtdescDiscapacidad" runat="server" TextMode="MultiLine"></asp:TextBox>
      <asp:Button ID="btnagregar" runat="server" Text="Agregar" />
    </form>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>
