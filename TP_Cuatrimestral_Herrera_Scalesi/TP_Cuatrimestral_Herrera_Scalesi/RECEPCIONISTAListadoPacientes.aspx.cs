﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaPacientes"] == null)
            {
                PacienteNegocio pacienteNegocio = new PacienteNegocio();
                Session.Add("listaPacientes", pacienteNegocio.listar());
                //dgvListadoPacientes.DataSource = pacienteNegocio.listar();
                //dgvListadoPacientes.DataBind();
                // listaPacientes = pacienteNegocio.listar();
            }
            dgvListadoPacientes.DataSource = Session["listaPacientes"];
            dgvListadoPacientes.DataBind();
        }

        protected void dgvListadoPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvListadoPacientes.SelectedRow.Cells[0].Text;
            Response.Redirect("RecepcionistaFormularioNuevoPaciente.aspx?id=" + id);
        }

        protected void dgvListadoPacientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = dgvListadoPacientes.Rows[e.RowIndex].Cells[0].Text;
            Persona persona = new Persona();
            PersonaNegocio personaNegocio = new PersonaNegocio();

            //preguntar si desea eliminar

            if (personaNegocio.eliminar(id))
            {
                //mostrar un "eliminado con exito"
                //recargar pagina para tener nuevo listado
            }
        }
    }
}