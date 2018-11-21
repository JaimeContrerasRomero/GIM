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
    public partial class MenuPrincipal : Form
    {
        public int IdUsuario { get; set; }

        public string NombreCompleto { get; set; }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //CERRAR TODO Y MANDARME AL LOGIN
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = this.NombreCompleto;
        }

        private void btnBoceto_Click(object sender, EventArgs e)
        {
            BocetoCatalogo bc = new BocetoCatalogo();
            bc.ShowDialog();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            SocioPesos sp = new SocioPesos();
            sp.ShowDialog();
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Inventarios inv = new Inventarios();
            inv.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            prov.ShowDialog();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            Bitacoras bita = new Bitacoras();
            bita.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos pr = new Productos();
            pr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Membresias m = new Membresias();
            m.ShowDialog();
        }

        private void btnSociosAsistencias_Click(object sender, EventArgs e)
        {
            SociosAsistencias sa = new SociosAsistencias();
            sa.ShowDialog();
        }

        private void btn_Socios_Click(object sender, EventArgs e)
        {
            socios so = new socios();
            so.ShowDialog();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Equipos eq = new Equipos();
           eq.ShowDialog();
        }
    }
}
