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
    public partial class agregarFletes : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();

        public agregarFletes()
        {
            InitializeComponent();

            String[] idFlete = new string[1];
            String query;
            query = "Select Max(idFlete) As 'dato' From Flete ";
            idFlete = conexion.dato(query);
            int nextID;

            if (idFlete[0] != "")
            {
                nextID = Convert.ToInt32(idFlete[0]) + 1;
            }
            else
            {
                nextID = 1;
            }
            txtID.Text = Convert.ToString(nextID);
           
        }

        private void ntmGuardar_Click(object sender, EventArgs e)
        {

            if (txtLocalidad.Text == "" | txtPrecio.Text == "" )
            {
                MessageBox.Show("Favor de llenar todos los campos correctamente", "Aviso");
            }
            else
            {
                String query = "Insert into Flete (ubicacion, precio) values ('" +txtLocalidad.Text+ "', '" + txtPrecio.Text + "')";
                conexion.Alta_baja_cambio(query);

                MessageBox.Show("Flete Capturado Exitosamente!", "Guardar");

                catalogoFletes catalogoFletes = new catalogoFletes();
                catalogoFletes.Show();
                this.Close();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Si decide salir los cambios no seran guardados!", "Regresar", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
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

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }

        private void ntmGuardar_MouseHover(object sender, EventArgs e)
        {
            ntmGuardar.BackColor = Color.LightGreen;
        }

        private void ntmGuardar_MouseLeave(object sender, EventArgs e)
        {
            ntmGuardar.BackColor = Color.White;
        }

        private void agregarFletes_Load(object sender, EventArgs e)
        {

        }
    }
}
