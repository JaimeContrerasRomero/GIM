﻿using System;
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

            this.actualizar();
            

            
        }
        public void actualizar() {
            bitacoraTableAdapter.Fill(ds.Bitacora, null, null, "", "", "", null, "", null);
            usuarioTableAdapter.Fill(ds.Usuario, null, null, null, null, null, null, null, null);
            correccir_datagrid();
        }

        public void correccir_datagrid()
        {
            for (int i = 0; i < datagrid_bitacora.Rows.Count; i++)
            {
                datagrid_bitacora.Rows[i].Cells[3].Value = datagrid_bitacora.Rows[i].Cells[7].Value + " " + datagrid_bitacora.Rows[i].Cells[8].Value + " " + datagrid_bitacora.Rows[i].Cells[9].Value;

                if (Convert.ToInt32(datagrid_bitacora.Rows[i].Cells[2].Value) == 1)
                {
                    datagrid_bitacora.Rows[i].Cells[5].Value = "Inserto";
                }

                if (Convert.ToInt32(datagrid_bitacora.Rows[i].Cells[2].Value) == 2)
                {
                    datagrid_bitacora.Rows[i].Cells[5].Value = "Actualizo";
                }
                if (Convert.ToInt32(datagrid_bitacora.Rows[i].Cells[2].Value) == 3)
                {
                    datagrid_bitacora.Rows[i].Cells[5].Value = "Elimino";
                }
                if (Convert.ToInt32(datagrid_bitacora.Rows[i].Cells[2].Value) == 4)
                {
                    datagrid_bitacora.Rows[i].Cells[5].Value = "Ingreso Al Sistema";
                }

            }
        }
        public void Limpiar_campos()
        {
            this.txb_tabla.Text = "";
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
            int seleccion= datagrid_bitacora.CurrentRow.Index;
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "editar";
            panel_bitacora.Enabled = true;
            panel_usuario.Enabled = true;
            lbx_accion.SelectedItem = (string)datagrid_bitacora.Rows[seleccion].Cells[5].Value;
            txb_tabla.Text = (string)datagrid_bitacora.Rows[seleccion].Cells[4].Value;
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
            if (accion == "Inserto")
            {
                accion_int = 1;

            }
            if (accion == "Actualizo")
            {
                accion_int = 2;

            }
            if (accion == "Elimino")
            {
                accion_int = 3;

            }
            if (accion == "Ingreso Al Sistema")
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
            Limpiar_campos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
            Limpiar_campos();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            repBitacora rp = new repBitacora();
            rp.ShowDialog();
        }
    }
}
