using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemplosAplicada1_2016_3.Registros
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (!Validar())
            {
                MessageBox.Show("complete todos los datos");
                return;
            }

            usuario = LlenarClase();

            if (UsuariosBll.Guardar(usuario))
            {
                NewButton.PerformClick();

                MessageBox.Show("Guardo. ehehehehe");
            }
        }

        private bool Validar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Debe introducir el nombre");
                retorno = false;
            }

            return retorno;
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Utilidades.ToInt(usuarioIdTextBox.Text);
            usuario.Nombre = nombreTextBox.Text;
            usuario.Clave = claveTextBox.Text;

            return usuario;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {

        }
    }
}
