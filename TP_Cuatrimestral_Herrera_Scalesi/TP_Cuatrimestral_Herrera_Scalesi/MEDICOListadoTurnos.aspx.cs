using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class MEDICOListadoTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnModAgrDiagnostico_Click(object sender, EventArgs e)
        {
            Response.Redirect("MEDICOAgregarModificarDiagnostico.aspx", false);
        }
    }
}