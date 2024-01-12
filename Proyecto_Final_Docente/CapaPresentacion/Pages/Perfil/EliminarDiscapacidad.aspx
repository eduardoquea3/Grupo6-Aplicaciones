<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="EliminarDiscapacidad.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link rel="stylesheet" href="../../css/EditarDiscapacidad.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section>
    <form runat="server">
      <h2>Eliminar su discapacidad</h2>
      <label>Discapacidad</label>
      <asp:TextBox ID="txtdiscapacidad" runat="server" ReadOnly="true"></asp:TextBox>
      <label>Descripcion de la discapacidad</label>
      <asp:TextBox ID="txtdescDiscapacidad" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
      <div>
        <asp:Button ID="btneliminar" runat="server" Text="Eliminar" CssClass="btn" OnClick="btneliminar_Click"/>
        <asp:Button ID="btncancelar" runat="server" Text="Cancelar" CssClass="btn" OnClick="btncancelar_Click"/>
      </div>
    </form>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>
