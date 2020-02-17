using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Producto.TipoProducto
{
    public partial class ConsultasTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaTipoProducto();
            }
        }

        protected void BtnBusqueda_Click(object sender, EventArgs e)
        {
            SqlDataSourceMostrandoImagenes.SelectParameters["Foto"]
        }


        public void listaTipoProducto()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["AbriendoConexionAlaBase"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();

            SqlCommand consulta = new SqlCommand("select * from TipoProducto;", conexion);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(consulta);
            DataSet baseProducto = new DataSet();

            sqlDataAdapter.Fill(baseProducto);
            listaDeTipoProducto.DataSource = baseProducto;
            listaDeTipoProducto.DataTextField = "TipoProducto";
            listaDeTipoProducto.DataValueField = "CodigoProducto";
            listaDeTipoProducto.DataBind();
            listaDeTipoProducto.Items.Insert(0, new ListItem("[Selecionar]","0"));


        }

    }
}