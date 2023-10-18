using System;
using BiblotecaUsuarioG2_2024;
using System.Collections;
using System.Windows.Forms;
using ReproductorMusica_G2_GRAJ;

namespace Autetocacion_G2_GRAJ
{
    public partial class Form1 : Form
    {
        private ArrayList usuarios;

        public Form1()
        {
            InitializeComponent();
            usuarios = new ArrayList();
            CargarUsuarios();

        }

        private void CargarUsuarios()
        {
            usuarios.Add(new Usuario("Angel", "angel"));
            usuarios.Add(new Usuario("Joel", "joel"));

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            bool ingresoCorrecto = false;

            foreach (object usuario in usuarios)
            {
               
                Usuario miUusario = (Usuario)usuario;

                if (txtNombre.Text == miUusario.NomUusario && txtContraseña.Text ==miUusario.Password)
                {
                   // MessageBox.Show("Ingreso correcto");
                    ingresoCorrecto = true;
                    txtNombre.Clear();
                    txtContraseña.Clear();
                    FormReproductor formReproductor = new FormReproductor(this);
                    formReproductor.Show();
                    this.Hide();

                    break;
                }
               
            }

            if (!ingresoCorrecto)
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }




        }
    }
}
