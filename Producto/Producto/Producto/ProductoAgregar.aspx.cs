using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Producto.Producto
{

    public partial class ProductoAgregar : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e){

            if (!IsPostBack)

            {
                listaDeProductos();

            }
        }

        protected void x(object sender, EventArgs e)
        {

        }


        private void listaDeProductos()
        {

            try
            {
                String abriendo = System.Configuration.ConfigurationManager.ConnectionStrings["AbriendoConexionAlaBase"].ConnectionString;
                SqlConnection conexion = new SqlConnection(abriendo);
                conexion.Open();

                SqlCommand consulta = new SqlCommand("select * from TipoProducto;", conexion);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta);
                DataSet baseProducto = new DataSet();

                sqlDataAdapter.Fill(baseProducto);
                DropDownListDeProductoAgregado.DataSource = baseProducto;
                DropDownListDeProductoAgregado.DataTextField = "TipoProducto";
                DropDownListDeProductoAgregado.DataValueField = "CodigoProducto";
                DropDownListDeProductoAgregado.DataBind();
                DropDownListDeProductoAgregado.Items.Insert(0, new ListItem("[selecionar]","0"));


            }
            catch (Exception error)
            {
                LabelError.Text = "no existe";

            }
        }

        protected void ButtonAgregarProducto_Click(object sender, EventArgs e)
        {

            try
            {


                SqlDataSourceAgregandoProducto.InsertParameters["CodigoProducto"].DefaultValue = DropDownListDeProductoAgregado.SelectedItem.Value;

                SqlDataSourceAgregandoProducto.InsertParameters["Producto"].DefaultValue = TextBoxProductoAgregado.Text;
                SqlDataSourceAgregandoProducto.InsertParameters["Descripcion"].DefaultValue = TextBoxDescripcionProductoAgregado.Text;
                SqlDataSourceAgregandoProducto.InsertParameters["Precio"].DefaultValue = TextBoxPrecioProductoAgregado.Text;
                SqlDataSourceAgregandoProducto.InsertParameters["Medida"].DefaultValue = TextBoxMedidaAgregado.Text;
                SqlDataSourceAgregandoProducto.InsertParameters["Foto"].DefaultValue = FileUploadimagenProductoAgregado.FileName;
                SqlDataSourceAgregandoProducto.InsertParameters["Cantidad"].DefaultValue = TextBoxCantidadProductoAgregado.Text;
                SqlDataSourceAgregandoProducto.Insert();
                LabelError.Text = "sepuo perrro";
            }
            catch (Exception err)
            {
                LabelError.Text = "Error reading list of names. ";
                LabelError.Text += err.Message;
            }


            /**
            try
            {


                String s = ConfigurationManager.ConnectionStrings["AbriendoConexionAlaBase"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                String consulta = "insert into [dbo].[Productos] [CodigoProducto],[Producto],[Descripcion],[Precio],[Medida],[Foto],[Cantidad] values (@CodigoProducto),(@Producto),(@Descripcion),(@Precio),(@Medida),(@Foto),(@Cantidad)";
                SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
                sqlCommand.Parameters.AddWithValue("@CodigoProducto", DropDownListDeProductoAgregado.SelectedItem.Value);
                conexion.Open();
                int i = sqlCommand.ExecuteNonQuery();
                if (i != 0)
                {
                    LabelError.Text = "seiso";
                }
                else
                {
                    LabelError.Text = "NOOOOO";
                }
            }
            catch(Exception err) {
                LabelError.Text = "Error reading list of names. ";
                LabelError.Text += err.Message;
            
            }

            **/


            /**
            try
            {
                String abriendo = ConfigurationManager.ConnectionStrings["AbriendoConexionAlaBase"].ConnectionString;
                SqlConnection conexion = new SqlConnection(abriendo);
                conexion.Open();
                
                string nam = DropDownListDeProductoAgregado.Text.Trim();
                int Sel_id = Convert.ToInt32(DropDownListDeProductoAgregado.SelectedValue);
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos(CodigoProducto, Producto, Descripcion, Precio, Medida, Foto, Cantidad) Values("+Sel_id+"','"+TextBoxProductoAgregado.Text+"','"+TextBoxDescripcionProductoAgregado.Text+"','"+TextBoxPrecioProductoAgregado.Text+"','"+"','"+TextBoxMedidaAgregado.Text+"','"+FileUploadimagenProductoAgregado.FileName+"','"+TextBoxCantidadProductoAgregado.Text+"','"+conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                LabelError.Text = "Error reading list of names. ";
                LabelError.Text += err.Message;
            }
            
            **/


            /**
            String insercion = System.Configuration.ConfigurationManager.ConnectionStrings["AbriendoConexionAlaBase"].ConnectionString;
            SqlConnection conexion = new SqlConnection(insercion);
            conexion.Open();
            SqlCommand consulta = new SqlCommand("INSERT INTO Productos(CodigoProducto,Producto,Descripcion,Precio,Medida,Foto,Cantidad) Values(" + DropDownListDeProductoAgregado.Items + "','" + TextBoxProductoAgregado.Text + "','" + TextBoxDescripcionProductoAgregado.Text + "','" + TextBoxPrecioProductoAgregado.Text + "','" + "','" + TextBoxMedidaAgregado.Text + "','" + FileUploadimagenProductoAgregado.FileName + "','" + TextBoxCantidadProductoAgregado.Text + "','" + conexion);
            int TesteoCorrecto = consulta.ExecuteNonQuery();
            if (TesteoCorrecto == 1)
            {
                LabelError.Text = "Datos ingresados correctamente";
            }
            else
            {
                LabelError.Text = "No se ingreso";
            }
            conexion.Close();  **/
        }


    }
}