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

        public Medico buscarMedico(int id)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select nro_matricula from medicos where id_persona = " + id);
                datos.ejecutarLectura();

                Medico medico = new Medico();
                if (datos.Lector.Read())
                {
                    medico.NumMatricula = (short)datos.Lector["nro_matricula"];

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

        public bool agregarMedico(Medico medico)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();



            try
            {

                //FALTARIA EL idEspecialidad

                accesoaDatos.setearConsulta("insert into medicos (id_persona,nro_matricula) values('" + medico.IdPersona + "', '" + medico.NumMatricula + "'" + ")");
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

            return false;
        }

        public List<Medico> listar()
        {
            List<Medico> lista = new List<Medico>();
            AccesoaDatos datos = new AccesoaDatos();
            try
            {

                datos.setearConsulta("select p.id, p.nombre, p.apellido, p.dni, m.nro_matricula, m.id_especialidad, p.telefono, p.email, p.cuit, p.direccion, p.clave, p.estado, p.id_rol from personas as p Inner Join MEDICOS as m On m.id_persona = p.id where p.estado=1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Medico aux = new Medico();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Nombre = (string)datos.Lector["nombre"].ToString();
                    aux.Apellido = (string)datos.Lector["apellido"].ToString();
                    aux.Dni = (short)datos.Lector["dni"];
                    aux.NumMatricula = (short)datos.Lector["nro_matricula"];
                    aux.Especialidad = new Especialidad();
                    aux.Especialidad.Id = (int)datos.Lector["id_especialidad"];
                    aux.Cuit = (string)datos.Lector["cuit"];
                    aux.Telefono = (string)datos.Lector["telefono"].ToString();
                    aux.Direccion = (string)datos.Lector["direccion"].ToString();
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

                //accesoaDatos.setearConsulta("update PERSONAS set nombre = '" + persona.Nombre + "', apellido = '" + persona.Apellido + "', dni = '" + persona.Dni + "', cuit = '" + persona.Cuit + "', telefono = '" + persona.Telefono + "', direccion = '" + persona.Direccion + "', email = '" + persona.Email + "', clave = '" + persona.Clave + "', estado= '" + persona.Estado + "' where id = " + persona.Id + " ");
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

    }
}
