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
    public partial class repUsuario : Form
    {
        public repUsuario()
        {
            InitializeComponent();
        }

        private void repUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.Usuario' Puede moverla o quitarla según sea necesario.
            this.UsuarioTableAdapter.Fill(this.ds.Usuario, null, null, null, null, null, null, null, 1);
            this.reportViewer1.RefreshReport();
        }
    }
}
