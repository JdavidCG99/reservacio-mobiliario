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
    public partial class Productos : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();
        public Productos()
        {
            InitializeComponent();
            conexion.select(cbCategorias);

            string query = "select idProductos AS 'ID', nombre AS 'Producto', descripcion AS 'Descripcion', precioVenta AS 'Precio', stock AS 'Stock' from Productos where estatus = 1";
            conexion.grid(gvProd, query);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            agregarProductos agregarProductos = new agregarProductos();
            agregarProductos.Show();
            this.Close();
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscadorProducto.Text = "";
            string query = "select Productos.idProductos AS 'ID', Productos.nombre AS 'Producto', Productos.descripcion AS 'Descripcion', Productos.precioVenta AS 'Precio', Productos.stock AS 'Stock' from Productos " +
                "inner join Categorias on Categorias.idCategoria = Productos.idCategoria " +
                "where Categorias.nombre = '" + cbCategorias.Text + "' and estatus = 1";
            conexion.grid(gvProd, query);
        }

        private void txtBuscadorProducto_TextChanged(object sender, EventArgs e)
        {
            string query = "select idProductos AS 'ID', nombre AS 'Producto', descripcion AS 'Descripcion', precioVenta AS 'Precio', stock AS 'Stock' from Productos  " +
               "where estatus = 1 and nombre like '%" + txtBuscadorProducto.Text + "%'";
            conexion.grid(gvProd, query);
        }

        private void txtBuscadorProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letrasNumeros(e);
        }

        private void txtBuscadorProducto_Enter(object sender, EventArgs e)
        {
            cbCategorias.Text = "Categorias";
            string query = "select idProductos AS 'ID', nombre AS 'Producto', descripcion AS 'Descripcion', precioVenta AS 'Precio', stock AS 'Stock' from Productos where estatus = 1";
            conexion.grid(gvProd, query);
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.RoyalBlue;
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
            if(Program.NombreUsuario == "admin")
            {
                menu.toolStripMenuItem2.Visible = true;
            }
            menu.Show();
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.White;
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void gvProd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActiveForm.Hide();
            actualizacionProductos actualizacionProductos = new actualizacionProductos();
            actualizacionProductos.Show();

            actualizacionProductos.txtID.Text = this.gvProd.CurrentRow.Cells[0].Value.ToString();
            actualizacionProductos.txtProducto.Text = this.gvProd.CurrentRow.Cells[1].Value.ToString();
            actualizacionProductos.txtDescripcion.Text = this.gvProd.CurrentRow.Cells[2].Value.ToString();
            actualizacionProductos.txtStock.Text = this.gvProd.CurrentRow.Cells[4].Value.ToString();
            actualizacionProductos.txtPrecioVenta.Text = this.gvProd.CurrentRow.Cells[3].Value.ToString();

            String[] categoria = new string[1];
            String query = "Select Categorias.nombre AS 'dato' from Categorias inner join Productos on Categorias.idCategoria = Productos.idCategoria where Productos.idProductos = " + this.gvProd.CurrentRow.Cells[0].Value;
            categoria = conexion.dato(query);

            actualizacionProductos.cbCategorias.Text = Convert.ToString(categoria[0]);
        }
    }
}
