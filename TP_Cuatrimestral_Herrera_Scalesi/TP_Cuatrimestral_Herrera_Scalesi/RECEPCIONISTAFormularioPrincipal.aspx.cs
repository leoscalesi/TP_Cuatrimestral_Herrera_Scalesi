﻿using System;
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
            if (Session["nombre"] == null || Session["apellido"] == null)
            {
               Response.Redirect("Error.aspx", false);
            }
            else
            {
                nombre = Session["nombre"].ToString();
                apellido = Session["apellido"].ToString();
                lblHolaRecepcionista.Text += nombre + " " + apellido;
            }
        }

        protected void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaFormularioNuevoPaciente.aspx", false);
        }

        protected void btnBrindarTurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTABrindarTurnos.aspx", false);
        }

        protected void btnListadoPacientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTAListadoPacientes.aspx", false);
        }

        protected void btnListadoMedicos_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaListadoMedicos.aspx", false);
        }

        protected void btnNuevoMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaMedico.aspx", false);
        }
    }
}