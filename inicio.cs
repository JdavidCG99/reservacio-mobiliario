using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Reservaciones
{
    public partial class inicio : Form
    {
        Validaciones validaciones = new Validaciones();
        public inicio()
        {
            InitializeComponent();
        }

		Conexion y = new Conexion();

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if(txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.PasswordChar = '*';
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.Silver;
                txtContra.PasswordChar = char.Parse("\0"); 
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letrasNumeros(e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letrasNumeros(e);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
			/*if (txtUsuario.Text == "admin" & txtContra.Text == "lolis123")
            {
                ActiveForm.Hide();
                menu_inicio menu = new menu_inicio();
                menu.Show();

                menu.toolStripMenuItem2.Visible = true;
                Program.NombreUsuario = "admin";
            }
            else if (txtUsuario.Text == "usuario" & txtContra.Text == "12345")
            {
                ActiveForm.Hide();
                menu_inicio menu = new menu_inicio();
                menu.Show();

                Program.NombreUsuario = "usuario";
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Atencion");
            }*/

			string query = "select count(*) from users where name = '"+txtUsuario.Text+"' and contra = '"+txtContra.Text+"'";

			string res = y.getUnDato(query);

			//MessageBox.Show(res);

			if (Convert.ToInt32(res) > 0)
			{
				Program.NombreUsuario = txtUsuario.Text;

				ActiveForm.Hide();
				menu_inicio menu = new menu_inicio();
				menu.Show();

				if (Program.NombreUsuario.Equals("admin"))
				{
					menu.toolStripMenuItem2.Visible = true;
				}
			}
			else
			{
				MessageBox.Show("Usuario o contraseña incorrectos", "Atencion");
			}
		}
    }
}
