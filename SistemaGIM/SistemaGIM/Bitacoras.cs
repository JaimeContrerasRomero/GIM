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
        public Bitacoras()
        {
            InitializeComponent();
        }

        private void Bitacoras_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {


            }
            if (estado == "editar")
            {


            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }
    }
}
