<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendedor.aspx.cs" Inherits="CapaWeb.Vendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Mantenimiento de la tabla Vendedor</h3>
    <p>CodVendedor: <asp:TextBox runat="server" Id="txtCodVendedor"/></p>
    <p>Apellido: <asp:TextBox runat="server" Id="txtApellido"/></p>
    <p>Nombres: <asp:TextBox runat="server" Id="txtNombres"/></p>
    <p>Usuario: <asp:TextBox runat="server" Id="txtUsuario"/></p>
    <p>Contrasena: <asp:TextBox runat="server" Id="txtContrasena"/></p>
    <p>
        <asp:Button Text="Agregar" runat="server" id="btnAgregar" OnClick="btnAgregar_Click"/>
        <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" />
        <asp:Button Text="Actualizar" runat="server" id="btnActualizar"/>

    </p>
    <asp:GridView runat="server" ID="gvVendedor" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvVendedor_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
</asp:Content>
