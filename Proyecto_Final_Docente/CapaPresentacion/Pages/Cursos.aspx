<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/curso.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section>
    <form runat="server" class="experiencia">
      <h2>Cursos Dictados</h2>
      <asp:GridView ID="gvlista" runat="server" CssClass="table" AutoGenerateColumns="false">
        <Columns>
          <asp:BoundField  DataField="nombre" HeaderText="Curso"/>
          <asp:HyperLinkField DataNavigateUrlFields="id,idC" DataNavigateUrlFormatString="./Cursos/Eliminar.aspx?id={0}&idC={1}" Text="Eliminar" />
        </Columns>
      </asp:GridView>
      <asp:Button ID="btnagregar" runat="server" CssClass="btn" Text="Agregar Curso" OnClick="btnagregar_Click"/>
    </form>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>
