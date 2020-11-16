<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarVendedor.aspx.cs" Inherits="SeguridadFrontEnd.RegistrarVendedor" %>

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
            <strong>Sistema de Ventas</strong>
            </a>
        </div>
    </div>

<main role="main">
        <section class="jumbotron text-center">
        <h1 class="jumbotron-heading">Registrar Vendedor</h1>
        </section>
            <div class="container">
                <div class="row">
                    <div id="login" class="col-lg-4 offset-lg-4 col-md-6 offset-md-3 col-12" >
                            <!--Controles del formulario-->
                        <form runat="server">
                            <div class="form-group">
                                <label for="codVendedor">CodVendedor</label>
                                <asp:TextBox runat="server" Id="txtidRVendedor" class="form-control"  placeholder="CodVendedor" />
                            </div>
                                <div class="form-group">
                                    <label for="palabraSecreta">Nombres</label>
                                    <asp:TextBox runat="server" Id="txtIdRNombres" class="form-control"  placeholder="Nombres" />
                                </div>
                                <div class="form-group">
                                    <label for="palabraSecreta">Apellidos</label>
                                    <asp:TextBox runat="server" Id="txtIdRApellidos" class="form-control"  placeholder="Apellidos" />
                                </div>
                            <div class="form-group">
                                <label for="palabraSecreta">Email</label>
                                <asp:TextBox runat="server" Id="txtIdREmail" class="form-control"  placeholder="Email" type="email"/>

                            </div>
                            <div class="form-group">
                                <label for="palabraSecreta">Contraseña</label>
                                <asp:TextBox runat="server" Id="txtIdRContrasenia" class="form-control"  placeholder="Contraseña" type="password"/>

                            </div>
                            <div class="form-group">
                                <label for="palabraSecreta">Confirme Contraseña</label>
                                <asp:TextBox runat="server" Id="txtIdRContrasenia2" class="form-control"  placeholder="Repita Contraseña" type="password"/>

                            </div>
                                <asp:Button Text="Registrar" runat="server" Id="btnEntrar" class="btn btn-primary" OnClick="btnEntrar_Click"  />
                                <asp:Button Text="Cancelar" runat="server" Id="Button1" class="btn btn-primary" OnClick="Button1_Click" />

                        </form>
                    </div>
                </div>
            </div>
    </main>
     


</body>
</html>

