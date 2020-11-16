<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categoria.aspx.cs" Inherits="SeguridadFrontEnd.Intranet.Categoria" %>

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
                            <h1 class="jumbotron-heading">CRUD Categoria</h1>
                         </section>
             <div class="container">
                <div class="row">
                    <form id="form2" runat="server">
                        
                        <div class="container" >
                            <!--Controles del formulario-->

                            <div class="row">
                                <div class="col">
                                <label for="exampleInputEmail1">Codigo Categoria:
                                    
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIdCodigoCategoria" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtIdCodigoCategoria" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="B">*</asp:RequiredFieldValidator>
                                                                   
                                </label>
                                <asp:TextBox runat="server" Id="txtIdCodigoCategoria" class="form-control"  placeholder="Codigo Categoria" style="width:400px"/>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                <label >Nombre: 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="RequiredFieldValidator" ForeColor="#FF3300" ValidationGroup="A">*</asp:RequiredFieldValidator>

                                </label>

                                <asp:TextBox runat="server" Id="txtNombre" class="form-control" placeholder="Nombre" style="width:400px"/>
                                </div>
                                <div class="col">
                                <label >Categoria Padre: 

                                </label>
                                    <asp:TextBox runat="server" Id="txtCatPadre" class="form-control" placeholder="Categoria Padre" style="width:400px"/>
                                </div>
                            </div>
                            
                            <br/>
                            
                            <p>
                                <asp:Button Text="Agregar" runat="server" Id="btnAgregar" class="btn btn-primary" ValidationGroup="A" OnClick="btnAgregar_Click"/>
                                <asp:Button Text="Eliminar" runat="server" Id="btnEliminar"  class="btn btn-primary" ValidationGroup="B" OnClick="btnEliminar_Click"/>
                                <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" class="btn btn-primary" ValidationGroup="A" OnClick="btnActualizar_Click"/>
                
                            </p>
                            
                                Buscar: <asp:TextBox runat="server" ID="txtBuscar" />
                                           
                                 
                                <asp:DropDownList runat="server" ID="ddlCriterio">
                                    <asp:ListItem Text="Codigo" />
                                    <asp:ListItem Text="Nombre" />
                                </asp:DropDownList>
                                <asp:Button Text="Buscar" runat="server" id="btnBuscar"  class="btn btn-primary" OnClick="btnBuscar_Click"/>
                            <br/><br/>
                            <div class="table-responsive"> 
                                <asp:GridView runat="server" ID="gvCategoria" CssClass="table table-hover"></asp:GridView>
                                </div>
   
                        </div>
                  </form>
                    </div>
            </div>

    </main>

</body>
</html>