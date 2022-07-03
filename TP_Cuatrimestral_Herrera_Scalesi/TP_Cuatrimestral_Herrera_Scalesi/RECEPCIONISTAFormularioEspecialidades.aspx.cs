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
    public partial class RECEPCIONISTAFormularioEspecialidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LISTAR LAS ESPECIALIDADES

            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();

            try
            {
                if (!IsPostBack)
                {

                    ddlEspecialidades.DataTextField = "nombre";
                    //ddlEspecialidades.Items.Add("Especialidades");
                    ddlEspecialidades.DataSource = especialidadNegocio.listar();
                    ddlEspecialidades.DataBind();

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}