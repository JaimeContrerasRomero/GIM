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
    public partial class GridUsuarios : Form
    {
        public string EstadoForm = "Lectura";
        public GridUsuarios()
        {
            InitializeComponent();
        }
        public void HPANEL(bool stat) {
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

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.HPANEL(true);
            this.EstadoForm = "Lectura";
        }
    }
}