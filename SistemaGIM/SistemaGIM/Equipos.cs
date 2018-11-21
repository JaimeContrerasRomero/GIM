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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Estado == "insertar")
            {

            }
            if (Estado == "editar")
            {

            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
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

        }
    }
}
