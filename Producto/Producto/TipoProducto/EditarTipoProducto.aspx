<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarTipoProducto.aspx.cs" Inherits="Producto.TipoProducto.EditarTipoProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
    <asp:Label ID="Label2" runat="server" Text="Label">Tipo de Producto: </asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true"></asp:TextBox>
            <br />
            <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Editar" OnClick="Button1_Click"  />
    <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" />

        </div>
    </form>
</body>
</html>
