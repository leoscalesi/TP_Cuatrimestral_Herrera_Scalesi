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
    public partial class RECEPCIONISTACalendarioTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnCargarObservaciones_Click(object sender, EventArgs e)
        {

            //AL PRESIONAR EL BOTON DEBO IR AL OTRO FORM
            //CON EL idMedico,idPaciente,Fecha,idEspecialidad,hora

            int idPaciente = int.Parse(Request.QueryString["idPaciente"].ToString());
            int idEspecialidad = int.Parse(Request.QueryString["idEspecialidad"].ToString());
            int idPersona = int.Parse(Request.QueryString["idPersona"].ToString());
            MedicoNegocio medicoNegocio = new MedicoNegocio();
            int idMedico = medicoNegocio.buscaMedicoId(idPersona);
            DateTime fechaSeleccionada = calCalendario.SelectedDate;
            string fecha = fechaSeleccionada.ToString("yyyy-MM-dd");

            //int hora = int.Parse(ddlHorarios.SelectedItem.ToString());

            if (fechaSeleccionada < DateTime.Now.Date)
            {
                //FECHA INVALIDA


            }
            else
            {
                int hora = int.Parse(ddlHorarios.SelectedItem.ToString());
                Response.Redirect("RECEPCIONISTAFormularioCargarObservaciones.aspx?idPaciente=" + idPaciente + "&idEspecialidad=" + idEspecialidad + "&idMedico=" + idMedico + "&fecha=" + fecha + "&hora=" + hora, false);
            }
        }

        protected void ddlHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hora = int.Parse(ddlHorarios.SelectedItem.ToString());

            //CUALQUIER HORARIO QUE FIGURE SERA DISPONIBLE ENEL ddlHorarios


        }

        protected void calCalendario_SelectionChanged(object sender, EventArgs e)
        {

            ddlHorarios.Items.Clear();  
            //RECUPERO idPersona,idMedico,idEspecialidad

            int idPaciente = int.Parse(Request.QueryString["idPaciente"].ToString());
            int idEspecialidad = int.Parse(Request.QueryString["idEspecialidad"].ToString());
            int idPersona = int.Parse(Request.QueryString["idPersona"].ToString());

            //BUSCO A QUE IDMEDICO CORRESPONDE ESE IDPERSONA

            MedicoNegocio medicoNegocio = new MedicoNegocio();
            int idMedico = medicoNegocio.buscaMedicoId(idPersona);

            DateTime fechaSeleccionada = calCalendario.SelectedDate.Date;

            string fecha = fechaSeleccionada.ToString("yyyy-MM-dd");
            
           
            //EXTRAIGO EL DIA DE ESA FECHA PARA PODER VER EN AGENDA SI 
            //ESE DIA TRABAJA ESE MEDICO

            DayOfWeek dia = fechaSeleccionada.DayOfWeek;

            //PASO ESE DIA A ENTERO YA QUE EN BD LOS TENGO COMO ENTEROS
            //A LOS DIAS

            int numdia = 0;

            if (dia == DayOfWeek.Monday) numdia = 1;
            if (dia == DayOfWeek.Tuesday) numdia = 2;
            if (dia == DayOfWeek.Wednesday) numdia = 3;
            if (dia == DayOfWeek.Thursday) numdia = 4;
            if (dia == DayOfWeek.Friday) numdia = 5;
            if (dia == DayOfWeek.Saturday) numdia = 6;

            //ME TRAIGO LA AGENDA PARA ESE MEDICO Y ESA ESPECIALIDAD
            AgendaNegocio agendaNegocio = new AgendaNegocio();
            //List<Dominio.Agenda> listaAgendas = new List<Dominio.Agenda>();

            List<int> horasAgenda = new List<int>();
            //TAMBIEN ME TRAIGO LA HORA FIN
            horasAgenda = agendaNegocio.listarHorasAgendaDia(idEspecialidad, idMedico, numdia);

            //ELIMINA LOS HORARIOS REPETIDOS
            
            horasAgenda = horasAgenda.Distinct().ToList();

            List<int> horasAgendaCompleta = new List<int>();


            if (horasAgenda.Count > 0) {
                   agendaNegocio.cargaIntervaloHorarios(horasAgenda, horasAgendaCompleta);

                //A PARTIR DE ACA DEBO TRABAJAR CON horasAgendaCompleta



                    //BUSCO LOS HORARIOS QUE YA ESTAN RESERVADOS LOS
                    //TURNOS PARA ESA FECHA
                    List<int> listadoHoraTurnos = new List<int>();
                    TurnoNegocio turnoNegocio = new TurnoNegocio();
                    listadoHoraTurnos = turnoNegocio.buscarHorariosTurnoMedico(idEspecialidad, idMedico, fecha);

                    if (listadoHoraTurnos.Count > 0)
                    {

                        foreach (var horas_agenda in horasAgendaCompleta)
                        {

                            foreach (var horas_turno in listadoHoraTurnos)
                            {

                                if (horas_agenda != horas_turno)
                                {
                                    ddlHorarios.Items.Add(horas_agenda.ToString());
                                }
                                else
                                {
                                    //NO DISPONIBLE
                                }
                            }
                        }
                    }
                    else
                    {
                        //NO TIENE NADA ASIGNADO
                        //CARGO EN EL ddl TODOS LOS HORARIOS DE LA
                        //LISTA AGENDA


                        foreach (var item in horasAgendaCompleta)
                        {

                            ddlHorarios.Items.Add(item.ToString());
                        }


                    }

            }

            else
            {
                    //ESE DIA NO TRABAJA
            }

           

        }
    }
}