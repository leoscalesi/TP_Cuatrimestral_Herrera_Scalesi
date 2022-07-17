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
    public partial class MEDICOListadoTurnos : System.Web.UI.Page
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            if (Session["nombre"] == null || Session["apellido"] == null )
            {
                Response.Redirect("Error.aspx", false);
            }
            if(!IsPostBack)
            {
                nombre = Session["nombre"].ToString();
                apellido = Session["apellido"].ToString();
                lblHolaMedico.Text += nombre + " " + apellido;
                string idMedico = Session["idMedico"].ToString();
                int id = int.Parse(idMedico);
                
                List<Turno>listadoTurnos = new List<Turno>();
                TurnoNegocio turnoNegocio = new TurnoNegocio();
                listadoTurnos = turnoNegocio.listarTurnosMedico(id);

                
                dgvListadoTurnos.DataSource = listadoTurnos;
                dgvListadoTurnos.DataBind();
                
            }
        }

        protected void btnModAgrDiagnostico_Click(object sender, EventArgs e)
        {
            Response.Redirect("MEDICOAgregarModificarDiagnostico.aspx", false);
        }

        protected void dgvListadoTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var id = dgvListadoPacientes.SelectedRow.Cells[0].Text;

            var idTurno = dgvListadoTurnos.SelectedRow.Cells[0].Text;
            Session.Add("idTurno",idTurno);
            Response.Redirect("MEDICOAgregarModificarDiagnostico.aspx", false);
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx",false);
        }
    }
}