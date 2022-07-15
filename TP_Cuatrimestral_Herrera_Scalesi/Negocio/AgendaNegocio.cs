using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class AgendaNegocio
    {

        public List<Agenda> listar(int idMedico)
        {
            List<Agenda> lista = new List<Agenda>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select dia_inicio,hora_inicio,hora_fin from agendas where id_medico = " + idMedico);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Agenda aux = new Agenda();

                    aux.HoraInicio = (int)datos.Lector["hora_inicio"];
                    aux.HoraFin = (int)datos.Lector["hora_fin"];
                    aux.DiaInicio = (int)datos.Lector["dia_inicio"];


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

        public void cargaListaHorario(List<Agenda> lista, List<int> lunes, List<int> martes, List<int> miercoles, List<int> jueves, List<int> viernes, List<int> sabado)
        {
            int hora = 0;

            foreach (var item in lista)
            {
                int difHoras = item.HoraFin - item.HoraInicio;

                //LUNES
                if (item.DiaInicio == 1)
                {
                    for (int i = 0; i <= difHoras; i++)
                    {
                        if (i == 0)
                        {
                            hora = item.HoraInicio;
                        }
                        else
                        {
                            hora += 1;
                        }

                        lunes.Add(hora);

                    }

                }

                //MARTES
                if (item.DiaInicio == 2)
                {
                    for (int i = 0; i <= difHoras; i++)
                    {
                        if (i == 0)
                        {
                            hora = item.HoraInicio;
                        }
                        else
                        {
                            hora += 1;
                        }

                        martes.Add(hora);
                    }

                }

                //MIERCOLES
                if (item.DiaInicio == 3)
                {
                    for (int i = 0; i <= difHoras; i++)
                    {
                        if (i == 0)
                        {
                            hora = item.HoraInicio;
                        }
                        else
                        {
                            hora += 1;
                        }

                        miercoles.Add(hora);
                    }

                }

                //JUEVES
                if (item.DiaInicio == 4)
                {
                    for (int i = 0; i <= difHoras; i++)
                    {
                        if (i == 0)
                        {
                            hora = item.HoraInicio;
                        }
                        else
                        {
                            hora += 1;
                        }

                        jueves.Add(hora);
                    }

                }

                //VIERNES
                if (item.DiaInicio == 5)
                {
                    for (int i = 0; i <= difHoras; i++)
                    {
                        if (i == 0)
                        {
                            hora = item.HoraInicio;
                        }
                        else
                        {
                            hora += 1;
                        }

                        viernes.Add(hora);
                    }

                }

                //SABADO
                if (item.DiaInicio == 6)
                {
                    for (int i = 0; i <= difHoras; i++)
                    {
                        if (i == 0)
                        {
                            hora = item.HoraInicio;
                        }
                        else
                        {
                            hora += 1;
                        }

                        sabado.Add(hora);
                    }

                }

            }
        }

        public List<int> listarHorasAgendaDia(int idEspecialidad, int idMedico,int numdia)
        {
            List<int> lista = new List<int>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select dia_inicio,hora_inicio from agendas where id_medico = " + idMedico + " and id_especialidad = " + idEspecialidad + " and dia_inicio = " + numdia);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    int hora = 0;

                    hora = (int)datos.Lector["hora_inicio"];
                    


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


        public bool guardar(int dia,int idMedico,int idEspecialidad,int horaInicio,int horaFin)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();

            try
            {
                accesoaDatos.setearConsulta("insert into AGENDAS (dia_inicio,id_medico,id_especialidad,hora_inicio,hora_fin) values('" + dia + "','" + idMedico + "','" + idEspecialidad + "', '" + horaInicio + "', '" + horaFin + "'" + ")");
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
