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
    public partial class catalogoClientes : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();
		
        public catalogoClientes()
        {
            InitializeComponent();

            string query = "select idCliente as 'ID' , nombre as 'Nombre', apellidoP as 'Apellido-Paterno', apellidoM as 'Apellido-Materno', direcion as 'Direccion', telefono as 'Telefono' from Cliente where estatus = 1";
            conexion.grid(gvClientes, query);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            //this.Close();
            agregarClientes agregarClientes = new agregarClientes();
            agregarClientes.Show();
            this.Close();
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
            ActiveForm.Hide();
            //this.Close();
            actualizacionClientes actualizacionClientes = new actualizacionClientes();
            actualizacionClientes.Show();

            actualizacionClientes.txtID.Text = this.gvClientes.CurrentRow.Cells[0].Value.ToString();
            actualizacionClientes.txtNombre.Text = this.gvClientes.CurrentRow.Cells[1].Value.ToString();
            actualizacionClientes.txtPaterno.Text = this.gvClientes.CurrentRow.Cells[2].Value.ToString();
            actualizacionClientes.txtMaterno.Text = this.gvClientes.CurrentRow.Cells[3].Value.ToString();
            actualizacionClientes.txtDireccion.Text = this.gvClientes.CurrentRow.Cells[4].Value.ToString();
            actualizacionClientes.txtTelefono.Text = this.gvClientes.CurrentRow.Cells[5].Value.ToString();
        }

		private void catalogoClientes_Load(object sender, EventArgs e)
		{

		}
	}
}
