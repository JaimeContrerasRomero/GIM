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
    public partial class rpeInventario : Form
    {
        public rpeInventario()
        {
            InitializeComponent();
        }

        private void rpeInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.Inventario' Puede moverla o quitarla según sea necesario.
            this.InventarioTableAdapter.Fill(this.ds.Inventario,null,null,"","",null,null,1);

            this.reportViewer1.RefreshReport();
        }
    }
}
