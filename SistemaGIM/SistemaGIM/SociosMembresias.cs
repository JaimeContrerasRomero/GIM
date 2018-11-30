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
    public partial class SociosMembresias : Form
    {
        string estado = "";
        public SociosMembresias()
        {
            InitializeComponent();
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

            DialogResult resultado;
            int seleccionado_socioMenbrecia = data_socioMenbrecia.CurrentRow.Index;
            resultado = MessageBox.Show("Se Eliminara el registro ", "¿Esta seguro?", MessageBoxButtons.YesNo);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                socioMembresiaTableAdapter.Delete((int)data_socioMenbrecia.Rows[seleccionado_socioMenbrecia].Cells[0].Value);

                //this.Close();

            }
            this.actualizar();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            //boton guardar
            int seleccionado = data_socioMenbrecia.CurrentRow.Index;
            int seleccionado2 = data_Socio.CurrentRow.Index;
            int seleccionado3 = data_menbrecia.CurrentRow.Index;
            if (estado == "insertar")
            {
                socioMembresiaTableAdapter.Insert((int)data_Socio.Rows[seleccionado].Cells[0].Value, (int)data_menbrecia.Rows[seleccionado].Cells[0].Value,dateTimePicker1.Value,dateTimePicker2.Value,Convert.ToBoolean(numericUpDown1),1);

            }
            if (estado == "editar")
            {

                socioMembresiaTableAdapter.Update((int)data_socioMenbrecia.Rows[seleccionado2].Cells[0].Value, (int)data_Socio.Rows[seleccionado].Cells[0].Value, (int)data_menbrecia.Rows[seleccionado].Cells[0].Value, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToBoolean(numericUpDown1), 1);
            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton cancelar
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void SociosMembresias_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
            socioMembresiaTableAdapter.Fill(ds.SocioMembresia,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,1);
            socioTableAdapter.Fill(ds.Socio, null, "", "", "", null, "", "", null, 1);
            membresiaTableAdapter.Fill(ds.Membresia, null, "", null, 1);
        }
        private void actualizar()
        {
            socioMembresiaTableAdapter.Fill(ds.SocioMembresia, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1);
            socioTableAdapter.Fill(ds.Socio, null, "", "", "", null, "", "", null, 1);
            membresiaTableAdapter.Fill(ds.Membresia, null, "", null, 1);
        }

        private void gvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            repSociosMenbrecias rsm = new repSociosMenbrecias();
            rsm.ShowDialog();
        }
    }
}
