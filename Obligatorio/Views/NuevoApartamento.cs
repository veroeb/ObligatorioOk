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
    public partial class NuevoApartamento : Form
    {
        public NuevoApartamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            NuevoInmueble nuevoInmueble = new NuevoInmueble();
            nuevoInmueble.ShowDialog();
        }

        private void ImagesFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAgregarFotos_Click(object sender, EventArgs e)
        {
            if (ImagesFile.ShowDialog() == DialogResult.OK)
            {
                //lblImage.Text = openFileDialog1.FileName;
                if(pbFoto1.)
                pbFoto1.Load(ImagesFile.FileName);

                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
