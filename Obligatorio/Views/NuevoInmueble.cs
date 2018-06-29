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
    public partial class NuevoInmueble : Form
    {
        public NuevoInmueble()
        {
            InitializeComponent();

            Clear();         
        }

        private void Clear()
        {
            ManagerRecursos.precio = 0;
            ManagerRecursos.departamento = "";
            ManagerRecursos.ciudad = "";
            ManagerRecursos.barrio = "";
            ManagerRecursos.direccionInmueble = "";
            ManagerRecursos.estado = "";
            ManagerRecursos.año = 0;
            ManagerRecursos.superficie = 0;
            ManagerRecursos.habitaciones = 0;
            ManagerRecursos.dormitorios = 0;
            ManagerRecursos.baños = 0;
            ManagerRecursos.garages = 0;
            ManagerRecursos.parrillero = false;
            ManagerRecursos.jardin = false;
            ManagerRecursos.gastosComunes = 0;
            ManagerRecursos.nroPiso = 0;
            ManagerRecursos.pisos = 0;
            ManagerRecursos.portero = false;
            ManagerRecursos.comentarios = "";
            ManagerRecursos.fotos = "";
            ManagerRecursos.titulo = "";
        }

        private void btnApartment_Click(object sender, EventArgs e)
        {
            Hide();
            NuevoApartamento nuevoApartamento = new NuevoApartamento();
            nuevoApartamento.Show();
            //using (NuevoApartamento Apartamento = new NuevoApartamento())
            //{
            //    Apartamento.ShowDialog();
            //    //Environment.Exit(0);
            //    //Application.Exit();
            //}
        }

        private void NuevoInmueble_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnhouse_Click(object sender, EventArgs e)
        {
            Hide();
            NuevaCasa nuevaCasa = new NuevaCasa();
            nuevaCasa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
