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
    public partial class repCompras : Form
    {
        public repCompras()
        {
            InitializeComponent();
        }

        private void repCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Compra' table. You can move, or remove it, as needed.
            this.CompraTableAdapter.Fill(this.ds.Compra, null, null, "", null, 1);

            this.reportViewer1.RefreshReport();
        }
    }
}
