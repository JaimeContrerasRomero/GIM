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
    public partial class Equipos : Form
    {
        string Estado = "";
        public Equipos()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            equipoTableAdapter.Fill(ds.Equipo, null, "", null, 1);
            this.Limpiar_campos();

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.Estado == "insertar")
            {

                this.equipoTableAdapter.Insert(nombreTextBox.Text, Convert.ToInt32(cantidadTextBox.Text), 1);
            }
            else if (this.Estado == "editar")
            {
                int seleccionado = equipoDataGridView.CurrentRow.Index;
                equipoTableAdapter.Update((int)equipoDataGridView.Rows[seleccionado].Cells[0].Value, nombreTextBox.Text, Convert.ToInt32(cantidadTextBox.Text), 1);
            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
            this.Actualizar();

        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;

            this.Actualizar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            Estado = "editar";
        }

        private void btnInsetar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            Estado = "insertar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            int seleccion = equipoDataGridView.CurrentRow.Index;

            resultado = MessageBox.Show("Se Eliminar el registro", "¿Esta seguro?", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                equipoTableAdapter.Delete((int)equipoDataGridView.Rows[seleccion].Cells[0].Value);
                this.Actualizar();
            }

        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        public void Limpiar_campos()
        {
            nombreTextBox.Text = "";
            cantidadTextBox.Text = "";

        }

    }
}
