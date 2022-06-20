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

    }
}
