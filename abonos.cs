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
	public partial class abonos : Form
	{
		Conexion conexion = new Conexion();
		public abonos()
		{
			InitializeComponent();
		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void abonos_Load(object sender, EventArgs e)
		{
			dtpFinal.Value = DateTime.Now;

			DateTime nuevaFecha = DateTime.Now;
			nuevaFecha = nuevaFecha.AddDays(-15);
			dtpInical.Value = nuevaFecha;
		}

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

		private void dtpInical_ValueChanged(object sender, EventArgs e)
		{
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad, a.fecha as Fecha from abonos as a inner join Reserva as r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and convert(numeric(10, 2), (a.cantidad)) > 0 and r.nombre like '" + tbCliente.Text + "%'";
			dgabonos.DataSource = conexion.llenarVistas(query2);
		}

		private void dtpFinal_ValueChanged(object sender, EventArgs e)
		{
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad, a.fecha as Fecha from abonos as a inner join Reserva as r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and convert(numeric(10, 2), (a.cantidad)) > 0 and r.nombre like '" + tbCliente.Text + "%'";
			dgabonos.DataSource = conexion.llenarVistas(query2);
		}

		private void tbCliente_TextChanged(object sender, EventArgs e)
		{
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad, a.fecha as Fecha from abonos as a inner join Reserva as r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and convert(numeric(10, 2), (a.cantidad)) > 0 and r.nombre like '" + tbCliente.Text + "%'";
			dgabonos.DataSource = conexion.llenarVistas(query2);
		}
	}
}
