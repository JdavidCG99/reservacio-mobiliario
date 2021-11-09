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
	public partial class ProductosFaltantes : Form
	{
		Conexion bdd = new Conexion();
		public ProductosFaltantes()
		{
			InitializeComponent();
		}
		Boolean pantalla = false;
		public ProductosFaltantes(Boolean pantalla)
		{
			InitializeComponent();
			this.pantalla = pantalla;
		}

		private void ProductosFaltantes_Load(object sender, EventArgs e)
		{
			string query2 = "select mp.idNota as Id_Reservacion, mp.nombreCliente as Nombre_Cliente, mp.telefonoCliente as Celular," +
				" mp.idProducto, mp.cantidad as Cantidad,mp.producto as Producto,mp.descripcion as Descrpcion,f.ubicacion as Ubicacion," +
				"r.descripcionUbicacion as Descripcion_Ubicacion from materialPendiente as mp inner join Reserva as r on mp.idNota = r.idReserva inner join Flete as f " +
				"on r.idFlete = f.idFlete where mp.estatus=1";
			gvDeudas.DataSource = bdd.llenarVistas(query2);
		}

		private void txtBuscadorCliente_TextChanged(object sender, EventArgs e)
		{
			string query = "select mp.idNota as Id_Reservacion, mp.nombreCliente as Nombre_Cliente, mp.telefonoCliente as Celular," +
				" mp.idProducto, mp.cantidad as Cantidad,mp.producto as Producto,mp.descripcion as Descrpcion,f.ubicacion as Ubicacion," +
				"r.descripcionUbicacion as Descripcion_ubicacion from materialPendiente as mp inner join Reserva as r on mp.idNota = r.idReserva inner join Flete as f " +
				"on r.idFlete = f.idFlete where mp.estatus=1 and mp.nombreCliente like '%"+txtBuscadorCliente.Text+"%'";
			gvDeudas.DataSource = bdd.llenarVistas(query);
		}

		private void gvDeudas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string idActual = gvDeudas.Rows[e.RowIndex].Cells[0].Value.ToString();
			DialogResult yus = MessageBox.Show("Dar por devuelto el material al negocio" +
						   " \nNo existe manera de revertir esta accion una vez cargada", "Atencion", MessageBoxButtons.YesNo);
			if (yus == DialogResult.Yes)
			{
				//string idActual = gvDeudas.Rows[].Cells[0].Value.ToString();
				string query = "update materialPendiente set estatus=0 where idNota=" + idActual;
				bdd.ejecutar(query);
				string query2 = "select mp.idNota as Id_Reservacion, mp.nombreCliente as Nombre_Cliente, mp.telefonoCliente as Celular," +
				" mp.idProducto, mp.cantidad as Cantidad,mp.producto as Producto,mp.descripcion as Descrpcion,f.ubicacion as Ubicacion," +
				"r.descripcionUbicacion as Descripcion_Ubicacion from materialPendiente as mp inner join Reserva as r on mp.idNota = r.idReserva inner join Flete as f " +
				"on r.idFlete = f.idFlete where mp.estatus=1";
				gvDeudas.DataSource = bdd.llenarVistas(query2);
			}
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			if (pantalla)
			{
				registroFaltante r = new registroFaltante();
				r.Show();
				this.Close();
			}
			else {
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
}
