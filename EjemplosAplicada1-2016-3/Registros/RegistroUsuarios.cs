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

            usuario.UsuarioId = 0;
            usuario.Nombre = "enel";
            usuario.Clave = "12345";

            if (UsuariosBll.Guardar(usuario))
            {
                MessageBox.Show("Guardo. ehehehehe");
            }
        }
    }
}
