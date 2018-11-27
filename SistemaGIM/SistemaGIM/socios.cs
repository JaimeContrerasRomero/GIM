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
    public partial class socios : Form
    
    {
        string estado = "";
        public socios()
        {
            InitializeComponent();
        }
        private void socios_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
            this.actualizar();
        }
        private void btnInsetar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "insertar";
        }
        private void actualizar()
        {
            socioTableAdapter.Fill(ds.Socio, null, "", "", "", null, "", "", null, 1);
            limpiar_datos();

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
            int index = gvDatos.CurrentRow.Index;
            DialogResult pregunta;
            pregunta = MessageBox.Show("Eliminar registro", "¿esta seguro",MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {

                socioTableAdapter.Delete((int)gvDatos.Rows[index].Cells[0].Value);
                this.actualizar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton guardar
            if (estado == "insertar")
            {
                socioTableAdapter.Insert(txt_nombre_socio.Text, txt_primerApellido_socio.Text, txt_SegundoApellido_socio.Text, dtp_Fn_socio.Value, txt_Telefono_socio.Text, txt_CodigoBarras_socio.Text, dtp_fi_socio.Value, 1);

            }
            if (estado == "editar")
            {
                int selecionado = gvDatos.CurrentRow.Index;
                socioTableAdapter.Update((int)gvDatos.Rows[selecionado].Cells[0].Value, txt_nombre_socio.Text, txt_primerApellido_socio.Text, txt_SegundoApellido_socio.Text, dtp_Fn_socio.Value, txt_Telefono_socio.Text, txt_CodigoBarras_socio.Text, dtp_fi_socio.Value, 1);

      

            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
            this.actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton cancelar
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }
        public void limpiar_datos()
        {
            txt_nombre_socio.Text = "";
            txt_primerApellido_socio.Text = "";
            txt_SegundoApellido_socio.Text = "";
            txt_Telefono_socio.Text = "";
            txt_CodigoBarras_socio.Text = "";
           
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            repSocios rep = new repSocios();
            rep.ShowDialog();
        }
    }
}
