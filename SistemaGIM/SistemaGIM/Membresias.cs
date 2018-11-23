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
    public partial class Membresias : Form
    {
        string estado = "";
        public Membresias()
        {
            InitializeComponent();
        }

        private void Membresias_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
            this.actualizar();
        }

        public void actualizar()
        {
            membresiaTableAdapter.Fill(ds.Membresia, null, "", null, 1);
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
            //eliminar se agregar despues de conectar la base de datos
            int seleccionado = gvDatos.CurrentRow.Index;

            DialogResult pregunta;
            pregunta = MessageBox.Show("Desea Eliminar el registro", "¿Esta seguro", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                
                membresiaTableAdapter.Delete((int)gvDatos.Rows[seleccionado].Cells[0].Value);
            }
            this.actualizar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {
                
                membresiaTableAdapter.Insert(txb_descripcion.Text, num_precio.Value, 1);
            }
            if (estado == "editar")
            {
                int seleccionado = gvDatos.CurrentRow.Index;
                membresiaTableAdapter.Update((int)gvDatos.Rows[seleccionado].Cells[0].Value, txb_descripcion.Text,num_precio.Value, 1);

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
    }
}
