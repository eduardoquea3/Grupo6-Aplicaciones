<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link rel="stylesheet" href="../css/inicio.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <form runat="server">

    <fieldset>
      <legend>Datos Principales</legend>
      <section class="start">
        <picture class="">
          <asp:Image ID="imgPerfil" runat="server" CssClass="" ImageUrl="~/imagenes/user.png" />
        </picture>
        <main runat="server" class="w-full px-[10%] grid grid-cols-5 items-center justify-center text-center gap-y-[10px]">
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
          <asp:Button ID="btncambiar" runat="server" CssClass="btn" Text="Cambiar Contraseña" OnClick="btncambiar_Click"/>
        </main>
      </section>
    </fieldset>
    <fieldset>
      <legend>Datos Personales</legend>
      <section class="extras data">
        <asp:Panel ID="pnvista" runat="server" Visible="true">
          <label>Sexo:</label>
          <asp:Label ID="lblsexo" runat="server" CssClass="datos"></asp:Label>
          <label>Estado Civil:</label>
          <asp:Label ID="lblestado" runat="server" CssClass="datos"></asp:Label>
          <label>Direccion:</label>
          <asp:Label ID="lbldirec" runat="server" CssClass="datos"></asp:Label>
          <label>Departemento:</label>
          <asp:Label ID="lbldpto" runat="server" CssClass="datos"></asp:Label>
          <label>Provincia:</label>
          <asp:Label ID="lblprov" runat="server" CssClass="datos"></asp:Label>
          <label>Distrito:</label>
          <asp:Label ID="lbldist" runat="server" CssClass="datos"></asp:Label>
          <label>Telefono:</label>
          <asp:Label ID="lbltelefono" runat="server" CssClass="datos"></asp:Label>
          <label>Celular:</label>
          <asp:Label ID="lblcel" runat="server" CssClass="datos"></asp:Label>
          <label>Fecha de nacimiento:</label>
          <asp:Label ID="lblfnac" runat="server" CssClass="datos"></asp:Label>
          <label>Precio por hora:</label>
          <asp:Label ID="lblprecio" runat="server" CssClass="datos"></asp:Label>
        </asp:Panel>
        <asp:Label ID="lblnopersonales" Visible="false" runat="server" CssClass="anuncio">No se encontraron datos Personales</asp:Label>
      </section>
    </fieldset>
    <fieldset>
      <legend>Datos Académicos</legend>
      <section class="academicos data">
        <asp:GridView ID="gvacademicos" runat="server" CssClass="table" AutoGenerateColumns="false">
          <Columns>
            <asp:BoundField DataField="titulo" HeaderText="Titulo" />
            <asp:BoundField DataField="centro" HeaderText="Centro de estudios" />
            <asp:BoundField DataField="fGrado" HeaderText="Fecha de Grado" />
          </Columns>
        </asp:GridView>
        <asp:Label ID="lblnoacademico" Visible="true" runat="server" CssClass="anuncio">No se encontraron datos académicos</asp:Label>
      </section>
    </fieldset>
    <fieldset>
      <legend>Experiencias</legend>
      <section class="experiencia data">
        <asp:GridView ID="gvexpe" runat="server" CssClass="table" AutoGenerateColumns="false">
          <Columns>
            <asp:BoundField DataField="cargo" HeaderText="Cargo" />
            <asp:BoundField DataField="empresa" HeaderText="Empresa" />
            <asp:BoundField DataField="fInicio" HeaderText="Fecha de Inicio" />
            <asp:BoundField DataField="fFin" HeaderText="Fecha de Finalizacion" />
          </Columns>
        </asp:GridView>
        <asp:Label ID="lblnoexperiencia" Visible="true" runat="server" CssClass="anuncio">No se encontraron experiencias</asp:Label>
      </section>
    </fieldset>
    <fieldset>
      <legend>Cursos a Dictar</legend>
      <section class="curso data">
        <asp:GridView ID="gvcurso" runat="server" CssClass="table" AutoGenerateColumns="false">
          <Columns>
            <asp:BoundField HeaderText="Cursos" DataField="nombre" />
          </Columns>
        </asp:GridView>
        <asp:Label ID="lblnocursos" Visible="true" runat="server" CssClass="anuncio">No se encontraron cursos</asp:Label>
      </section>
    </fieldset>
    <fieldset>
      <legend>Discapacidad</legend>
      <section class="discapacidad data">
        <asp:GridView ID="gvdiscapacidad" runat="server" CssClass="table" AutoGenerateColumns="false">
          <Columns>
            <asp:BoundField DataField="discapacidad" HeaderText="Discapacidad" />
            <asp:BoundField DataField="descDiscapacidad" HeaderText="Descripcion" />
          </Columns>
        </asp:GridView>
        <asp:Label ID="lblnodiscapacidad" Visible="true" runat="server" CssClass="anuncio">No se encontraron discapacidades</asp:Label>
      </section>
    </fieldset>

    <asp:Button ID="btnreg" runat="server" CssClass="btn" Text="Registrar" OnClick="btnreg_Click"/>
  </form>
</asp:Content>
