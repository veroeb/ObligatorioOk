using Obligatorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio.Views
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            NuevoInmueble nuevoInmueble = new NuevoInmueble();
            nuevoInmueble.Show();
        }

        public void Filtro()
        {
            bool filtrarPorDepartamento = true;
            bool filtrarPorBarrio = true;
            bool filtrarPorGarage = true;

            //List<Inmueble> listaInmuebles = new List<Inmueble>();

            Inmobiliaria inmobiliaria = Inmobiliaria.GetInmobiliaria();
            
            List<Inmueble> listaInmuebles = new List<Inmueble>();
            listaInmuebles = inmobiliaria.GetListaInmuebles();

            foreach (Inmueble i in listaInmuebles)
            {
                if (filtrarPorDepartamento)
                    listaInmuebles = listaInmuebles.Where(x => x.Departamento == comboBoxDepartamento.SelectedItem.ToString()).ToList();
                if (filtrarPorBarrio)
                    listaInmuebles = listaInmuebles.Where(x => x.Barrio == comboBoxBarrio.SelectedItem.ToString()).ToList();
                if (filtrarPorGarage)
                    listaInmuebles = listaInmuebles.Where(x => x.Garages == Convert.ToInt32(comboBoxGarage.SelectedItem.ToString())).ToList();
            }
        }
    }
}
