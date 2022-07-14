using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MedicoNegocio
    {

        public Medico buscarMedico(int idMedico)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select nro_matricula,id_persona,id from medicos where id = " + idMedico);
                datos.ejecutarLectura();

                Medico medico = new Medico();
                if (datos.Lector.Read())
                {
                    medico.NumMatricula = (int)datos.Lector["nro_matricula"];
                    medico.IdPersona = (int)datos.Lector["id_persona"];
                    medico.Id = (int)datos.Lector["id"];
                }


                return medico;
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


        public bool agregarMedico(Medico medico, List<int> IdEspecialidad)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();

            int idMedico = 0;

            try
            {

                //FALTARIA EL idEspecialidad

                accesoaDatos.setearConsulta("insert into medicos (id_persona,nro_matricula) values('" + medico.IdPersona + "','" + medico.NumMatricula + "'" + ")");
                accesoaDatos.ejecutarAccion();
                accesoaDatos.cerrarConexion();

                idMedico = buscaMedicoId(medico.IdPersona);

                for (int i = 0; i < IdEspecialidad.Count; i++)
                {
                    accesoaDatos.setearConsulta("insert into medicos_x_especialidad (id_medico,id_especialidad) values('" + idMedico + "','" + IdEspecialidad[i] + "'" + ")");
                    accesoaDatos.ejecutarAccion();
                    accesoaDatos.cerrarConexion();
                }

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

            return false;
        }

        public List<Medico> listar()
        {
            List<Medico> lista = new List<Medico>();
            AccesoaDatos datos = new AccesoaDatos();
            try
            {

                datos.setearConsulta("select m.id, m.id_persona, p.nombre, p.apellido, p.dni, m.nro_matricula, p.telefono, p.email, p.cuit, p.clave, p.estado, p.id_rol from personas as p Inner Join MEDICOS as m On m.id_persona = p.id where p.estado=1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Medico aux = new Medico();
                    aux.Id = (int)datos.Lector["id"];
                    aux.IdPersona = (int)datos.Lector["id_persona"];
                    aux.Nombre = (string)datos.Lector["nombre"].ToString();
                    aux.Apellido = (string)datos.Lector["apellido"].ToString();
                    aux.Dni = (short)datos.Lector["dni"];
                    aux.NumMatricula = (int)datos.Lector["nro_matricula"];
                    aux.Especialidad = new Especialidad();
                    //aux.Especialidad.Id = (int)datos.Lector["id_especialidad"];
                    aux.Cuit = (string)datos.Lector["cuit"];
                    aux.Telefono = (string)datos.Lector["telefono"].ToString();
                    //aux.Direccion = (string)datos.Lector["direccion"].ToString();
                    aux.Email = (string)datos.Lector["email"];
                    aux.Clave = (string)datos.Lector["clave"];
                    aux.Estado = (bool)datos.Lector["estado"];
                    aux.Rol = new Rol();
                    aux.Rol.Id = (int)datos.Lector["id_rol"];


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

        public bool modificarMedico(Medico medico, int idPersona)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();

            medico.IdPersona = idPersona;

            try
            {
                //ARREGLAR LO DE LA FECHA DE NACIMIENTO

                accesoaDatos.setearConsulta("update MEDICOS set id_especialidad = '" + medico.Especialidad.Id + "', nro_matricula = '" + medico.NumMatricula + "' where id_persona ='" + medico.IdPersona + "'");
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

        public int buscaMedicoId(int idpersona)
        {

            AccesoaDatos datos = new AccesoaDatos();
            int idMedico = 0;

            try
            {

                datos.setearConsulta("select id from medicos where id_persona = " + idpersona);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    idMedico = (int)datos.Lector["id"];

                }


                return idMedico;
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

        public List<int> buscaIdMedicosEspecialidad(int idEspecialidad)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();
            List<int> lista = new List<int>();

            try
            {
                accesoaDatos.setearConsulta("select id_medico from medicos_x_especialidad where id_especialidad = " + idEspecialidad);
                accesoaDatos.ejecutarLectura();

                while (accesoaDatos.Lector.Read())
                {

                    int aux;
                    aux = (int)accesoaDatos.Lector["id_medico"];


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
                accesoaDatos.cerrarConexion();
            }


        }

        public Medico buscarMedicoIdPersona(int idPersona)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select nro_matricula,id_persona,id from medicos where id_Persona = " + idPersona);
                datos.ejecutarLectura();

                Medico medico = new Medico();
                if (datos.Lector.Read())
                {
                    medico.NumMatricula = (int)datos.Lector["nro_matricula"];
                    medico.IdPersona = (int)datos.Lector["id_persona"];
                    medico.Id = (int)datos.Lector["id"];
                }


                return medico;
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
    }
}
    
    
    
  

