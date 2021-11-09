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
	public partial class DineroRetenido : Form
	{
		public DineroRetenido()
		{
			InitializeComponent();
		}
		private void DineroRetenido_Load(object sender, EventArgs e)
		{
			string query = "select id as Id, nombre as Nombre_Cliente, descripcion as Descripcion ,cantidad as Cantidad,fechaEntrada as Fecha_entrada from dineroRetenido where estatus=1";
			gvDeudas.DataSource = bdd.llenarVistas(query);
		}

		Conexion bdd = new Conexion();
		Validaciones v = new Validaciones();
		private void btnAgg_Click(object sender, EventArgs e)
		{
			if(tbNombre.Text.Length>0 && tbCantidad.Text.Length > 0) {
				string query = "insert into dineroRetenido values('" + tbNombre.Text + "','" + tbCantidad.Text + "','" + DateTime.Now.ToShortDateString() + "',1,null,'"+tbDescripcion.Text+"')";
				bdd.ejecutar(query);
				string query2 = "select id as Id, nombre as Nombre_Cliente,  descripcion as Descripcion  ,cantidad as Cantidad,fechaEntrada as Fecha_entrada from dineroRetenido where estatus=1";
				gvDeudas.DataSource = bdd.llenarVistas(query2);
				tbNombre.Text = "";
				tbCantidad.Text = "";
				tbDescripcion.Text = "";
			}
			else
			{
				MessageBox.Show("Falta el nombre o la cantidad","Atencion");
			}
			
		}
		private void gvDeudas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string idActual = gvDeudas.Rows[e.RowIndex].Cells[0].Value.ToString();
			DialogResult yus = MessageBox.Show("Dar por devuelto el dinero al cliente" +
						   " \nNo existe manera de revertir esta accion una vez cargada", "Atencion", MessageBoxButtons.YesNo);
			if (yus == DialogResult.Yes){
				//string idActual = gvDeudas.Rows[].Cells[0].Value.ToString();
				string query = "update dineroRetenido set estatus=0 , fecha_salida='" + DateTime.Now.ToShortDateString() + "' where id="+idActual;
				bdd.ejecutar(query);
				string query2 = "select id as Id, nombre as Nombre_Cliente, descripcion as Descripcion ,cantidad as Cantidad,fechaEntrada as Fecha_entrada from dineroRetenido where estatus=1";
				gvDeudas.DataSource = bdd.llenarVistas(query2);
			}
		}
		private void txtBuscadorCliente_TextChanged(object sender, EventArgs e)
		{
			string query2 = "select id as Id, nombre as Nombre_Cliente, descripcion as Descripcion ,cantidad as Cantidad,fechaEntrada as Fecha_entrada from dineroRetenido " +
				"where estatus=1 and nombre like '%"+txtBuscadorCliente.Text+"%'";
			gvDeudas.DataSource = bdd.llenarVistas(query2);
		}
		private void gvDeudas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void btnSalida_Click(object sender, EventArgs e)
		{
			
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

		private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.letras(e);
		}

		private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.numerosEnteros(e);
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

	
	}
}
