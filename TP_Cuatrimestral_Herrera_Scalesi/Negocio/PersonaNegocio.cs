using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class PersonaNegocio
    {

        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();
            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                datos.setearConsulta("select nombre,apellido, dni, cuit, email, clave, id_rol from personas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Persona aux = new Persona();

                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Apellido = (string)datos.Lector["apellido"];

                    aux.Cuit = (string)datos.Lector["cuit"];
                    aux.Email = (string)datos.Lector["email"];
                    aux.Clave = (string)datos.Lector["clave"];
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

        public Persona validaUsuarioContraseña(string email, string contraseña, List<Persona> lista)
        {
            //Recorro la lista y busco que machee usuario y cont

            foreach (Persona persona in lista)
            {
                if (persona.Email == email && persona.Clave == contraseña)
                {
                    return persona;
                }
            }

            return null;
        }
    }
}
