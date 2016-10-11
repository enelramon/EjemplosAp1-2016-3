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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           


        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroUsuarios rUsuarios = new Registros.RegistroUsuarios();
            rUsuarios.MdiParent = this;
            rUsuarios.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuarios cUsuarios = new Consultas.ConsultaUsuarios();
            cUsuarios.MdiParent = this;
            cUsuarios.Show();
        }
    }
}
