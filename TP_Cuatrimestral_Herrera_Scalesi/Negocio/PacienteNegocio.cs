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

                datos.setearConsulta("select p.nombre, p.apellido, p.dni, p.cuit, p.telefono, p.fecha_nacimiento, p.direccion, p.email, pa.id_turno from personas as p inner join pacientes as pa on p.id = pa.id_persona where id_rol = 4");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Paciente aux = new Paciente();

                    aux.nombre = (string)datos.Lector["nombre"];


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
