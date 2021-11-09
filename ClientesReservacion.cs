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
	public partial class ClientesReservacion : Form
	{
		Conexion conexion = new Conexion();
		Validaciones validaciones = new Validaciones();

		public ClientesReservacion()
		{
			InitializeComponent();

			DateTime nuevaFecha = Convert.ToDateTime(fechaInicio.Value);
			nuevaFecha = nuevaFecha.AddMonths(-1);
			fechaInicio.Value = nuevaFecha;

			string query = "select r.idCliente as Id ,r.nombre as Nombre,Sum(convert(numeric(10, 2), (anticipo))) AS 'Consumido' " +
				" from Reserva as r inner join Cliente as c on r.idCliente = c.idCliente where(fechaReserva between '"+fechaInicio.Value+"' " +
				"and '"+fechaFin.Value+ "') and fechaReserva> '31-08-2021'  and anticipo>0  group by r.idCliente,r.nombre order by Consumido desc";

			conexion.grid(gvMayor, query);
		}

		private void fechaInicio_ValueChanged(object sender, EventArgs e)
		{
			string query = "select r.idCliente as Id ,r.nombre as Nombre,Sum(convert(numeric(10, 2), (anticipo))) AS 'Consumido' " +
				" from Reserva as r inner join Cliente as c on r.idCliente = c.idCliente where(fechaReserva between '" + fechaInicio.Value + "' " +
				"and '" + fechaFin.Value + "') and fechaReserva> '31-08-2021'  and anticipo>0  group by r.idCliente,r.nombre order by Consumido desc";

			conexion.grid(gvMayor, query);
		}

		private void fechaFin_ValueChanged(object sender, EventArgs e)
		{
			string query = "select r.idCliente as Id ,r.nombre as Nombre,Sum(convert(numeric(10, 2), (anticipo))) AS 'Consumido' " +
				" from Reserva as r inner join Cliente as c on r.idCliente = c.idCliente where(fechaReserva between '" + fechaInicio.Value + "' " +
				"and '" + fechaFin.Value + "') and fechaReserva> '31-08-2021'  and anticipo>0  group by r.idCliente,r.nombre order by Consumido desc";

			conexion.grid(gvMayor, query);
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			ActiveForm.Hide();
			menu_inicio menu = new menu_inicio();
			if (Program.NombreUsuario == "admin")
			{
				menu.toolStripMenuItem2.Visible = true;
			}
			menu.Show();
		}

		private void ClientesReservacion_Load(object sender, EventArgs e)
		{

		}
	}
}
