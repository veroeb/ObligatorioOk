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

            ManagerRecursos.barrio = "";
            ManagerRecursos.año = 0;
        }

        private void btnApartment_Click(object sender, EventArgs e)
        {
            Hide();
            using (NuevoApartamento Apartamento = new NuevoApartamento())
            {
                Apartamento.ShowDialog();
                //Environment.Exit(0);
                //Application.Exit();
            }
        }
    }
}
