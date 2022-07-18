using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> listar()
        {
            List<Turno> lista = new List<Turno>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select id,id_medico,id_especialidad,fecha_turno,id_estado,observaciones_medico,observaciones_paciente,hora_turno,id_paciente from turnos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Turno aux = new Turno();

                    //aux.HoraInicio = (int)datos.Lector["hora_inicio"];
                    aux.Id = (int)datos.Lector["id"];
                    aux.Medico = new Medico();
                    aux.Medico.Id = (int)datos.Lector["id_medico"];
                    aux.Especialidad = new Especialidad();
                    aux.Especialidad.Id = (int)datos.Lector["id_especialidad"];
                    aux.FechaTurno = (DateTime)datos.Lector["fecha_turno"];
                    aux.Estado = new Estado();
                    //aux.Estado.Id = (int)datos.Lector["id_estado"];
                    //aux.ObservacionesMedico = (string)datos.Lector["observaciones_medico"];
                    //aux.ObservacionesPaciente = (string)datos.Lector["observaciones_paciente"];
                    aux.HoraTurno = (int)datos.Lector["hora_turno"];
                    aux.Persona = new Persona();
                    //aux.Persona.Id = (int)datos.Lector["id_paciente"];
                    

                    lista.Add(aux);

                }

                return lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }

        public List<int> buscarHorariosTurnoMedico(int idEspecialidad,int idMedico,string fecha)
        {

            AccesoaDatos datos = new AccesoaDatos();
            List<int> lista = new List<int>();

            

            try
            {

                datos.setearConsulta("select hora_turno from Turnos where id_especialidad= " + idEspecialidad + " and id_medico= " + idMedico + " and fecha_turno= " + "'" + fecha + "'" + " and activo = 1");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {

                    int hora = (int)datos.Lector["hora_turno"];

                    lista.Add(hora);
                }

                return lista;
                
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

            
        }

        public bool buscarTurnoPaciente(DateTime fecha, int hora,int idPaciente)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select * from Turnos where fecha_turno =" + fecha + "and hora_turno =" + hora + " and id_paciente =" + idPaciente);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {

                    return true;

                }
                else
                {
                    return false;
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }
    
        
        public bool guardar(int idPaciente,int idEspecialidad,int idMedico,int hora, string fecha, string observacion)
        {
            AccesoaDatos datos = new AccesoaDatos();
            int idEstado = 1;
            bool activo = true;

            try
            {

                datos.setearConsulta("insert into Turnos (id_paciente,id_especialidad,id_medico,hora_turno,fecha_turno,observaciones_paciente,id_estado,activo) values('" + idPaciente + "','" + idEspecialidad + "','" + idMedico + "','" + hora + "','" + fecha + "','" + observacion + "','" + idEstado + "','" + activo + "'" + ")");
                datos.ejecutarAccion();

                return true;


            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
    
        public List<Turno> listarTurnosMedico (int idMedico)
        {
            AccesoaDatos datos = new AccesoaDatos();
            List<Turno> turnos = new List<Turno>();
            

            try
            {

                datos.setearConsulta("select p.nombre,p.apellido,t.hora_turno,t.observaciones_medico,t.observaciones_paciente from personas as p inner join turnos as t on t.id_paciente = p.id where p.id in (select id_paciente from turnos where id_medico = " + idMedico + ")");
                datos.ejecutarLectura();
                

                while (datos.Lector.Read())
                {

                    Turno aux = new Turno();

                    //aux.FechaTurno = (string)datos.Lector["fecha_turno"].ToString();
                    //aux.FechaTurno = (DateTime)datos.Lector["fecha_turno"];
                    //aux.Id = (int)datos.Lector["id"];
                    aux.HoraTurno = (int)datos.Lector["hora_turno"];
                    aux.ObservacionesMedico = (string)datos.Lector["observaciones_medico"].ToString();
                    aux.ObservacionesPaciente = (string)datos.Lector["observaciones_paciente"].ToString();
                    
                    aux.Persona = new Persona(); 
                    aux.Persona.Nombre = (string)datos.Lector["nombre"].ToString();
                    aux.Persona.Apellido = (string)datos.Lector["apellido"].ToString();
                    
                    turnos.Add(aux);

                }

                
                return turnos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }

        }

        public bool cargarObservacion(int idTurno,string observacion)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();


            try
            {
                accesoaDatos.setearConsulta("update TURNOS set observaciones_medico = '" + observacion + "' where id = " + idTurno + " ");
                accesoaDatos.ejecutarAccion();

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                accesoaDatos.cerrarConexion();
            }


        }
    }
}

