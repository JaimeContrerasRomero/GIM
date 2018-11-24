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
    public partial class SociosAsistencias : Form
    {
        string estado = "";
        public SociosAsistencias()
        {
            InitializeComponent();
        }

        private void SociosAsistencias_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
            socioAsistenciaTableAdapter.Fill(ds.SocioAsistencia,null,null,"","","",null,"","",null,null,null,null,1);
            socioTableAdapter.Fill(ds.Socio,null,"","","",null,"","",null,1);


        }
        private void actualizar() {

            socioAsistenciaTableAdapter.Fill(ds.SocioAsistencia, null, null, "", "", "", null, "", "", null, null, null, null, 1);
            socioTableAdapter.Fill(ds.Socio, null, "", "", "", null, "", "", null, 1);
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
            int seleccionado_SocioAsistencia = dataSocioAsistencia.CurrentRow.Index;
            resultado = MessageBox.Show("Se Eliminara el registro ", "¿Esta seguro?", MessageBoxButtons.YesNo);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                socioAsistenciaTableAdapter.Delete((int)dataSocioAsistencia.Rows[seleccionado_SocioAsistencia].Cells[0].Value);

                //this.Close();

            }
            this.actualizar();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int seleccionado = dataSocioAsistencia.CurrentRow.Index;
            int seleccionado2 = dataSocio.CurrentRow.Index;
            
            if (estado == "insertar")
            {
                
                
              //  socioAsistenciaTableAdapter.Insert((int)dataSocio.Rows[seleccionado].Cells[0].Value,dt_fecha.Value,he_dateTimePicker,hs_dateTimePicker,1);

            }
            if (estado == "editar")
            {
                //socioAsistenciaTableAdapter.Update((int)dataSocioAsistencia.Rows[seleccionado2].Cells[0].Value, (int)dataSocio.Rows[seleccionado].Cells[0].Value ,dt_fecha.Value, he_dateTimePicker, hs_dateTimePicker, 1);

            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void pnlRegistros_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
