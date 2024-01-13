<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Academico.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link rel="stylesheet" href="../css/academico.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section>
    <form runat="server" class="experiencia">
      <h2>Datos Academicos</h2>
      <asp:GridView ID="gvlista" runat="server" CssClass="table" AutoGenerateColumns="false">
        <Columns>
          <asp:BoundField  DataField="titulo" HeaderText="Titulo"/>
          <asp:BoundField  DataField="centro" HeaderText="Centro de estudios"/>
          <asp:BoundField  DataField="fGrado" HeaderText="Fecha de Grado"/>
          <asp:HyperLinkField DataNavigateUrlFields="pdf" DataNavigateUrlFormatString="~/pdf/academico/{0}" Text="Ver pdf" Target="_blank" HeaderText="Certificado" ControlStyle-CssClass="link"/>
          <asp:HyperLinkField DataNavigateUrlFields="id,idA" DataNavigateUrlFormatString="./Academico/Modificar.aspx?id={0}&idA={1}" Text="Editar" ControlStyle-CssClass="view"/>
          <asp:HyperLinkField DataNavigateUrlFields="id,idA" DataNavigateUrlFormatString="./Academico/Eliminar.aspx?id={0}&idA={1}" Text="Eliminar" ControlStyle-CssClass="view"/>
        </Columns>
      </asp:GridView>
      <asp:Button ID="btnagregar" runat="server" CssClass="btn" Text="Agregar Experiencia" OnClick="btnagregar_Click"/>
    </form>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>
