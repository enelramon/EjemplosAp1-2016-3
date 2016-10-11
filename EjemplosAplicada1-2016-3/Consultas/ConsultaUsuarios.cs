using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemplosAplicada1_2016_3.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void CamposComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var lista = new List<Usuarios>();

            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {

               lista =  BLL.UsuariosBll.GetLista(ToInt(FiltrotextBox.Text));
            }
            else
            {
                lista = BLL.UsuariosBll.GetLista();
            }

            DatosdataGridView.DataSource = lista;
        }

        private int ToInt(string Numero)
        {
            int retorno = 0;

            int.TryParse(Numero, out retorno);

            return retorno;
        }
    }
}
