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
    public partial class Inventarios : Form
    {
        string estado = "";
        public Inventarios()
        {
            InitializeComponent();
        }

        private void btnInsetar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "insertar";
            
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
            inventarioTableAdapter.Fill(ds.Inventario, null, null, "", "", null, null, 1);
            productoTableAdapter.Fill(ds.Producto, null, "", "", null, 1);
        }

        private void actualizar()
        {
            inventarioTableAdapter.Fill(ds.Inventario, null, null, "", "", null, null, 1);
            productoTableAdapter.Fill(ds.Producto, null, "", "", null, 1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "editar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int seleccionado = data_producto.CurrentRow.Index;
            int seleccionado2 = data_inventario.CurrentRow.Index;
            if (estado == "insertar")
            {
               
                inventarioTableAdapter.Insert((int)data_producto.Rows[seleccionado].Cells[0].Value, Convert.ToInt32 (num_cantidad.Value), 1);
            }
            if (estado == "editar")
            {
                inventarioTableAdapter.Update((int)data_inventario.Rows[seleccionado2].Cells[0].Value, (int)data_producto.Rows[seleccionado].Cells[0].Value, Convert.ToInt32(num_cantidad.Value), 1);
            }

            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
            this.actualizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminar se agregar despues de conectar la base de datos

            DialogResult resultado;
            int seleccionado_bitacora = data_inventario.CurrentRow.Index;
            resultado = MessageBox.Show("Se Eliminara el registro ", "¿Esta seguro?", MessageBoxButtons.YesNo);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                inventarioTableAdapter.Delete((int)data_inventario.Rows[seleccionado_bitacora].Cells[0].Value);

                //this.Close();

            }
            this.actualizar();


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rpeInventario ri = new rpeInventario();
            ri.ShowDialog();
        }
    }
}
