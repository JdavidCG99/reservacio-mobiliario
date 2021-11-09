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
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();
        public Form1()
        {
            InitializeComponent();
            conexion.select(cbCategorias);

            string query = "select idProductos, nombre, descripcion, precioVenta, stock, reserva from Productos ";
            conexion.grid(gvProductos, query);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string query;
            query = "INSERT INTO Categorias(nombre, descripcion) VALUES ('" + txtBuscadorProducto.Text + "', 'Gran variedad de cristaleria para decoracion de festejos.'" + ")";
            conexion.Alta_baja_cambio(query);
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select Productos.idProductos, Productos.nombre, Productos.descripcion, Productos.precioVenta, Productos.stock, Productos.reserva from Productos " +
                "inner join Categorias on Categorias.idCategoria = Productos.idCategoria " +
                "where Categorias.nombre = '" + cbCategorias.Text + "'";
            conexion.grid(gvProductos, query);
        }

        private void txtBuscadorProducto_TextChanged(object sender, EventArgs e)
        {
            string query = "select idProductos, nombre, descripcion, precioVenta, stock, reserva from Productos  " +
               "where nombre like '" + txtBuscadorProducto.Text + "%'";
            conexion.grid(gvProductos, query);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
