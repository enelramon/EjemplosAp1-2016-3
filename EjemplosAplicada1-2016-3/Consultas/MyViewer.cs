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
    public partial class MyViewer : Form
    {
        public MyViewer()
        {
            InitializeComponent();
        }

        private void MyViewer_Load(object sender, EventArgs e)
        {

            this.RptViewer.RefreshReport();
        }
    }
}
