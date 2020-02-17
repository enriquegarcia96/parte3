using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionTipoProducto
{
    public partial class GestionTipoProducto : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.Columns[2].Visible = false;
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = GridView2.DataKeys[GridView2.SelectedIndex].Value.ToString();
            Response.Redirect("EditarTipoProducto.aspx?idTipo=" + valor +"");
        }
    }
}