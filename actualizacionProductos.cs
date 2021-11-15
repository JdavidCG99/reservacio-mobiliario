using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Reservaciones
{
    public partial class actualizacionProductos : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();
        public actualizacionProductos()
        {
            InitializeComponent();
            conexion.select(cbCategorias);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Si decide salir los cambios no seran guardados!", "Regresar", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Productos catalogoProductos = new Productos();
                catalogoProductos.Show();
                this.Close();
            }
        }

        private void ntmGuardar_Click(object sender, EventArgs e)
        {
            String[] idCategoria = new string[1];
            String query;
            query = "Select idCategoria AS 'dato' From Categorias Where nombre = '" + cbCategorias.Text + "'";
            idCategoria = conexion.dato(query);

            query = "Update Productos set idCategoria = "+ Convert.ToInt32(idCategoria[0]) +", nombre = '" + txtProducto.Text + "', descripcion = '" + txtDescripcion.Text + "', stock =" + Convert.ToInt64(txtStock.Text) + ", precioVenta =" + txtPrecioVenta.Text + " Where idProductos = " + Convert.ToInt64(txtID.Text);
            conexion.Alta_baja_cambio(query);

            MessageBox.Show("Producto Actualizado Exitosamente!", "Guardar");

            Productos catalogoProductos = new Productos();
            catalogoProductos.Show();
            this.Close();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letrasNumeros(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimales(sender, e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.numerosEnteros(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese eliminar este producto?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                String query;
                query = "Update Productos set estatus = 0 Where idProductos = " + Convert.ToInt64(txtID.Text);
                conexion.Alta_baja_cambio(query);

                MessageBox.Show("Producto Eliminado Exitosamente", "Eliminar");

                Productos catalogProductos = new Productos();
                catalogProductos.Show();
                this.Close();
            }
        }

        private void actualizacionProductos_Load(object sender, EventArgs e)
        {

        }

        private void ntmGuardar_MouseHover(object sender, EventArgs e)
        {
            ntmGuardar.BackColor = Color.LightGreen;
        }

        private void ntmGuardar_MouseLeave(object sender, EventArgs e)
        {
            ntmGuardar.BackColor = Color.White;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.Orange;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.White;
        }

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }
    }
}
