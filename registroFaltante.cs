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
	public partial class registroFaltante : Form
	{
		Validaciones v = new Validaciones();
		Conexion conexion = new Conexion();
		Conexion2 conexion2 = new Conexion2();

		public registroFaltante()
		{
			InitializeComponent();
		}

		private void registroFaltante_Load(object sender, EventArgs e)
		{

		}

		private void btnAgg_Click(object sender, EventArgs e)
		{
			if (tbId.TextLength >0 && tbCliente.TextLength>0 && tbCelular.TextLength>0 &&
				tbIdProducto.TextLength>0 && tbProducto.TextLength>0 && tbCantidad.TextLength>0)
			{
				string query = "insert into materialPendiente values('"+tbId.Text+"','"+tbCliente.Text+"','" +tbCelular.Text 
					+ "','" + tbIdProducto.Text + "','"+tbProducto.Text+"','"+tbDescripcion.Text+"','"
					+tbCantidad.Text+"','"+ DateTime.Now.ToShortDateString()+"',1)";
				conexion.ejecutar(query);
				MessageBox.Show("Producto agregado exitosamente a pendientes", "Atencion");
				tbId.Text = "";
				tbCliente.Text = "";
				tbCelular.Text = "";
				tbIdProducto.Text = "";
				tbProducto.Text = "";
				tbDescripcion.Text = "";
				tbCantidad.Text = "";
			}
			else
			{
				MessageBox.Show("Verifique el llenado de los datos.", "Atencion");
			}
		}

		private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.numerosEnteros(e);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if (tbFolio.TextLength > 0)
			{
				string query = "select dr.idProductos as Id_producto, dr.cantidad as Cantidad, p.nombre as Nombre, " +
				"p.descripcion as Descripcion ,p.precioVenta as Precio from Reserva as r inner join Detalle_Reserva as dr " +
				"on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos " +
				"where r.idReserva = " + tbFolio.Text;
				DataTable d;
				d = conexion.llenarVistas(query);

				if (d.Rows.Count > 0)
				{
					tbId.Text = tbFolio.Text;
					tbCliente.Text = conexion2.getUnDato("select nombre from Reserva where idReserva=" + tbFolio.Text);
					string[] info = conexion2.telefono("select telefono from Reserva where idReserva=" + tbFolio.Text);
					tbCelular.Text = info[0];
					gvProductos.DataSource = d;
				}
				else
				{
					MessageBox.Show("No existe ninguna reservacion con esa id", "Atencion");
				}
			}
			else{
				MessageBox.Show("No existe ninguna reservacion con esa id", "Atencion");
			}
			
		}

		private void gvProductos_Click(object sender, EventArgs e)
		{

		}

		private void gvProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			tbIdProducto.Text = this.gvProductos.CurrentRow.Cells[0].Value.ToString();
			tbProducto.Text = this.gvProductos.CurrentRow.Cells[2].Value.ToString();
			tbDescripcion.Text = this.gvProductos.CurrentRow.Cells[3].Value.ToString();
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

		private void button1_Click(object sender, EventArgs e)
		{
			ProductosFaltantes p = new ProductosFaltantes(true);
			p.Show();
			this.Close();
		}
	}
}
