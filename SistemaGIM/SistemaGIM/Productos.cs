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
    public partial class Productos : Form
    {
        string estado = "";
        public Productos()
            
        {
            InitializeComponent();
        }

        private void btnInsetar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "insertar";

            

        }

        private void Productos_Load(object sender, EventArgs e)
        {

            pnlRegistros.Enabled = false;
            productoTableAdapter.Fill(ds.Producto, null, "", "",null,1);
            
            
        }

        
        private void Actualizar()
        {
            productoTableAdapter.Fill(ds.Producto, null, "", "", null, 1);
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "editar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {
                productoTableAdapter.Insert(txt_productos.Text,textBox1.Text,Convert.ToDecimal(num_producto.Value),1);
            }
            if(estado == "editar")
            {
                int seleccioando = gvDatos.CurrentRow.Index;
                productoTableAdapter.Update((int)gvDatos.Rows[seleccioando].Cells[0].Value, txt_productos.Text, textBox1.Text,Convert.ToDecimal( num_producto.Value),1);
            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
            this.Actualizar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int seleccionado = gvDatos.CurrentRow.Index;
            DialogResult resultado;
            resultado = MessageBox.Show("Se eliminar el registro", "¿Esta seguro", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                productoTableAdapter.Delete((int)gvDatos.Rows[seleccionado].Cells[0].Value, (string)gvDatos.Rows[seleccionado].Cells[1].Value, (string)gvDatos.Rows[seleccionado].Cells[2].Value, (decimal)gvDatos.Rows[seleccionado].Cells[3].Value, 0);

            }
            this.Actualizar();
            //el evento eliminar se agregara despues de conectar la base de datos
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rptProductos rp = new rptProductos();
            rp.ShowDialog();
            
        }
    }
}
