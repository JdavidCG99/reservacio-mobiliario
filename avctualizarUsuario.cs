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
	public partial class avctualizarUsuario : Form
	{
		public avctualizarUsuario()
		{
			InitializeComponent();
		}
		Conexion bdd = new Conexion();

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			menu_inicio menu = new menu_inicio();
			if (Program.NombreUsuario == "admin")
			{
				menu.toolStripMenuItem2.Visible = true;
			}
			menu.Show();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string query = "update users set contra='"+contra.Text+"' where name='"+Program.NombreUsuario + "'";
			bdd.ejecutar(query);

			MessageBox.Show("Cambios realizados","Atencion");
			menu_inicio menu = new menu_inicio();
			if (Program.NombreUsuario == "admin")
			{
				menu.toolStripMenuItem2.Visible = true;
			}
			menu.Show();
			this.Close();
		}

		private void avctualizarUsuario_Load(object sender, EventArgs e)
		{
			user.Text = Program.NombreUsuario;
		}
	}
}
