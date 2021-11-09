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
    public partial class actualizacionClientes : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();

        public actualizacionClientes()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Si decide salir los cambios no seran guardados!", "Regresar", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                //ActiveForm.Close();

                catalogoClientes catalogoClientes = new catalogoClientes();
                catalogoClientes.Show();
                this.Close();
            }
        }

        private void ntmGuardar_Click(object sender, EventArgs e)
        {
            String query;

            query = "Update Cliente set nombre = '" + txtNombre.Text + "', apellidoP = '" + txtPaterno.Text + "', apellidoM = '" + txtMaterno.Text + "', direcion ='" + txtDireccion.Text + "', telefono ='" + txtTelefono.Text + "' Where idCliente = " + Convert.ToInt64(txtID.Text);
            conexion.Alta_baja_cambio(query);

            MessageBox.Show("Cliente Actualizado Exitosamente!", "Guardar");

            //ActiveForm.Close();

            catalogoClientes catalogoClientes = new catalogoClientes();
            catalogoClientes.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                String query;
                query = "Update Cliente set estatus = 0 Where idCliente = " + Convert.ToInt64(txtID.Text);
                conexion.Alta_baja_cambio(query);

                MessageBox.Show("Cliente Eliminado Exitosamente", "Eliminar");

                //ActiveForm.Close();
                catalogoClientes catalogoClientes = new catalogoClientes();
                catalogoClientes.Show();
                this.Close();
            }
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letras(e);
        }

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letras(e);
        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.numerosEnteros(e);
        }

        private void actualizacionClientes_Load(object sender, EventArgs e)
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
