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
    public partial class LaunchScreen : Form
    {
        public LaunchScreen()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            using (Home Home = new Home())
            {
                Home.ShowDialog();
                //Environment.Exit(0);
                //Application.Exit();
            }
        }

        private void btnInmueble_Click(object sender, EventArgs e)
        {
            Hide();
            NuevoInmueble nuevoInmueble = new NuevoInmueble();
            nuevoInmueble.Show();
            //using (NuevoInmueble nuevoInmueble = new NuevoInmueble())
            //{
            //    nuevoInmueble.ShowDialog();
            //    //Application.Exit();
            //}
        }

        private void LaunchScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Casa casa1 = new Casa();
            casa1.Precio = 10000;
            casa1.Ubicacion = "Av.Italia 2245";
            casa1.Plantas = 2;
            casa1.Patio = true;
            casa1.Parrillero = false;
            casa1.MetrosEdificados = 40;
            casa1.Garages = 1;
            ManagerInmuebles.AgregarPropiedad(casa1);
            Casa casa2 = new Casa();
            casa1.Precio = 50000;
            casa1.Ubicacion = "Av.8 de Octubre 9999";
            casa1.Plantas = 2;
            casa1.Patio = true;
            casa1.Parrillero = false;
            casa1.MetrosEdificados = 40;
            casa1.Garages = 1;
            ManagerInmuebles.AgregarPropiedad(casa2);
            Casa casa3 = new Casa();
            casa1.Precio = 101010;
            casa1.Ubicacion = "Calle cualquiera 1234";
            casa1.Plantas = 5;
            casa1.Patio = true;
            casa1.Parrillero = true;
            casa1.MetrosEdificados = 1000;
            casa1.Garages = 6;
            ManagerInmuebles.AgregarPropiedad(casa3);
            
        }
    }
}
