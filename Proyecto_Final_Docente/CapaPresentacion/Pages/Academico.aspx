﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Academico.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <section>
    <form runat="server" class="experiencia">
      <h2>Datos Academicos</h2>
      <asp:GridView ID="gvlista" runat="server" CssClass="table">
        <Columns>
          <asp:BoundField  DataField="titulo" HeaderText="Titulo"/>
          <asp:BoundField  DataField="fFin" HeaderText="Centro de estudios"/>
          <asp:BoundField  DataField="cargo" HeaderText="Fecha de Grado"/>
          <asp:HyperLinkField DataNavigateUrlFields="id,idA" DataNavigateUrlFormatString="./Academico/Eliminar.aspx?id={0}&idE={1}" Text="Eliminar" />
        </Columns>
      </asp:GridView>
      <asp:Button ID="btnagregar" runat="server" CssClass="btn" Text="Agregar Experiencia"/>
    </form>
  </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
</asp:Content>
