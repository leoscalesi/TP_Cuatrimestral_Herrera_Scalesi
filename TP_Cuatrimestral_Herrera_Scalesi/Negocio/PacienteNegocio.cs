using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class PacienteNegocio
    {

        public List<Paciente> listar()
        {
            List<Paciente> lista = new List<Paciente>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select nombre,apellido, dni, cuit, telefono, direccion, email from personas where id_rol=4");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Paciente aux = new Paciente();

                    aux.Nombre = (string)datos.Lector["nombre"].ToString();
                    aux.Apellido = (string)datos.Lector["apellido"].ToString();
                    aux.Dni = (short)datos.Lector["dni"]; // modificar en db a int
                    aux.Cuit = (string)datos.Lector["cuit"];
                    aux.Telefono = (string)datos.Lector["telefono"].ToString();
                    //aux.FechaNac = (DateTime)datos.Lector["fecha_nacimiento"];
                    aux.Direccion = (string)datos.Lector["direccion"].ToString();
                    aux.Email = (string)datos.Lector["email"];


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

    }
}
