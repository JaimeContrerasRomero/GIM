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
    public partial class repBitacora : Form
    {
        public repBitacora()
        {
            InitializeComponent();
        }

        private void repBitacora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds.Bitacora' Puede moverla o quitarla según sea necesario.
            this.BitacoraTableAdapter.Fill(this.ds.Bitacora,null,null,"","","",null,"",null);
            
            this.rv_bitacora.RefreshReport();
        }
    }
}
