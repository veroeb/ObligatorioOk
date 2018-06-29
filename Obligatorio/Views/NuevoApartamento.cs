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
            Apartamento apartamento = new Apartamento
            {
                Precio = ManagerRecursos.precio,
                Departamento = ManagerRecursos.departamento,
                Ciudad = ManagerRecursos.ciudad,
                Barrio = ManagerRecursos.barrio,
                Ubicacion = ManagerRecursos.direccionInmueble,
                Estado = ManagerRecursos.estado,
                AñoConstruccion = ManagerRecursos.año,
                MetrosEdificados = ManagerRecursos.superficie,
                CantidadHabitaciones = ManagerRecursos.habitaciones,
                CantidadDormitorios = ManagerRecursos.dormitorios,
                CantidadBaños = ManagerRecursos.baños,
                Garages = ManagerRecursos.garages,
                Parrillero = ManagerRecursos.parrillero,
                Porteria = ManagerRecursos.portero,
                GastosComunes = ManagerRecursos.gastosComunes,
                Fotos = ManagerRecursos.fotos
            };

            ManagerInmuebles.AgregarPropiedad(apartamento);
            MessageBox.Show("Propiedad agregada correctamente");


            Hide();
            Home home = new Home();
            home.Show();
            //using (Home home = new Home())
            //{
            //    home.ShowDialog();
            //    //Application.Exit();
            //}
        }

        private void ImagesFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAgregarFotos_Click(object sender, EventArgs e)
        {
            //if (ImagesFile.ShowDialog() == DialogResult.OK)
            //{
            //    //lblImage.Text = openFileDialog1.FileName;
            //    if(pbFoto1.)
            //    pbFoto1.Load(ImagesFile.FileName);

            //    //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
            if (ImagesFile.ShowDialog() == DialogResult.OK)
            {
                pbFoto1.Load(ImagesFile.FileName);
                ManagerRecursos.fotos = ImagesFile.FileName;
                MessageBox.Show(ImagesFile.FileName);

                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.precio = float.Parse(txtPrecio.Text);
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.departamento = cbDepartamento.SelectedItem.ToString();
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.ciudad = cbCiudad.SelectedItem.ToString();
        }

        private void cbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.barrio = cbBarrio.SelectedItem.ToString();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.direccionInmueble = txtDireccion.Text;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.estado = cbEstado.SelectedItem.ToString();
            //Enum.TryParse<EstadoInmueble>(cbEstado.SelectedValue.ToString(), out ManagerRecursos.estado);
        }

        private void txtConstruccion_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.año = Convert.ToInt32(txtAñoConstruccion.Text);
        }

        private void txtSuperficie_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.superficie = float.Parse(txtSuperficie.Text);
        }

        private void cbHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.habitaciones = Convert.ToInt32(cbHabitaciones.SelectedItem.ToString());
        }

        private void cbDormitorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.dormitorios = Convert.ToInt32(cbDormitorios.SelectedItem.ToString());
        }

        private void cbBaños_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.baños = Convert.ToInt32(cbBaños.SelectedItem.ToString());
        }

        private void cbGarages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerRecursos.garages = Convert.ToInt32(cbGarages.SelectedItem.ToString());
        }

        private void cbParrillero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParrillero.SelectedItem.ToString() == "Si" || cbParrillero.SelectedItem.ToString() == "si")
            {
                ManagerRecursos.parrillero = true;
            }
            else if (cbParrillero.SelectedItem.ToString() == "No" || cbParrillero.SelectedItem.ToString() == "no")
            {
                ManagerRecursos.parrillero = false;
            }
        }

        private void cbPorteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPorteria.SelectedItem.ToString() == "Si" || cbPorteria.SelectedItem.ToString() == "si")
            {
                ManagerRecursos.portero = true;
            }
            else if (cbPorteria.SelectedItem.ToString() == "No" || cbPorteria.SelectedItem.ToString() == "no")
            {
                ManagerRecursos.portero = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.NombrePropietario = txtNombre.Text;
        }

        private void txtCI_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.CI = txtCI.Text;
        }

        private void txtDireccionPropietario_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.DireccionPropietario = txtDireccionPropietario.Text;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.Correo = txtCorreo.Text;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.Telefono = txtTelefono.Text;
        }

        private void txtComentarios_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.comentarios = txtComentarios.Text;
        }

        private void NuevoApartamento_Load(object sender, EventArgs e)
        {

        }

        private void NuevoApartamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtGastos_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.gastosComunes = float.Parse(txtGastos.Text);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.titulo = txtTitulo.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
