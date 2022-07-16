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
    public partial class RECEPCIONISTAFormularioCargarObservaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
           string observacion = txtObservaciones.Text;

           int idPaciente = int.Parse(Request.QueryString["idPaciente"].ToString());
           int idEspecialidad = int.Parse(Request.QueryString["idEspecialidad"].ToString());
           int idMedico = int.Parse(Request.QueryString["idMedico"].ToString());
           int hora = int.Parse(Request.QueryString["hora"].ToString());
            //DateTime fechaSeleccionada = DateTime.Parse(Request.QueryString["fechaSeleccionada"].ToString());
            string fecha = Request.QueryString["fecha"].ToString();


           TurnoNegocio turnoNegocio = new TurnoNegocio();
           
           if(turnoNegocio.guardar(idPaciente, idEspecialidad, idMedico, hora, fecha, observacion))
           {
                Response.Redirect("GuardadoExitoso.aspx",false);
           }

           


        }
    }
}