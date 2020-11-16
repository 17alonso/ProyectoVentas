<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SeguridadFrontEnd.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <div class="navbar navbar-dark bg-dark box-shadow">
        <div class="container d-flex justify-content-between">
            <a href="#" class="navbar-brand d-flex align-items-center">
            <strong>Sistema Ventas</strong>
            </a>
        </div>
    </div>

<main role="main">
        <section class="jumbotron text-center">
                            <h1 class="jumbotron-heading">Loguin Vendedor</h1>
                                            <a href="Login.aspx">Vendedor </a>
            <a href="LoginCliente.aspx"> Cliente</a>

                         </section>
            <div class="container">
                <div class="row">
                    <div id="login" class="col-lg-4 offset-lg-4 col-md-6 offset-md-3 col-12" >
                            <!--Controles del formulario-->
                        <form runat="server">
                            <div class="form-group">
                                <label for="correo">Correo</label>
                                <asp:TextBox runat="server" Id="txtidUsuario" class="form-control"  placeholder="Correo" />

                            </div>
                            <div class="form-group">
                                <label for="palabraSecreta">Contraseña</label>
                                <asp:TextBox runat="server" Id="txtIdContrasenia" class="form-control"  placeholder="Password" type="password"/>

                            </div>
                                <asp:Button Text="Entrar" runat="server" Id="btnEntrar" class="btn btn-primary" OnClick="btnEntrar_Click"/>
                            <br/>
                            <br/>
                            <br/>
                            <div class="col text-center">

                                <asp:Button Text="Crea una cuenta!!!" runat="server" Id="btnCrearCuenta" class="btn btn-primary" OnClick="btnCrearCuenta_Click"/>
                            <br/>
                            <br/>
                            <asp:Label Id="lblIdentificar" Text="Te identificas como..." runat="server" Visible="false"/>
                            <br/>
                            <br/>
                                <asp:Button Text="Cliente" runat="server" id="btnCrearCliente" class="btn btn-primary" Visible="false" OnClick="btnCrearCliente_Click"/>
                                <asp:Label Id="lblO" Text=" Ó " runat="server" Visible="false"/>

                                <asp:Button Text="Vendedor" runat="server" Id="BtnCrearVendedor" class="btn btn-primary" Visible="false" OnClick="BtnCrearVendedor_Click"/>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
    </main>
     


</body>
</html>
