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
                Application.Exit();
            }
        }

        private void btnInmueble_Click(object sender, EventArgs e)
        {
            Hide();
            using (NuevoInmueble nuevoInmueble = new NuevoInmueble())
            {
                nuevoInmueble.ShowDialog();
                Application.Exit();
            }
        }
    }
}
