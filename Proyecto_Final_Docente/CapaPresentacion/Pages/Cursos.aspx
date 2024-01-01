<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section>
    <form runat="server" class="experiencia">
      <h2>Cursos Dictados</h2>
      <asp:GridView ID="gvlista" runat="server" CssClass="table">
        <Columns>
          <asp:BoundField  DataField="fInicio" HeaderText="Fecha de inicio"/>
          <asp:BoundField  DataField="fFin" HeaderText="Fecha de finalización"/>
          <asp:BoundField  DataField="cargo" HeaderText="Cargo"/>
          <asp:BoundField  DataField="empresa" HeaderText="Empresa"/>
          <asp:HyperLinkField DataNavigateUrlFields="id,idE" DataNavigateUrlFormatString="./Experiencia/Eliminar.aspx?id={0}&idE={1}" Text="Eliminar" />
        </Columns>
      </asp:GridView>
      <asp:Button ID="btnagregar" runat="server" CssClass="btn" Text="Agregar Curso"/>
    </form>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>
