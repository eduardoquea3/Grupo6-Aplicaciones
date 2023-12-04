<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicie sesion o registrese</title>
    <link href="css/login.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server" class="inicio-sesion">
        <section class="sign" id="sign">
            <h2 class="full">Create Account</h2>
            <label class="full">Nombres</label>
            <asp:TextBox ID="lblnombre" runat="server" CssClass="full"></asp:TextBox>
            <label class="mid">Apellido Paterno</label>
            <label class="mid">Apellido Materno</label>
            <asp:TextBox ID="lblpaterno" runat="server" CssClass="mid"></asp:TextBox>
            <asp:TextBox ID="lblmaterno" runat="server" CssClass="mid"></asp:TextBox>
            <label class="mid">Tipo de documento</label>
            <label class="mid">Documento</label>
            <asp:DropDownList ID="ddltipo" runat="server" CssClass="mid combo">
                <asp:ListItem>DNI</asp:ListItem>
                <asp:ListItem>Carnet de extranjeria</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="lbldocumento" runat="server" CssClass="mid"></asp:TextBox>
            <label class="full">Correo</label>
            <asp:TextBox ID="lblcorreo" runat="server" CssClass="full"></asp:TextBox>
            <label class="full">Contraseña</label>
            <asp:TextBox ID="lblpassword" runat="server" CssClass="full" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnregistro" runat="server" CssClass="btn" Text="Sign up"/>
        </section>
        <section class="login" id="login">
            <h2>Sign in</h2>
            <label>Correo</label>
            <asp:TextBox ID="lblcorreo2" runat="server"></asp:TextBox>
            <label>Contraseña</label>
            <asp:TextBox ID="lblpassword2" runat="server"></asp:TextBox>
            <asp:Button ID="btnregistro2" runat="server" CssClass="btn" Text="Sign in"/>
        </section>
        <section class="capa" id="capa">
            <div class="toggle">
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
                <input type="submit" id="cambio" value="Sign in"/>
            </div>
        </section>

    </form>
    <script src="js/login.js"></script>
</body>
</html>
