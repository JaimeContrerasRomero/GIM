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
    public partial class Proveedores : Form
    {
        string estado = "";
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton de guardar
            if(estado == "insertar")
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
            //boton cancelar
            pnlBotones.Enabled = true;
            pnlRegistros.Enabled = false;
        }
        public void Limpiar_campos()
        {

        }
    }
}
