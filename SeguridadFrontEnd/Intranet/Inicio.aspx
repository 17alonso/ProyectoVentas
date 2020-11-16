<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="SeguridadFrontEnd.Intranet.Inicio" %>

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
            <a href="Menu.aspx" class="navbar-brand d-flex align-items-center">
            <strong>Sistema Ventas</strong>
            </a>
        </div>
    </div>

        <main role="main">
        <section class="jumbotron text-center">
            <div class="container">
                <form id="form1" runat="server"> 
                  <h1 class="jumbotron-heading">Elija una opción</h1>
                  <p>
                      <asp:Button Text="Inicio" runat="server" id="btnInicio" class="btn btn-primary" OnClick="btnInicio_Click"/>
                      <asp:Button Text="Cliente" runat="server" id="btnCliente" class="btn btn-primary" OnClick="btnCliente_Click" />
                      <asp:Button Text="Vendedor" runat="server" id="btnVendedor" class="btn btn-primary" OnClick="btnVendedor_Click"/>
                      <asp:Button Text="Producto" runat="server" id="btnProducto" class="btn btn-primary" OnClick="btnProducto_Click" />
                      <asp:Button Text="Categoria" runat="server" id="btnCategoria" class="btn btn-primary" OnClick="btnCategoria_Click"/>
                      <asp:Button Text="Boletas" runat="server" id="btnBoletas" class="btn btn-primary" OnClick="btnBoletas_Click" />
                      <asp:Button Text="Mis Ventas" runat="server" id="btnMisVentas" class="btn btn-primary" OnClick="btnMisVentas_Click" />
                      <asp:Button Text="Perfil" runat="server" id="btnPerfil" class="btn btn-primary" OnClick="btnPerfil_Click" />
                  </p>
                </form>
            </div>
      </section>

    </main>

</body>
</html>