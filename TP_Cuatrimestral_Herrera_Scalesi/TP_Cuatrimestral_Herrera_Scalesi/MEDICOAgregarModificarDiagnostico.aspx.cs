using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class MEDICOAgregarModificarDiagnostico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || Session["idMedico"] == null)
            {
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnVolverATurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MEDICOListadoTurnos.aspx",false);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            string idTurno = Session["idTurno"].ToString();
            int id = int.Parse(idTurno);


            string observacion = txtDiagnostico.Text;   
            TurnoNegocio turnoNegocio = new TurnoNegocio();
            
            if (turnoNegocio.cargarObservacion(id,observacion))
            {
                Response.Redirect("GuardadoExitosoMedico.aspx", false);
            }
        }
    }
}