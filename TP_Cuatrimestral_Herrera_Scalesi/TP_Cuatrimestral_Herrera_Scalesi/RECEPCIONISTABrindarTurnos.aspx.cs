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
    public partial class RECEPCIONISTABrindarTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PacienteNegocio pacienteNegocio = new PacienteNegocio();
            dgvListarPacientes.DataSource = pacienteNegocio.listar();
            dgvListarPacientes.DataBind();


        }

        protected void btnNuevoTurno_Click(object sender, EventArgs e)
        {

        }
    }
}