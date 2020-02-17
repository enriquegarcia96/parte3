using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Producto.TipoProducto
{
    public partial class EditarTipoProducto : System.Web.UI.Page
    {
        private static string codigoTipoProductos; 

        protected void Page_Init(object sender, EventArgs e)
        {
            Label2.Text = "Esta es  la primera vez.";
            codigoTipoProductos = (Request.QueryString["idTipo"]);
            cargarTipo();
        }


        private void cargarTipo()
        {
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM TipoProducto WHERE CodigoProducto = " + codigoTipoProductos + ";", conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    TextBox1.Text = registro["TipoProducto"].ToString();
                }
                conexion.Close();
            }
            catch (SqlException)
            {

            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string javaScript = "";
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand("UPDATE TipoProducto SET TipoProducto = '"+ TextBox1.Text + "' WHERE CodigoProducto="+codigoTipoProductos+";", conexion);
                int registro = comando.ExecuteNonQuery();
                
                if (registro != 0)
                {
                    javaScript = "Datos guardados correctamente";
                }
                else
                {
                    javaScript = "Error";
                }
                conexion.Close();
                Response.Write("<script>alert('" + javaScript + "');window.location.href='GestionTipoProducto.aspx'</script>");
                
            }
            catch (SqlException)
            {

            }
        }

     
    }
}
