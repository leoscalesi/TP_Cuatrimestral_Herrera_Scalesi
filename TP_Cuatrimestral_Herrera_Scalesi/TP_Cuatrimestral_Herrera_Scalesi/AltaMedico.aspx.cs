﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    public partial class AltaMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            
            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();

            try
            {
                if (!IsPostBack)
                {

                    ddlEspecialidades.DataTextField = "nombre";
                    ddlEspecialidades.DataSource = especialidadNegocio.listar();
                    ddlEspecialidades.DataBind();

                    if (Request.QueryString["id"] != null)
                    {
                        int id = int.Parse(Request.QueryString["id"].ToString());
                        List<Medico> temporal = (List<Medico>)Session["listaMedicos"];
                        Medico seleccionado = temporal.Find(x => x.Id == id);

                        lblId.Text = seleccionado.Id.ToString();
                        txtNombre.Text = seleccionado.Nombre;
                        txtApellido.Text = seleccionado.Apellido;
                        txtDni.Text = seleccionado.Dni.ToString();
                        txtCuit.Text = seleccionado.Cuit;
                        txtTelefono.Text = seleccionado.Telefono;
                        //fecha nacimiento
                        txtNroMatricula.Text = seleccionado.NumMatricula.ToString();
                        txtDireccion.Text = seleccionado.Direccion;
                        txtEmail.Text = seleccionado.Email;
                        txtClave.Text = seleccionado.Clave;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }



        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            // if: modificar medico // else: agregar medico
            if (Request.QueryString["id"] != null)
            {
                Rol rol = new Rol();
                rol.Id = 4;

                persona.Rol = rol;
                persona.Id = int.Parse(lblId.Text);
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
                persona.Estado = true;

                //para modif especialidad y matricula de medico
                Medico medico = new Medico();

                medico.NumMatricula = short.Parse(txtNroMatricula.Text);
                Especialidad especialidad = new Especialidad();
                especialidad.Id = ddlEspecialidades.SelectedIndex + 1;
                medico.Especialidad = especialidad;
                int id = persona.Id;

                PersonaNegocio personaNegocio = new PersonaNegocio();
                if (personaNegocio.modificar(persona))
                {
                    MedicoNegocio medicoNegocio = new MedicoNegocio();
                    if (medicoNegocio.modificarMedico(medico, id))
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
            else
            {
                //SIEMPRE ES MEDICO (id_rol = 2)

                Rol rol = new Rol();
                rol.Id = 2;

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
                persona.Estado = true;

                //PARA EL NRO MATRICULA

                Medico medico = new Medico();
                medico.NumMatricula = int.Parse(txtNroMatricula.Text);

                //AHORA TENGO QUE QUEDARME CON LA ESPECIALIDAD
                //ELEGIDA DEL ddl Y CARGARLA (NECESITO EL id DE LA ESP)


                Especialidad especialidad = new Especialidad();
                especialidad.Id = ddlEspecialidades.SelectedIndex + 1;

                medico.Especialidad = especialidad;


                //Puedo llamar al metodo agregar de PersonaNegocio

                PersonaNegocio personaNegocio = new PersonaNegocio();
                if (personaNegocio.agregar(persona))
                {

                    //DEBO RECUPERAR EL ID MATCHEANDO CON EL
                    //EMAIL (QUE ES UNICO).

                    //CREO EL METODO recuperarId (email) 
                    //En PersonaNegocio

                    //CREO EL METODO PARA agregarMedico (id_persona) 
                    //En MedicoNegocio


                    int id;
                    id = personaNegocio.recuperarId(persona.Email);

                    medico.IdPersona = id;

                    MedicoNegocio medicoNegocio = new MedicoNegocio();

                    if (medicoNegocio.agregarMedico(medico))
                    {
                        //Se agrego el medico en bd
                    }
                    else
                    {
                        
                        //No se agrego
                    }
                }
            }

            Response.Redirect("GuardadoExitoso.aspx", false);
        
        }

        protected void btnFormularioPrincipal_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecepcionistaFormularioPrincipal.aspx", false);

        }
    }

}
