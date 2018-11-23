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
    public partial class Proveedores : Form
    {
        string estado = "";
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
            proveedorTableAdapter.Fill(ds.Proveedor, null, null, 1);
            
        }
        private void Actualizar()
        {
            proveedorTableAdapter.Fill(ds.Proveedor, null, null, 1);
            this.Limpiar_campos();

        }

        private void btnInsetar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "insertar";

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "editar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            int seleccion = gvDatos.CurrentRow.Index;

            resultado = MessageBox.Show("Se Eliminar el registro", "¿Esta seguro?", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                proveedorTableAdapter.Delete((int)gvDatos.Rows[seleccion].Cells[0].Value);
            }
            this.Actualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton de guardar
            if(estado == "insertar")
            {
                proveedorTableAdapter.Insert(txtNombreProveedor.Text, 1);
            }
            if (estado == "editar")
            {
                int Seleccionado = gvDatos.CurrentRow.Index;
                proveedorTableAdapter.Update((int)gvDatos.Rows[Seleccionado].Cells[0].Value, txtNombreProveedor.Text, 1);
            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
            this.Actualizar();
            //pnlBotones.Enabled = true;
            //pnlRegistros.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton cancelar
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }
        public void Limpiar_campos()
        {
            txtNombreProveedor.Text = "";
        }
    }
}
