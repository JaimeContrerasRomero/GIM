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
    public partial class SocioPesos : Form
        
    {
        string estado = "";
        public SocioPesos()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SocioPesos_Load(object sender, EventArgs e)
        {
            paneles(true);
            estado = "inicio";
            cargadatos();
        }
        private void paneles(bool x)
        {
            this.pnlBotones.Enabled = x;
            this.pnlDatos.Enabled = x;
            this.pnlRegistros.Enabled =! x;

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            paneles(false);
            estado = "insertar";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            paneles(false);
            estado = "editar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿estas seguro de eliminar?", "eliminar", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                this.socioPesoTableAdapter.Delete(int.Parse(this.idSocioPesoTextBox.Text));
            }
            cargadatos();

        }
        private void cargadatos() {
            this.socioPesoTableAdapter.Fill(ds.SocioPeso, null, null, null, null, null, null, null, null, null, null, null, 1);
            int x = gvDatos.RowCount;
            if (x == 0)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;


            }
            else
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.paneles(true);
            estado = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(this.estado == "insertar")
            {
                this.socioPesoTableAdapter.Insert(int.Parse(this.idSocioTextBox.Text), this.pesoTextBox.Text, this.fechaDateTimePicker.Value, 1);
            }
            else if(this.estado == "editar")
            {
                this.socioPesoTableAdapter.Update(int.Parse(this.idSocioPesoTextBox.Text), int.Parse(this.idSocioTextBox.Text), this.pesoTextBox.Text, this.fechaDateTimePicker.Value,1);
            }
            cargadatos();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            repsociopesos rsp = new repsociopesos();
            rsp.ShowDialog();
        }
    }
}
