using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGIM.dsTableAdapters;

namespace SistemaGIM
{
    public partial class Login : Form
    {
        public int IdUsuario { get; set; }

        public string NombreCompleto { get; set; }

        UsuarioTableAdapter Usuario = new UsuarioTableAdapter();

        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaCampos())
                {
                    //conectar a la tabla usuario para validar si existe.
                    DataSet ds = new DataSet();
                    ds.Tables.Add(Usuario.GetData(null, "", "", "", null, this.txtUsuario.Text.Trim(), this.txtPasword.Text, 1));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        // Si encontró datos
                        DataRow row = ds.Tables[0].Rows[0];
                        this.IdUsuario = int.Parse(row["IdUsuario"].ToString());
                        this.NombreCompleto = row["Nombre"].ToString() + " " + row["PrimerApellido"].ToString() + " " + row["SegundoApellido"].ToString();
                        //Ir al menú principal
                        MenuPrincipal mp = new MenuPrincipal();
                        mp.IdUsuario = this.IdUsuario;
                        mp.NombreCompleto = this.NombreCompleto;
                        mp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o password son incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaCampos()
        {
            this.errorProvider1.Clear();
            bool valida = true;
            if (this.txtUsuario.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtUsuario, "Este campo es requerido");
                valida = false;
            }
            if (this.txtPasword.Text.Trim() == "")
            {
                this.errorProvider1.SetError(this.txtPasword, "Este campo es requerido");
                valida = false;
            }

            return valida;
        }
    }
}
