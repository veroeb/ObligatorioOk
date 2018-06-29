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
        Comprador CompradorActual;
        Inmueble InmuebleActual;
        Inmobiliaria inmobiliaria = Inmobiliaria.GetInmobiliaria();
        

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //inmobiliaria.GetListaInmuebles();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Inmueble i in inmobiliaria.GetListaInmuebles())
            {
                listBox1.Items.Add(i.Precio + " " + i.Parrillero);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Inmobiliaria.GetInmobiliaria().VenderAlquilar(InmuebleActual, CompradorActual);
            ManagerInmuebles.VenderAlquilar(InmuebleActual, CompradorActual);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ManagerInmuebles.
        }

        private void btnAgregarComprador_Click(object sender, EventArgs e)
        {
            Comprador comprador = new Comprador(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text);
            CompradorActual = comprador;
            Visita.AgregarComprador(CompradorActual);
            Visita.AgregarCompradorArchivo();
        }
    }
}
