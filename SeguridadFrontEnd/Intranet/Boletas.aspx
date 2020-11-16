<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Boletas.aspx.cs" Inherits="SeguridadFrontEnd.Intranet.Boletas" %>

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
                            <h1 class="jumbotron-heading">CRUD Boletas</h1>
                         </section>
             <div class="container">
                <div class="row">
                    <form id="form2" runat="server">
                        
                        <div class="container" >
                            <!--Controles del formulario-->

                            <div class="row">
                                <div class="col">
                                <label for="exampleInputEmail1">Numero de la Boleta:
                                    
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIdNroBoleta" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtIdNroBoleta" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="B">*</asp:RequiredFieldValidator>
                                                                   
                                </label>
                                <asp:TextBox runat="server" Id="txtIdNroBoleta" class="form-control"  placeholder="Numero de la Boleta" style="width:400px"/>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                <label for="exampleInputEmail1">Codigo Cliente: 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCodCliente" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="A">*</asp:RequiredFieldValidator>

                                </label>

                                <asp:TextBox runat="server" Id="txtCodCliente" class="form-control" placeholder="Codigo Cliente" style="width:400px"/>
                                </div>
                                <div class="col">
                                <label for="exampleInputEmail1">Codigo Vendedor: 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCodVendedor" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="A">*</asp:RequiredFieldValidator>

                                </label>
                                    <asp:TextBox runat="server" Id="txtCodVendedor" class="form-control" placeholder="Codigo Vendedor" style="width:400px"/>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                <label for="exampleInputEmail1">Codigo Producto: 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCodProducto" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCodProducto" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="B">*</asp:RequiredFieldValidator>

                                </label>

                                <asp:TextBox runat="server" Id="txtCodProducto" class="form-control" placeholder="Codigo Producto" style="width:400px"/>
                                </div>
                                <div class="col">
                                <label for="exampleInputEmail1">Cantidad: 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCantidad" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCantidad" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="B">*</asp:RequiredFieldValidator>

                                </label>
                                    <asp:TextBox runat="server" Id="txtCantidad" class="form-control" placeholder="Cantidad" style="width:400px"/>
                                </div>
                            </div>
                            
                            <br/>
                            
                            <p>
                                <asp:Button Text="Agregar Boleta" runat="server" Id="btnAgregarBoleta" class="btn btn-primary" ValidationGroup="A" OnClick="btnAgregarBoleta_Click"  />
                                <asp:Button Text="Agregar Detalle" runat="server" Id="btnAgregarDetBoleta"  class="btn btn-primary" ValidationGroup="B" OnClick="btnEliminarDetBoleta_Click" />
                
                            </p>
                            
                                Buscar: <asp:TextBox runat="server" ID="txtBuscar" />
                                           
                                 
                                <asp:DropDownList runat="server" ID="ddlCriterio">
                                    <asp:ListItem Text="Nro Boleta" />
                                    <asp:ListItem Text="Cliente" />
                                </asp:DropDownList>
                                <asp:Button Text="Buscar" runat="server" id="btnBuscar"  class="btn btn-primary" OnClick="btnBuscar_Click"/>
                            <br/><br/>
                            <div class="table-responsive"> 
                                <asp:GridView runat="server" ID="gvBoleta" CssClass="table table-hover"></asp:GridView>
                                </div>
   
                        </div>
                  </form>
                    </div>
            </div>

    </main>

</body>
</html>
