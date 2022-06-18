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
    public partial class RECEPCIONISTAFORMULARIONUEVOPACIENTE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            //SIEMPRE ES PACIENTE (id_rol = 4)

            Rol rol = new Rol();
            rol.Id = 4;

            persona.Rol = rol;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Dni = short.Parse(txtDni.Text);
            persona.Cuit = txtCuit.Text;
            persona.Telefono = txtTelefono.Text;

            //persona.FechaNac = DateTime.Parse(txtFechaNacimiento.Text);

            //persona.FechaNac = DateTime.Now.Date.ToString("yyyy-mm-dd");


            persona.Direccion = txtDireccion.Text;
            persona.Email = txtEmail.Text;
            persona.Clave = txtClave.Text;



            //Puedo llamar al metodo agregar de PersonaNegocio

            PersonaNegocio personaNegocio = new PersonaNegocio();
            if (personaNegocio.agregar(persona))
            {
                lblGuardadoExitoso.Text += "Guardado exitoso";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDni.Text = "";
                txtCuit.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                txtEmail.Text = "";
                txtClave.Text = "";
            }

        }
    
    }
}