<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="SeguridadFrontEnd.ClientesPermitidos.Perfil" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>
</head>
<body>
    <div class="navbar navbar-dark bg-dark box-shadow">
        <div class="container d-flex justify-content-between">
            <a href="Inicio.aspx" class="navbar-brand d-flex align-items-center">
            <strong>Sistema Ventas</strong>
            </a>
        </div>
    </div>

<main role="main">
        <section class="jumbotron text-center">
                <h1 class="jumbotron-heading">Bienvenido</h1>
                <h3><asp:LoginName ID="LoginName1" runat="server" /></h3>
        </section>

            <div class="container">
                <div class="row">
                    <div id="login" class="col-lg-4 offset-lg-4 col-md-6 offset-md-3 col-12" >
                            <!--Controles del formulario-->
                        <h4>Cambiar Contraseña</h4>
                        <form runat="server">
                            <div class="form-group">
                                <label for="palabraSecreta">Contraseña</label>
                                <asp:TextBox runat="server" Id="txtIdContrasenia" class="form-control"  placeholder="Password" type="password"/>

                            </div>
                            <div class="form-group">
                                <label for="palabraSecreta">Contraseña Nueva</label>
                                <asp:TextBox runat="server" Id="txtIdContraseniaNueva" class="form-control"  placeholder="Nuevo Password" type="password"/>
                            </div>
                            <div class="form-group">
                                <label for="palabraSecreta">Repirta la Contraseña</label>
                                <asp:TextBox runat="server" Id="txtIdContraseniaNueva2" class="form-control"  placeholder="Nuevo Password" type="password"/>
                            </div>
                        <!-- 
                            <div class="form-group">
                                <label for="tipo">Tipo:</label>
                                <asp:DropDownList runat="server" ID="comboboxTipo" class="custom-select custom-select-sm">
                                    <asp:ListItem Text="Cliente" value="cliente"/>
                                    <asp:ListItem Text="Vendedor" value="vendedor"/>
                                </asp:DropDownList>

                            </div>
                            -->
                                <asp:Button Text="Entrar" runat="server" Id="btnEntrar" class="btn btn-primary" OnClick="btnEntrar_Click" />
                            <br/>
                            <br/>
                            <br/>
                            <asp:LoginStatus ID="LoginStatus1" runat="server" />
                        </form>
                    </div>
                </div>
            </div>
    </main>
     


</body>
</html>
