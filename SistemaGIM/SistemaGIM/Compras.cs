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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        private void CargaMaestro()
        {
            this.compraTableAdapter.Fill(this.ds.Compra, null, null, "", null, 1);
        }

        private void gvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CargaDetalle();
        }
        private void CargaDetalle()
        {
            int Id = int.Parse(this.gvDatos.CurrentRow.Cells[0].Value.ToString());
            this.compraDetalleTableAdapter.Fill(this.ds.CompraDetalle, null, Id, null, "", null, 1);
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            this.CargaMaestro();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            repCompras rc = new repCompras();
            rc.ShowDialog();
        }
    }
}
