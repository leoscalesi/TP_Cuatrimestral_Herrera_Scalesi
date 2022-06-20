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

        public bool agregar(Persona persona)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();


            try
            {
                //ARREGLAR LO DE LA FECHA DE NACIMIENTO

                accesoaDatos.setearConsulta("insert into PERSONAS (nombre,apellido,dni,cuit,telefono,direccion,email,clave,id_rol) values('" + persona.Nombre + "','" + persona.Apellido + "','" + persona.Dni + "', '" + persona.Cuit + "', '" + persona.Telefono + "' , '" + persona.Direccion + "', '" + persona.Email + "', '" + persona.Clave + "', '" + persona.Rol.Id + "'" + ")");
                //accesoaDatos.setearParametro("@IdMarca", articulo.Marca.Id);
                //accesoaDatos.setearParametro("@IdCategoria", articulo.Categoria.Id);

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

        public bool modificar(Persona persona)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();


            try
            {
                //ARREGLAR LO DE LA FECHA DE NACIMIENTO

                accesoaDatos.setearConsulta("update PERSONAS set nombre = '" + persona.Nombre + "', apellido = '" + persona.Apellido + "', dni = '" + persona.Dni + "', cuit = '" + persona.Cuit + "', telefono = '" + persona.Telefono + "', direccion = '" + persona.Direccion + "', email = '" + persona.Email + "', clave = '" + persona.Clave + "' where id = 14 ");
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

        public bool eliminar(string id)
        {
            AccesoaDatos accesoaDatos = new AccesoaDatos();


            try
            {
                //ARREGLAR LO DE LA FECHA DE NACIMIENTO

                accesoaDatos.setearConsulta("delete from personas where id = " + id + "");
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
