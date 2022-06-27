using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Cuatrimestral_Herrera_Scalesi
{
    
    public partial class Agenda : System.Web.UI.Page
    {
        public List<int> lunes = new List<int>();
        public List<int> martes = new List<int>();
        public List<int> miercoles = new List<int>();
        public List<int> jueves = new List<int>();
        public List<int> viernes = new List<int>();
        public List<int> sabado = new List<int>();


        protected void Page_Load(object sender, EventArgs e)
        {
            AgendaNegocio agendaNegocio = new AgendaNegocio();

            int idMedico = 2;
            List<Agenda> listaAgenda = new List<Agenda>();

            agendaNegocio.cargaListaHorario(agendaNegocio.listar(idMedico), lunes, martes, miercoles, jueves, viernes, sabado);

            
            lunes = lunes.Distinct().ToList();
            martes = martes.Distinct().ToList();
            miercoles = miercoles.Distinct().ToList();
            jueves = jueves.Distinct().ToList();
            viernes = viernes.Distinct().ToList();
            sabado = sabado.Distinct().ToList();

            foreach (var item in lunes)
            {
                if (item == 10)
                {
                    lbl10Lunes.Text = "OCUPADO";
                }
                if (item == 11)
                {
                    lbl11Lunes.Text = "OCUPADO";
                }
                if (item == 12)
                {
                    lbl12Lunes.Text = "OCUPADO";
                }
                if (item == 13)
                {
                    lbl13Lunes.Text = "OCUPADO";
                }
                if (item == 14)
                {
                    lbl14Lunes.Text = "OCUPADO";
                }
                if (item == 15)
                {
                    lbl15Lunes.Text = "OCUPADO";
                }
            }

            foreach (var item in martes)
            {
                if (item == 10)
                {
                    lbl10Martes.Text = "OCUPADO";
                }
                if (item == 11)
                {
                    lbl11Martes.Text = "OCUPADO";
                }
                if (item == 12)
                {
                    lbl12Martes.Text = "OCUPADO";
                }
                if (item == 13)
                {
                    lbl13Martes.Text = "OCUPADO";
                }
                if (item == 14)
                {
                    lbl14Martes.Text = "OCUPADO";
                }
                if (item == 15)
                {
                    lbl15Martes.Text = "OCUPADO";
                }
            }

            foreach (var item in miercoles)
            {
                if (item == 10)
                {
                    lbl10Miercoles.Text = "OCUPADO";
                }
                if (item == 11)
                {
                    lbl11Miercoles.Text = "OCUPADO";
                }
                if (item == 12)
                {
                    lbl12Miercoles.Text = "OCUPADO";
                }
                if (item == 13)
                {
                    lbl13Miercoles.Text = "OCUPADO";
                }
                if (item == 14)
                {
                    lbl14Miercoles.Text = "OCUPADO";
                }
                if (item == 15)
                {
                    lbl15Miercoles.Text = "OCUPADO";
                }
            }

            foreach (var item in jueves)
            {
                if (item == 10)
                {
                    lbl10Jueves.Text = "OCUPADO";
                }
                if (item == 11)
                {
                    lbl11Jueves.Text = "OCUPADO";
                }
                if (item == 12)
                {
                    lbl12Jueves.Text = "OCUPADO";
                }
                if (item == 13)
                {
                    lbl13Jueves.Text = "OCUPADO";
                }
                if (item == 14)
                {
                    lbl14Jueves.Text = "OCUPADO";
                }
                if (item == 15)
                {
                    lbl15Jueves.Text = "OCUPADO";
                }
            }

            foreach (var item in viernes)
            {
                if (item == 10)
                {
                    lbl10Viernes.Text = "OCUPADO";
                }
                if (item == 11)
                {
                    lbl11Viernes.Text = "OCUPADO";
                }
                if (item == 12)
                {
                    lbl12Viernes.Text = "OCUPADO";
                }
                if (item == 13)
                {
                    lbl13Viernes.Text = "OCUPADO";
                }
                if (item == 14)
                {
                    lbl14Viernes.Text = "OCUPADO";
                }
                if (item == 15)
                {
                    lbl15Viernes.Text = "OCUPADO";
                }
            }

            foreach (var item in sabado)
            {
                if (item == 10)
                {
                    lbl10Sabado.Text = "OCUPADO";
                }
                if (item == 11)
                {
                    lbl11Sabado.Text = "OCUPADO";
                }
                if (item == 12)
                {
                    lbl12Sabado.Text = "OCUPADO";
                }
                if (item == 13)
                {
                    lbl13Sabado.Text = "OCUPADO";
                }
                if (item == 14)
                {
                    lbl14Sabado.Text = "OCUPADO";
                }
                if (item == 15)
                {
                    lbl15Sabado.Text = "OCUPADO";
                }
            }
        }
    }
}