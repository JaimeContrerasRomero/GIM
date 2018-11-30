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
    public partial class Usuarios : Form
    {
       
        private void actualizar()
        {
            UsuarioTA.Fill(ds.Usuario, null, null, null, null, null, null, null, 1);
            int nmmsw = gvDatos.RowCount;
            
            if (nmmsw == 0)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnReporte.Enabled = false;
            }
            else {
                btnEditar.Enabled = !false;
                btnEliminar.Enabled = true;
                btnReporte.Enabled = true;
            }
            
            UsuarioTA.Fill(ds.Usuario, null, null,null, null, null, null, null, 1);
            limpiar_datos();
        }
        
        public void limpiar_datos()
        {
            this.tbUsuario.Text = "";
            this.tbEmail.Text = "";
            this.tbContraseña.Text = "";
            this.tbNombre.Text = "";
            this.tbApellido1.Text = "";
            this.tbApellido2.Text = "";
        }
        public string EstadoForm = "Lectura";
        public Usuarios()
        {
            InitializeComponent();
        }
        public void HPANEL(bool stat)
        {
            this.pnlBotones.Enabled = stat;
            this.pnlDatos.Enabled = stat;
            this.pnlRegistros.Enabled = !stat;
        }

        private void btnInsetar_Click(object sender, EventArgs e)
        {
            HPANEL(false);
            this.tbUsuario.Text = "";
            this.tbContraseña.Text = "";
            this.tbEmail.Text = "";
            this.tbNombre.Text = "";
            this.tbApellido1.Text = "";
            this.tbApellido2.Text = "";
            this.tbEmail.Focus();
            this.EstadoForm = "Insertar";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HPANEL(false);
            this.EstadoForm = "Editar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = gvDatos.CurrentRow.Index;
             
            DialogResult SN = MessageBox.Show("Eliminar registro", "¿esta seguro?", MessageBoxButtons.YesNo);
            if (SN == DialogResult.Yes)
            {
                UsuarioTA.Delete((int)gvDatos.Rows[index].Cells[0].Value);
                this.actualizar();
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            repUsuario ru = new repUsuario();
            ru.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EstadoForm == "Insertar") 
            {
                if (this.tbNombre.Text != "" || this.tbUsuario.Text != "" || this.tbApellido1.Text != "" || this.tbApellido2.Text != "" || this.tbEmail.Text != "" || this.tbContraseña.Text != "")
                {
                    UsuarioTA.Insert(tbNombre.Text, tbApellido1.Text, tbApellido2.Text, null, tbEmail.Text, tbContraseña.Text, 1);
                    this.actualizar();
                }
                else {
                    MessageBox.Show("Datos Vacios", "Error al insertar datos", MessageBoxButtons.OK);
                }
            }
            
            if (EstadoForm == "Editar")
            {
                int sele = gvDatos.CurrentRow.Index;
                UsuarioTA.Update((int)gvDatos.Rows[sele].Cells[0].Value, tbNombre.Text, tbApellido1.Text, tbApellido2.Text, null, tbEmail.Text, tbContraseña.Text, 1);
                this.actualizar();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.HPANEL(true);
            this.EstadoForm = "Lectura";
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.actualizar();
            this.HPANEL(true);
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string imagen = OFD.FileName;
                    pbFoto.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex);
            }
        }
    }
}