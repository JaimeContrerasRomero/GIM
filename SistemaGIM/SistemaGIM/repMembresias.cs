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
    public partial class repMembresias : Form
    {
        public repMembresias()
        {
            InitializeComponent();
        }

        private void repMembresias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.Membresia' table. You can move, or remove it, as needed.
            this.MembresiaTableAdapter.Fill(this.ds.Membresia, null, "", null, 1);

            this.reportViewer1.RefreshReport();
        }
    }
}
