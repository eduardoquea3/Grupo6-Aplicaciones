<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicie sesion o registrese - Amador</title>
    <!--<script src="https://cdn.tailwindcss.com"></script>-->
    <link rel="shortcut icon" href="imagenes/logo.png"/>
    <link href="css/login.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server" class="inicio-sesion">
        <section class="sign" id="sign">
            <h2 class="full">Create Account</h2>
            <label class="full">Nombres</label>
            <asp:TextBox ID="txtnombre" runat="server" CssClass="full" placeholder="Nombre"></asp:TextBox>
            <label class="mid">Apellido Paterno</label>
            <label class="mid">Apellido Materno</label>
            <asp:TextBox ID="txtpaterno" runat="server" CssClass="mid" placeholder="Apellido Paterno"></asp:TextBox>
            <asp:TextBox ID="txtmaterno" runat="server" CssClass="mid" placeholder="Apellido Materno"></asp:TextBox>
            <label class="mid">Tipo de documento</label>
            <label class="mid">Documento</label>
            <asp:DropDownList ID="ddltipo" runat="server" CssClass="mid combo">
                <asp:ListItem>DNI</asp:ListItem>
                <asp:ListItem>C.E.</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtdocumento" runat="server" CssClass="mid" placeholder="Documento"></asp:TextBox>
            <label class="full">Correo</label>
            <asp:TextBox ID="txtcorreo" runat="server" TextMode="Email" CssClass="full" placeholder="Correo Electrónico"></asp:TextBox>
            <label class="full">Contraseña</label>
            <asp:TextBox ID="txtpassword" runat="server" CssClass="full" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
          <asp:Button ID="btnregistro" runat="server" CssClass="btn" Text="Sign up" OnClientClick="return registro();" OnClick="btnregistro_Click" />

        </section>
        <section class="login" id="login">
            <h2>Sign in</h2>
            <label>Correo</label>
            <asp:TextBox ID="txtcorreo2" runat="server" TextMode="Email" placeholder="Correo Electrónico"></asp:TextBox>
            <label>Contraseña</label>
            <asp:TextBox ID="txtpassword2" runat="server" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
            <asp:Button ID="btnlogin" runat="server" CssClass="btn" Text="Sign in" OnClick="btnlogin_Click"/>
            <asp:HyperLink ID="hlpass" runat="server" CssClass="recuperar">¿Olvidaste tu contraseña?</asp:HyperLink>
        </section>
        <section class="capa" id="capa">
            <div class="toggle">
                <img src="imagenes/logo.png"/>
                <div class="toggle-panel">
                    <h1>Hello, Friend!</h1>
                    <p>
                        Register with your personal details to use all of site features
                    </p>
                </div>
                <div class="toggle-panel hidden">
                    <h1>Welcome Back!</h1>
                    <p>Enter your personal details to use all of site features</p>
                </div>
                <input type="submit" id="cambio" value="Sign up" class=""/>
            </div>
        </section>

    </form>
    <script src="js/login.js"></script>
</body>
</html>
