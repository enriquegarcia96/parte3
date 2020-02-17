using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Producto
{
    public partial class AgregarProductoss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = System.Configuration.ConfigurationManager.ConnectionStrings["AbriendoConexionAlaBase"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO TipoProducto(TipoProducto) VALUES('"+ TextBox1.Text + "');", conexion);
                int cantidad = comando.ExecuteNonQuery();
                string javaScript = "";
                if (cantidad == 1)
                {
                    javaScript = "Datos Guardados correctamente";                     
                }
                else
                {
                    javaScript = "Error";
                }
                Response.Write("<script>alert('"+ javaScript + "');window.location.href='GestionTipoProducto.aspx'</script>");
                conexion.Close();
            }
            catch (SqlException)
            {

            }
            
        }
    }
}