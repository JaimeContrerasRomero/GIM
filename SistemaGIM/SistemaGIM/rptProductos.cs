using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGIM
{
    public partial class rptProductos : Form
    {
        public rptProductos()
        {
            InitializeComponent();
        }

        private void rptProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.Producto' Puede moverla o quitarla según sea necesario.
            this.ProductoTableAdapter.Fill(this.ds.Producto,null,"","",null,1);

            this.reportViewer1.RefreshReport();
        }
    }
}
