<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/inicio.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <fieldset>
    <legend>Datos Principales</legend>
    <section class="start">
      <picture class="h-full flex justify-center items-center">
        <asp:Image ID="imgPerfil" runat="server" CssClass="w-[300px] max-h-[500px] rounded-[15px]" ImageUrl="~/imagenes/user.png" />
      </picture>
      <main class="w-full px-[10%] grid grid-cols-5 items-center justify-center text-center gap-y-[10px]">
        <asp:Label ID="lbluser" runat="server" CssClass="head">Eduardo Quea</asp:Label>
        <label class="">Nombres:</label>
        <asp:Label ID="lblnombre" runat="server" CssClass="datos">Eduardo Franco</asp:Label>
        <label class="">Apellidos:</label>
        <asp:Label ID="lblapellido" runat="server" CssClass="datos">Quea Hancco</asp:Label>
        <label class="">Tipo de documento:</label>
        <asp:Label ID="lbltipo" runat="server" CssClass="datos">Dni</asp:Label>
        <label class="">Documento:</label>
        <asp:Label ID="lbldocumento" runat="server" CssClass="datos">54986532</asp:Label>
        <label class="">Correo:</label>
        <asp:Label ID="lblcorreo" runat="server" CssClass="datos">ehancco@hotmail.com</asp:Label>
      </main>
    </section>
  </fieldset>
</asp:Content>
