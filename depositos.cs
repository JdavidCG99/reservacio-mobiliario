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
	public partial class depositos : Form
	{
		public depositos()
		{
			InitializeComponent();
		}
		Conexion bdd = new Conexion();

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void depositos_Load(object sender, EventArgs e)
		{
			dtFin.Value = DateTime.Now;

			DateTime nuevaFecha = DateTime.Now;
			nuevaFecha = nuevaFecha.AddDays(-15);
			dtInicio.Value = nuevaFecha;
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

		private void dtInicio_ValueChanged(object sender, EventArgs e)
		{
			string entrada = " select r.idReserva as Reserva, r.nombre as Cliente, ed.fecha as Fecha, ed.cantidad as Cantidad " +
				"from entradaDepositos as ed inner join Reserva as r on ed.idReserva = r.idReserva where convert(numeric(10, 2), (ed.cantidad))> 0  " +
				"and ed.fecha between '" + dtInicio.Text + "' and '" + dtFin.Text + "'";

			dgEntradas.DataSource = bdd.llenarVistas(entrada);

			string salida = "select costo as Cantidad,fecha as Fecha,info as Descripcion from gastos where descripcion = 'depositos' " +
				"and fecha between '" + dtInicio.Text + "' and '" + dtFin.Text + "'";

			dgSalidas.DataSource = bdd.llenarVistas(salida);
		}

		private void dtFin_ValueChanged(object sender, EventArgs e)
		{
			string entrada = " select r.idReserva as Reserva, r.nombre as Cliente, ed.fecha as Fecha, ed.cantidad as Cantidad " +
				"from entradaDepositos as ed inner join Reserva as r on ed.idReserva = r.idReserva where convert(numeric(10, 2), (ed.cantidad))> 0  " +
				"and ed.fecha between '" + dtInicio.Text + "' and '" + dtFin.Text + "'";

			dgEntradas.DataSource = bdd.llenarVistas(entrada);

			string salida = "select costo as Cantidad,fecha as Fecha,info as Descripcion from gastos where descripcion = 'depositos' " +
				"and fecha between '" + dtInicio.Text + "' and '" + dtFin.Text + "'";

			dgSalidas.DataSource = bdd.llenarVistas(salida);
		}
	}
}
