<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Experiencia.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link rel="stylesheet" href="../css/experiencia.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section>
    <form runat="server" class="experiencia">
      <h2>Experiencias</h2>
      <asp:GridView ID="gvlista" runat="server" CssClass="table" AutoGenerateColumns="false">
        <Columns>
          <asp:BoundField  DataField="fInicio" HeaderText="Fecha de inicio"/>
          <asp:BoundField  DataField="fFin" HeaderText="Fecha de finalización"/>
          <asp:BoundField  DataField="empresa" HeaderText="Cargo"/>
          <asp:BoundField  DataField="cargo" HeaderText="Empresa"/>
          <asp:HyperLinkField DataNavigateUrlFields="certificado" DataNavigateUrlFormatString="~/pdf/experiencia/{0}" Text="Ver pdf" Target="_blank" HeaderText="Certificado" ControlStyle-CssClass="link"/>
          <asp:HyperLinkField DataNavigateUrlFields="id,idE" DataNavigateUrlFormatString="./Experiencia/Modificar.aspx?id={0}&idE={1}" Text="Modificar" ControlStyle-CssClass="view"/>
          <asp:HyperLinkField DataNavigateUrlFields="id,idE" DataNavigateUrlFormatString="./Experiencia/Eliminar.aspx?id={0}&idE={1}" Text="Eliminar" ControlStyle-CssClass="view"/>
        </Columns>
      </asp:GridView>
      <asp:Button ID="btnagregar" runat="server" CssClass="btn" Text="Agregar Experiencia" OnClick="btnagregar_Click"/>
    </form>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>
