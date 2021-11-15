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
	public partial class ElegirCliente : Form
	{
		public ElegirCliente()
		{
			InitializeComponent();
		}
		Conexion conexion = new Conexion();
		Validaciones validaciones = new Validaciones();


		private void ElegirCliente_Load(object sender, EventArgs e)
		{
			string query = "select idCliente as 'ID' , nombre as 'Nombre', apellidoP as 'Apellido-Paterno', apellidoM as 'Apellido-Materno', direcion as 'Direccion', telefono as 'Telefono' from Cliente where estatus = 1";
			conexion.grid(gvClientes, query);
			tbId.Text = this.gvClientes.CurrentRow.Cells[0].Value.ToString();
			tbNombre.Text = this.gvClientes.CurrentRow.Cells[1].Value.ToString() + " " +
			this.gvClientes.CurrentRow.Cells[2].Value.ToString() + " " +
			this.gvClientes.CurrentRow.Cells[3].Value.ToString();
		}

		private void txtBuscadorCliente_TextChanged(object sender, EventArgs e)
		{
			string query = "select idCliente AS 'ID', nombre as 'Nombre', apellidoP as 'Apellido-Paterno', apellidoM as 'Apellido-Materno', direcion as 'Direccion', telefono as 'Telefono' from Cliente  " +
			  "where estatus = 1 and nombre like '%" + txtBuscadorCliente.Text + "%'";
			conexion.grid(gvClientes, query);
		}

		private void txtBuscadorCliente_KeyPress(object sender, KeyPressEventArgs e)
		{

			validaciones.letras(e);
		}

		private void btnAgregar_MouseHover(object sender, EventArgs e)
		{
			btnAgregar.BackColor = Color.RoyalBlue;
		}

		private void btnAgregar_MouseLeave(object sender, EventArgs e)
		{
			btnAgregar.BackColor = Color.White;
		}

		private void btnRegresar_MouseHover(object sender, EventArgs e)
		{
			btnRegresar.BackColor = Color.Tomato;
		}

		private void btnRegresar_MouseLeave(object sender, EventArgs e)
		{
			btnRegresar.BackColor = Color.White;
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

		private void gvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void gvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void gvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			tbId.Text = this.gvClientes.CurrentRow.Cells[0].Value.ToString();
			tbNombre.Text = this.gvClientes.CurrentRow.Cells[1].Value.ToString() + " " +
			this.gvClientes.CurrentRow.Cells[2].Value.ToString() + " " +
			this.gvClientes.CurrentRow.Cells[3].Value.ToString();
		}

		private void btnReserva_Click(object sender, EventArgs e)
		{
			reservacion y = new reservacion(tbId.Text,tbNombre.Text);
			y.Show();
			this.Hide();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			agregarClientes y = new agregarClientes(true);
			y.Show();
			this.Hide();
		}
	}
}
