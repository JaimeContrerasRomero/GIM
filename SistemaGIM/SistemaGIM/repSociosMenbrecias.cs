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
    public partial class repSociosMenbrecias : Form
    {
        public repSociosMenbrecias()
        {
            InitializeComponent();
        }

        private void repSociosMenbrecias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.SocioMembresia' Puede moverla o quitarla según sea necesario.
            this.SocioMembresiaTableAdapter.Fill(this.ds.SocioMembresia, null, null, "", "", "", null, "", "", null, null, null, null, null, null, null, 1);

            this.reportViewer1.RefreshReport();
        }
    }
}
