<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="GestionTipoProducto.aspx.cs" Inherits="GestionTipoProducto.GestionTipoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label">Tipo Producto</asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" OnClick="BtnBuscar_Click" />
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="CodigoProducto" DataSourceID="SqlDataSource2" EmptyDataText="There are no data records to display." OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="TipoProducto" HeaderText="TipoProducto" SortExpression="TipoProducto" />
            <asp:BoundField DataField="CodigoProducto" HeaderText="CodigoProducto" InsertVisible="False" ReadOnly="True" SortExpression="CodigoProducto" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:base_productoConnectionString1 %>" DeleteCommand="DELETE FROM [TipoProducto] WHERE [CodigoProducto] = @CodigoProducto" InsertCommand="INSERT INTO [TipoProducto] ([TipoProducto]) VALUES (@TipoProducto)" SelectCommand="SELECT [TipoProducto], [CodigoProducto] FROM [TipoProducto]" UpdateCommand="UPDATE [TipoProducto] SET [TipoProducto] = @TipoProducto WHERE [CodigoProducto] = @CodigoProducto">
        <DeleteParameters>
            <asp:Parameter Name="CodigoProducto" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="TipoProducto" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="TipoProducto" Type="String" />
            <asp:Parameter Name="CodigoProducto" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
</asp:Content>
