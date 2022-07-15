using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class RECEPCIONISTAListadoPacientes : System.Web.UI.Page
    {
        static string id2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] == null || Session["apellido"] == null || (int)Session["id"] == 2)
            {
                Response.Redirect("Error.aspx", false);
            }

            if (!IsPostBack)
            {
                PacienteNegocio pacienteNegocio = new PacienteNegocio();
                dgvListadoPacientes.DataSource = pacienteNegocio.listar();
                dgvListadoPacientes.DataBind();
            }
        }

        protected void dgvListadoPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvListadoPacientes.SelectedRow.Cells[0].Text;
            Response.Redirect("RecepcionistaFormularioNuevoPaciente.aspx?id=" + id);
        }

        protected void dgvListadoPacientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Panel1.Visible = true;
            var id = dgvListadoPacientes.Rows[e.RowIndex].Cells[0].Text;
            id2 = id;
        }

        protected void btbFiltro_Click(object sender, EventArgs e)
        {
            PacienteNegocio pacienteNegocio = new PacienteNegocio();
            List<Paciente> listaFiltrada = pacienteNegocio.listar();
            if (txtFiltro.Text != "")
            {
                listaFiltrada = listaFiltrada.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.Apellido.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            }

            dgvListadoPacientes.DataSource = null;
            dgvListadoPacientes.DataSource = listaFiltrada;
            dgvListadoPacientes.DataBind();
        }

        protected void btnVolverAFormularioPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaFormularioPrincipal.aspx", false);
        }

        protected void btnPanelAceptar_Click(object sender, EventArgs e)
        {
            PersonaNegocio personaNegocio = new PersonaNegocio();
            ///if - aceptar - eliminar

            if (personaNegocio.eliminar(id2))
            {
                PacienteNegocio pacienteNegocio = new PacienteNegocio();
                //Session.Add("listaPacientes", pacienteNegocio.listar());
                dgvListadoPacientes.DataSource = pacienteNegocio.listar();
                dgvListadoPacientes.DataBind();
                Panel1.Visible = false;
            }
        }

        protected void btnPanelCancelar_Click(object sender, EventArgs e)
        {
            //cancelar
            Panel1.Visible = false;
        }
    }
}