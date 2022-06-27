﻿using System;
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

                datos.setearConsulta("select id, nombre,apellido, dni, cuit, email, clave, estado, id_rol from personas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Persona aux = new Persona();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.Apellido = (string)datos.Lector["apellido"];

                    aux.Cuit = (string)datos.Lector["cuit"];
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

                accesoaDatos.setearConsulta("insert into PERSONAS (nombre,apellido,dni,cuit,telefono,direccion,email,clave,estado, id_rol) values('" + persona.Nombre + "','" + persona.Apellido + "','" + persona.Dni + "', '" + persona.Cuit + "', '" + persona.Telefono + "' , '" + persona.Direccion + "', '" + persona.Email + "', '" + persona.Clave + "', '" + persona.Estado + "', '" + persona.Rol.Id + "'" + ")");
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
                
                accesoaDatos.setearConsulta("update PERSONAS set nombre = '" + persona.Nombre + "', apellido = '" + persona.Apellido + "', dni = '" + persona.Dni + "', cuit = '" + persona.Cuit + "', telefono = '" + persona.Telefono + "', direccion = '" + persona.Direccion + "', email = '" + persona.Email + "', clave = '" + persona.Clave +  "' where id = " + persona.Id +" ");
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

                accesoaDatos.setearConsulta("update PERSONAS set estado = 0 where id = " + id + "");
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

        public int recuperarId(string email)
        {

            AccesoaDatos accesoaDatos = new AccesoaDatos();


            try
            {

                accesoaDatos.setearConsulta("select id from personas where email = " + "'" + email + "'");
                accesoaDatos.ejecutarLectura();


                if (accesoaDatos.Lector.Read())
                {
                    int id;
                    id = (int)accesoaDatos.Lector["id"];
                    return id;

                }




            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                accesoaDatos.cerrarConexion();
            }

            return 0;

        }

    }
}
