using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class RecepcionistaFormularioPrincipal : System.Web.UI.Page
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Recupero las variables guardadas en Session

            nombre = Session["nombre"].ToString();
            apellido = Session["apellido"].ToString();

            lblHolaRecepcionista.Text += nombre + " " + apellido;
        }

        protected void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaFormularioNuevoPaciente.aspx", false);
        }

        protected void btnBrindarTurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTABrindarTurnos.aspx", false);
        }
    }
}