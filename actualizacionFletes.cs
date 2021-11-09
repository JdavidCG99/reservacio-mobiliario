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
    public partial class actualizacionFletes : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();

        public actualizacionFletes()
        {
            InitializeComponent();
        }

        private void ntmGuardar_Click(object sender, EventArgs e)
        {
            String query;
            
            query = "Update Flete set ubicacion = '" + txtLocalidad.Text + "', precio = '" + txtPrecio.Text + "' Where idFlete = " + Convert.ToInt64(txtID.Text);
            conexion.Alta_baja_cambio(query);

            MessageBox.Show("Flete Actualizado Exitosamente!", "Guardar");

            //ActiveForm.Close();

            catalogoFletes catalogoFletes = new catalogoFletes();
            catalogoFletes.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Si decide salir los cambios no seran guardados!", "Regresar", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                //ActiveForm.Close();

                catalogoFletes catalogoFletes = new catalogoFletes();
                catalogoFletes.Show();
                this.Close();
            }
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letrasNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
