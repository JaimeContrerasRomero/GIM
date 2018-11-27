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
    public partial class Bitacoras : Form
    {
        string estado = "";
        DataTable bitacora = new ds.BitacoraDataTable();
        public Bitacoras()
        {
            InitializeComponent();
        }

        private void Bitacoras_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
            this.actualizar();
            prueba.Visible = false;
            
            
            

            
        }
        public void actualizar() {
            bitacoraTableAdapter.Fill(ds.Bitacora, null, null, "", "", "", null, "", null);
            usuarioTableAdapter.Fill(ds.Usuario, null, null, null, null, null, null, null, null);
        }


        private void btnInsetar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "insertar";
            panel_usuario.Enabled = true;

            




        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "editar";
            panel_bitacora.Enabled = true;
            panel_usuario.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminar se agregar despues de conectar la base de datos

            DialogResult resultado;
            int seleccionado_bitacora = datagrid_bitacora.CurrentRow.Index;
            resultado = MessageBox.Show("Se Eliminara el registro ", "¿Esta seguro?", MessageBoxButtons.YesNo);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                bitacoraTableAdapter.Delete((int)datagrid_bitacora.Rows[seleccionado_bitacora].Cells[0].Value);

                //this.Close();

            }
            this.actualizar();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int seleccionado = datagrid_usuario.CurrentRow.Index;
            

            string accion = (string)lbx_accion.SelectedItem;
            int accion_int = 0; ;
            if (accion == "insertar")
            {
                accion_int = 1;

            }
            if (accion == "actualizar")
            {
                accion_int = 2;

            }
            if (accion == "eliminar")
            {
                accion_int = 3;

            }
            if (accion == "ingreso al sistema")
            {
                accion_int = 4;

            }
            try
            {
                if (estado == "insertar")
                {




                    bitacoraTableAdapter.Insert((int)datagrid_usuario.Rows[seleccionado].Cells[0].Value, Convert.ToInt16(accion_int), txb_tabla.Text, DateTime.Now);



                }
                if (estado == "editar")
                {
                    int seleccionado_bitacora = datagrid_bitacora.CurrentRow.Index;
                    bitacoraTableAdapter.Update((int)datagrid_bitacora.Rows[seleccionado_bitacora].Cells[0].Value, (int)datagrid_usuario.Rows[seleccionado].Cells[0].Value, Convert.ToInt16(accion_int), txb_tabla.Text, DateTime.Now);

                }
            }
            catch (Exception aa)
            {

                MessageBox.Show(aa.ToString());
            }

            
            this.actualizar();
            
           
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            repBitacora rp = new repBitacora();
            rp.ShowDialog();
        }
    }
}
