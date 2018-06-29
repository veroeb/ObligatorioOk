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
    public partial class NuevaCasa : Form
    {
        public NuevaCasa()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Casa casa = new Casa
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
                Jardin = ManagerRecursos.jardin,
                GastosComunes = ManagerRecursos.gastosComunes,
            };

            ManagerInmuebles.AgregarPropiedad(casa);
            MessageBox.Show("Propiedad agregada correctamente");
            
            Hide();
            Home home = new Home();
            home.Show();
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
        }

        private void txtAñoConstruccion_TextChanged(object sender, EventArgs e)
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

        private void cbJardin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbJardin.SelectedItem.ToString() == "Si" || cbJardin.SelectedItem.ToString() == "si")
            {
                ManagerRecursos.jardin = true;
            }
            else if (cbJardin.SelectedItem.ToString() == "No" || cbJardin.SelectedItem.ToString() == "no")
            {
                ManagerRecursos.jardin = false;
            }
        }

        private void txtGastos_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.gastosComunes = float.Parse(txtGastos.Text);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            ManagerRecursos.titulo = txtTitulo.Text;
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

        private void btnAgregarFotos_Click(object sender, EventArgs e)
        {
            if (ImagesFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(ImagesFile.FileName);

                pbFoto1.Load(ImagesFile.FileName);
                //string[] files = ImagesFile.FileNames;

                //foreach(string img in files)
                //{
                //    PictureBox pic = new PictureBox();
                //    pic.Image = Image.FromFile(img);
                //    //pic.Location = pbFoto2;
                //}
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
        }

        private void NuevaCasa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
