<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductoAgregar.aspx.cs" Inherits="Producto.Producto.ProductoAgregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <asp:Label ID="Label1" runat="server" Text="Tipo Producto: "></asp:Label>
    <asp:DropDownList ID="DropDownListDeProductoAgregado" runat="server" OnSelectedIndexChanged="DropListTipoProducto"></asp:DropDownList>
    <br/>
    <asp:Label ID="Label2" runat="server" Text="Producto: "></asp:Label>
    <asp:TextBox ID="TextBoxProductoAgregado" runat="server"></asp:TextBox>
            <asp:Label ID="LabelError" runat="server" Text="Label"></asp:Label>
    <br/>
    <asp:Label ID="Label3" runat="server" Text="Descripcion: "></asp:Label>
    <asp:TextBox ID="TextBoxDescripcionProductoAgregado" runat="server"></asp:TextBox>
    <br/>
    <asp:Label ID="Label4" runat="server" Text="Precio: "></asp:Label>
    <asp:TextBox ID="TextBoxPrecioProductoAgregado" runat="server" TextMode="Number"></asp:TextBox>
    <br/>
    <asp:Label ID="Label5" runat="server" Text="Medida: "></asp:Label>
    <asp:TextBox ID="TextBoxMedidaAgregado" runat="server" TextMode="Number"></asp:TextBox>
    <asp:DropDownList ID="DropDownListMedidaAgregado" runat="server"></asp:DropDownList>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Imagen: "></asp:Label>
    <asp:FileUpload ID="FileUploadimagenProductoAgregado" runat="server" />
    <br/>
    <asp:Label ID="Label7" runat="server" Text="Cantidad: "></asp:Label>
    <asp:TextBox ID="TextBoxCantidadProductoAgregado" runat="server" TextMode="Number"></asp:TextBox>
    <br/>
    <asp:Button ID="ButtonAgregarProducto" runat="server" Text="Agregar" Height="26px" OnClick="ButtonAgregarProducto_Click" />
    <asp:Button ID="ButtonEliminarProducto" runat="server" Text="Eliminar" />

            <br />
            <asp:Label ID="MensajeDeIngreso" runat="server" Text="Label"></asp:Label>

            <br />
            <asp:SqlDataSource ID="SqlDataSourceAgregandoProducto" runat="server" ConnectionString="<%$ ConnectionStrings:base_productoConnectionString1 %>" InsertCommand="INSERT INTO Productos(CodigoProducto, Producto, Descripcion, Precio, Medida, Foto, Cantidad) VALUES (@CodigoProducto, @Producto, @Descripcion, @Precio, @Medida, @Foto, @Cantidad)" ProviderName="<%$ ConnectionStrings:base_productoConnectionString1.ProviderName %>">
                <InsertParameters>
                    <asp:Parameter Name="CodigoProducto" />
                    <asp:Parameter Name="Producto" />
                    <asp:Parameter Name="Descripcion" />
                    <asp:Parameter Name="Precio" />
                    <asp:Parameter Name="Medida" />
                    <asp:Parameter Name="Foto" />
                    <asp:Parameter Name="Cantidad" />
                </InsertParameters>
            </asp:SqlDataSource>
            <br />

            <br />

</Content>
        </div>
    </form>
</body>
</html>
