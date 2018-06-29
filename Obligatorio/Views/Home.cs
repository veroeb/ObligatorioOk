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
        LaunchScreen launch = new LaunchScreen();

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
            launch.Show();
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

        private void Actualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ManagerInmuebles.ListaInmuebles;
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Vender_Click(object sender, EventArgs e)
        {
            InmuebleActual = (dataGridView1.SelectedRows[0].DataBoundItem as Inmueble);
            Comprador comprador = new Comprador(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text);
            CompradorActual = comprador; 
            ManagerInmuebles.VenderAlquilar(InmuebleActual, CompradorActual);
            MessageBox.Show("Propiedad vendida a " + CompradorActual.Nombre);
            dataGridView1.DataSource = ManagerInmuebles.ListaInmuebles;
        }

        private void Agendar_Click(object sender, EventArgs e)
        {
            InmuebleActual = (dataGridView1.SelectedRows[0].DataBoundItem as Inmueble);
            inmobiliaria.AgendarVisita(CompradorActual, InmuebleActual);
            MessageBox.Show("Visita Agendada correctamente con " + CompradorActual.Nombre);
            
        }

        private void btnAgregarComprador_Click(object sender, EventArgs e)
        {
            Comprador comprador = new Comprador(textBox1.Text, textBox4.Text, textBox3.Text, textBox2.Text);
            CompradorActual = comprador;
            Inmobiliaria.AgregarComprador(CompradorActual);
            MessageBox.Show("Comprador actual actualizado y agendado");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();            
        }
    }
}
