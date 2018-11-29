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
    public partial class repsociopesos : Form
    {
        public repsociopesos()
        {
            InitializeComponent();
        }

        private void repsociopesos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.SocioPeso' Puede moverla o quitarla según sea necesario.
            this.SocioPesoTableAdapter.Fill(this.ds.SocioPeso, null, null, null, null, null, null, null, null, null, null, null,1  );

            this.reportViewer1.RefreshReport();
        }
    }
}
