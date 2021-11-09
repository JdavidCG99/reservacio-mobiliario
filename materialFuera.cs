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
	public partial class materialFuera : Form
	{
		public materialFuera()
		{
			InitializeComponent();
		}
		Conexion bdd = new Conexion();

		private void materialFuera_Load(object sender, EventArgs e)
		{
			dtFecha.Value = DateTime.Now.Date;
			
			string query = "select dr.cantidad as Cantidad,p.nombre as Nombre,p.descripcion as Descripcion,r.nombre as Cliente," +
				"f.ubicacion as Ubicacion from Reserva as r inner join Flete as f on r.idFlete = f.idFlete inner join Detalle_Reserva" +
				" as dr on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos where ('"+DateTime.Now.Date+"' " +
				"between fechaSalida and fechaRegreso) and volvio='no' and dr.cantidad>0 and r.estatus=1";
			gvProdcutos.DataSource = bdd.llenarVistas(query);
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			string query = "select dr.cantidad as Cantidad,p.nombre as Nombre,p.descripcion as Descripcion,r.nombre as Cliente," +
				"f.ubicacion as Ubicacion from Reserva as r inner join Flete as f on r.idFlete = f.idFlete inner join Detalle_Reserva" +
				" as dr on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos where ('" + dtFecha.Text + "' " +
				"between fechaSalida and fechaRegreso) and volvio='no' and dr.cantidad>0 and r.estatus=1";
			gvProdcutos.DataSource = bdd.llenarVistas(query);
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
	}
}
