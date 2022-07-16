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
            





                /*
                foreach (var item in listaAgendas)
                {
                    //TRABAJA ESE DIA?
                    if (item.DiaInicio == numdia)
                    {

                            //ME TRAIGO EL LISTADO DE TURNOS

                            List<int> listadoHoraTurnos = new List<int>();
                            TurnoNegocio turnoNegocio = new TurnoNegocio();
                            //listadoTurnos = turnoNegocio.listar();

                            //HAGO METODO PARA TRAERME TURNOS DE ESE MEDICO Y ESPECIALIDAD
                            //Y PARA ESA FECHA. PUEDEN SER VARIOS. AHI DEBO MATCHEAR
                            //CON AGENDA PARA VER DE LOS HORARIOS QUE TRABAJA
                            //CUALES TIENE AUN DISPONIBLES.

                            listadoHoraTurnos = turnoNegocio.buscarHorariosTurnoMedico(idEspecialidad, idMedico, fechaSeleccionada);

                            //COMPARO CON LA AGENDA DE ESE MEDICO

                        //BUSCO PACIENTE SI EN ESA FECHA Y HORA TIENE
                        //ALGO SIN IMPORTAR ESPECIALIDAD (bool)

                           PacienteNegocio pacienteNegocio = new PacienteNegocio();
                            bool encontroTurnoPaciente = turnoNegocio.buscarTurnoPaciente(fechaSeleccionada, hora,idPaciente);

                            //SI NO ENCONTRO DE AMBOS SE PUEDE TOMAR EL TURNO

                            if (!encontroTurnoMedico && !encontroTurnoPaciente)
                            {
                                //PUEDO TOMAR EL TURNO


                            }





                            //SI LOS DOS SON true O false RECIEN AHI PUEDE TOMAR 
                            //EL TURNO

                            //CAMBIAR
                            /*
                            foreach (var turno in listadoTurnos)
                            {
                                //EL TURNO DEPENDE DE SI EL MEDICO LO TOMO
                                if (turno.Medico.Id == idMedico)
                                {
                                    //SI COINCIDEN FECHA HORA NO PODRA TOMAR EL TURNO

                                    if (turno.FechaTurno == fechaSeleccionada && turno.HoraTurno == hora)
                                    {
                                        //NO PUEDE TOMAR EL TURNO
                                    }
                                }
                                else
                                {
                                    //PUEDE TOMAR EL TURNO
                                    //REDIRECCIONO AL FORMULARIO DE CARGAR OBSERVACIONES
                                }
                            }
                            */





            
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

            int hora = int.Parse(ddlHorarios.SelectedItem.ToString());

            Response.Redirect("RECEPCIONISTAFormularioCargarObservaciones.aspx?idPaciente=" + idPaciente + "&idEspecialidad=" + idEspecialidad + "&idMedico=" + idMedico + "&fecha=" + fecha + "&hora=" + hora,false);

        }

        protected void ddlHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hora = int.Parse(ddlHorarios.SelectedItem.ToString());

            //CUALQUIER HORARIO QUE FIGURE SERA DISPONIBLE ENEL ddlHorarios


        }

        protected void calCalendario_SelectionChanged(object sender, EventArgs e)
        {
           
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

            agendaNegocio.cargaIntervaloHorarios(horasAgenda, horasAgendaCompleta);

            //A PARTIR DE ACA DEBO TRABAJAR CON horasAgendaCompleta

            
            if (horasAgendaCompleta.Count > 0)
            {

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