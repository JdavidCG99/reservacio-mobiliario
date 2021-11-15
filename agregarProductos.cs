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
    public partial class agregarProductos : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();

        public agregarProductos()
        {
            InitializeComponent();
            String[] idProducto = new string[1];
            String query;
            query = "Select Max(idProductos) As 'dato' From Productos ";
            idProducto = conexion.dato(query);
            int nextID;
            if (idProducto[0] != "")
            {
                nextID = Convert.ToInt32(idProducto[0]) + 1;
            }
            else {
                nextID = 1;
            }
            

            txtID.Text = Convert.ToString(nextID);

            conexion.select(cbCategorias);

        }

        private void ntmGuardar_Click(object sender, EventArgs e)
        {
            String[] idCategoria = new string[1];
            String query;
            query = "Select idCategoria AS 'dato' From Categorias Where nombre = '" + cbCategorias.Text+"'";
            idCategoria = conexion.dato(query);
            
            if(txtProducto.Text == "" | txtDescripcion.Text == "" | txtStock.Text == "" | txtPrecioVenta.Text == "" | cbCategorias.Text == "Categorias")
            {
                MessageBox.Show("Favor de llenar todos los campos correctamente", "Aviso");
            }
            else { 
                query = "Insert into Productos (idCategoria, nombre, descripcion, precioVenta, stock, estatus) values ("+Convert.ToInt32(idCategoria[0]) +", '"+txtProducto.Text+"', '"+txtDescripcion.Text+"',"+txtPrecioVenta.Text+", "+Convert.ToInt32(txtStock.Text)+", 1)";
                conexion.Alta_baja_cambio(query);

                MessageBox.Show("Producto Capturado Exitosamente!", "Guardar");

                Productos catalogoProductos = new Productos();
                catalogoProductos.Show();
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Si decide salir los cambios no seran guardados!", "Regresar", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK) { 

                Productos catalogoProductos = new Productos();
                catalogoProductos.Show();
                this.Close();
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letrasNumeros(e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.numerosEnteros(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ntmGuardar_MouseHover(object sender, EventArgs e)
        {
            ntmGuardar.BackColor = Color.LightGreen;
        }

        private void ntmGuardar_MouseLeave(object sender, EventArgs e)
        {
            ntmGuardar.BackColor = Color.White;
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
