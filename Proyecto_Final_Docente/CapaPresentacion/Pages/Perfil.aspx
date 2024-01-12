<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layout.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="CapaPresentacion.Pages.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../css/perfil.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <section class="">
    <form runat="server" class="main">
      <div id="info" class="container">

        <h1 class="title">Mi perfil</h1>

        <picture class="foto">
          <asp:Image ID="imgPerfil" runat="server" CssClass="" ImageUrl="~/imagenes/user.png" />
          <div class="fileupload">
            <label for="ContentPlaceHolder1_fufoto" id="archivo">Subir archivo:</label>
            <asp:Label ID="nombrearchivo" runat="server" Visible="false">ho</asp:Label>
            <asp:FileUpload ID="fufoto" runat="server" onchange="mostrarImagen(this)" accept=".jpg, .jpeg, .png, .gif"/>
          </div>
        </picture>
        <label>Usuario</label>
        <label>Nombres</label>
        <asp:TextBox ID="txtusername" runat="server" CssClass="texto login"></asp:TextBox>
        <asp:TextBox ID="txtname" runat="server" CssClass="texto login"></asp:TextBox>
        <label>Apellido Paterno</label>
        <label>Apellido Materno</label>
        <asp:TextBox ID="txtapepat" runat="server" CssClass="texto login"></asp:TextBox>
        <asp:TextBox ID="txtapemat" runat="server" CssClass="texto"></asp:TextBox>
        <label>Tipo de documento</label>
        <label>Documento</label>
        <asp:DropDownList ID="ddltipo" runat="server" CssClass="select">
          <asp:ListItem>Dni</asp:ListItem>
          <asp:ListItem>C.E</asp:ListItem>
        </asp:DropDownList>
        <!--<asp:TextBox ID="txttipo" runat="server" CssClass="texto"></asp:TextBox>-->
        <asp:TextBox ID="txtdocumento" runat="server" CssClass="texto" TextMode="Number" max="999999999999"></asp:TextBox>
        <label>Sexo</label>
        <label>Estado Civil</label>
          <asp:DropDownList ID="ddlsexo" runat="server" CssClass="select"></asp:DropDownList>
          <asp:DropDownList ID="ddlestado" runat="server" CssClass="select"></asp:DropDownList>
        <label>Direccion</label>
        <label>Telefono</label>
        <asp:TextBox ID="txtdireccion" runat="server" CssClass="texto login"></asp:TextBox>
        <asp:TextBox ID="txttelefono" runat="server" CssClass="texto number"></asp:TextBox>
        <label>Celular</label>
        <label>Correo</label>
        <asp:TextBox ID="txtcelular" runat="server" CssClass="texto" TextMode="Number" min="900000000" max="999999999"></asp:TextBox>
        <asp:TextBox ID="txtcorreo" runat="server" CssClass="texto" TextMode="Email"></asp:TextBox>
        <label class="full">Ubigeo</label>
        <!--<asp:TextBox ID="txtubigeo" runat="server" CssClass="texto"></asp:TextBox>-->
        <asp:ScriptManager ID="smubigeo" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="upubigeo" runat="server" UpdateMode="Conditional">
          <ContentTemplate>
            <asp:DropDownList ID="ddldpto" runat="server" OnSelectedIndexChanged="ddldpto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList ID="ddlprov" runat="server" OnSelectedIndexChanged="ddlprov_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <asp:DropDownList ID="ddldistrito" runat="server"></asp:DropDownList>
          </ContentTemplate>
        </asp:UpdatePanel>
        <label class="full">Fecha de nacimiento</label>
        <asp:TextBox ID="txtnacimineto" runat="server" CssClass="texto full" TextMode="Date"></asp:TextBox>
        <label class="full">Precio por hora</label>
        <asp:TextBox ID="txtprecio" runat="server" CssClass="texto full"></asp:TextBox>
        <label class="full">Discapacidad</label>
        <div class="table">
          <asp:GridView ID="gvdiscapacidad" runat="server" AutoGenerateColumns="false">
            <Columns>
              <asp:BoundField DataField="discapacidad" HeaderText="Discapacidad" />
              <asp:BoundField DataField="descDiscapacidad" HeaderText="Descripción de la discapacidad" />
              <asp:HyperLinkField DataNavigateUrlFields="id,idDiscapacidad" DataNavigateUrlFormatString="./Perfil/EditarDiscapacidad.aspx?id={0}&idD={1}" Text="Modificar" ControlStyle-CssClass="link"/>
              <asp:HyperLinkField DataNavigateUrlFields="id,idDiscapacidad" DataNavigateUrlFormatString="./Perfil/EliminarDiscapacidad.aspx?id={0}&idD={1}" Text="Eliminar" ControlStyle-CssClass="link"/>
            </Columns>
          </asp:GridView>
          <input type="button" id="addDiscapacidad" class="btn" value="Agregar Discapacidad" />
        </div>
        <div class="button">
          <asp:Button ID="btncambiar" runat="server" CssClass="btn" Text="Cambiar Contraseña" OnClick="btncambiar_Click"/>
          <asp:Button ID="btnguardar" runat="server" CssClass="btn" Text="Guardar Cambios" OnClick="btnguardar_Click" />
        </div>
      </div>
      <div class="add hidden" id="Discapacidad">
        <button id="close" class="fa fa-close"></button>
        <main>
          <label>Discapacidad</label>
          <asp:TextBox ID="txtdiscapacidad" runat="server"></asp:TextBox>
          <label>Descripción</label>
          <asp:TextBox ID="txtdescripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
          <asp:Button ID="btnadd" runat="server" Text="Agregar" CssClass="btn" OnClientClick="return validarDisc();" OnClick="btnadd_Click"/>
        </main>
      </div>
    </form>
  </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScript" runat="server">
  <script src="../js/perfil.js"></script>
</asp:Content>
