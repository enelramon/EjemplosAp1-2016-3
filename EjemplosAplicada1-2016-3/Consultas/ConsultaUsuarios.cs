using Entidades;
using Microsoft.Reporting.WinForms;
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
        public List<Usuarios> lista = new List<Usuarios>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {

                lista = BLL.UsuariosBll.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
            }
            else
            {
                lista = BLL.UsuariosBll.GetLista();
            }

            DatosdataGridView.DataSource = lista;
        }

        private void Imprimebutton_Click(object sender, EventArgs e)
        {
            MyViewer viewer = new MyViewer();

            viewer.RptViewer.Reset();
            viewer.RptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.RptViewer.LocalReport.ReportPath = @"Reportes\ListadoUsuarios.rdlc";

            viewer.RptViewer.LocalReport.DataSources.Clear();

      
            viewer.RptViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSetUsuarios", lista));

            viewer.RptViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
