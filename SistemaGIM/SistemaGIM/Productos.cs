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
    public partial class Productos : Form
    {
        string estado = "";
        public Productos()
            
        {
            InitializeComponent();
        }

        private void btnInsetar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "insertar";

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            pnlRegistros.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = false;
            pnlRegistros.Enabled = true;
            estado = "editar";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (estado == "insertar")
            {

            }
            if(estado == "editar")
            {

            }
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //el evento eliminar se agregara despues de conectar la base de datos
        }
    }
}
