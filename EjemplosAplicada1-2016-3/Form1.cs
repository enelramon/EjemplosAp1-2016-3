using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace EjemplosAplicada1_2016_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = 0;
            usuario.Nombre = "enel";
            usuario.Clave = "12345";

            if (UsuariosBll.Insertar(usuario))
            {
                MessageBox.Show("Guardo. ehehehehe");
            }


        }
    }
}
