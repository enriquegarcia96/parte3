<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultasTipoProducto.aspx.cs" Inherits="Producto.TipoProducto.ConsultasTipoProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Busqueda de producto"></asp:Label>
        <asp:DropDownList ID="listaDeTipoProducto" runat="server">
        </asp:DropDownList>
        <p style="margin-left: 160px">
            <asp:Button ID="BtnBusqueda" runat="server" OnClick="BtnBusqueda_Click" Text="Buscar" />
        </p>
        <p style="margin-left: 160px">
            &nbsp;&nbsp;<asp:GridView ID="GridViewMostrarImagenes" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceMostrandoImagenes">
                <Columns>
                    <asp:BoundField DataField="Foto" HeaderText="Foto" SortExpression="Foto" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourceMostrandoImagenes" runat="server" ConnectionString="<%$ ConnectionStrings:base_productoConnectionString1 %>" ProviderName="<%$ ConnectionStrings:base_productoConnectionString1.ProviderName %>" SelectCommand="  select Foto from Productos
  where CodigoProducto = @Co;"></asp:SqlDataSource>
        </p>
        <p style="margin-left: 160px">
            &nbsp;</p>
    </form>
</body>
</html>
