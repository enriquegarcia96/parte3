<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="AgregarTipoProducto.aspx.cs" Inherits="Producto.AgregarProductoss" %>
<head>
    <style type="text/css">
        #Button1 {
            width: 61px;
        }
    </style>
</head>
<form id="form1" runat="server">
<Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</Content>
<Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <Label ID="Label2" runat="server" Text="Label">Tipo de Producto: </Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnAgregar" runat="server" OnClick="Button1_Click" Text="Agregar" />
    <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</Content>

</form>


