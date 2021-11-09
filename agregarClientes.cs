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
    public partial class agregarClientes : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();
		Boolean reserva = false;
        public agregarClientes()
        {
            InitializeComponent();

            String[] idCliente = new string[1];
            String query;
            query = "Select Max(idCliente) As 'dato' From Cliente ";
            idCliente = conexion.dato(query);
            int nextID;
            if (idCliente[0] != "")
            {
                nextID = Convert.ToInt32(idCliente[0]) + 1;
            }
            else {
                nextID = 1;
            }
            

            txtID.Text = Convert.ToString(nextID);
        }
		public agregarClientes(Boolean origen)
		{
			InitializeComponent();

			String[] idCliente = new string[1];
			String query;
			query = "Select Max(idCliente) As 'dato' From Cliente ";
			idCliente = conexion.dato(query);
			int nextID;
			if (idCliente[0] != "")
			{
				nextID = Convert.ToInt32(idCliente[0]) + 1;
			}
			else
			{
				nextID = 1;
			}


			txtID.Text = Convert.ToString(nextID);

			this.reserva = origen;
		}

		private void ntmGuardar_Click(object sender, EventArgs e)
        {
			if (txtNombre.Text == "" | txtPaterno.Text == "")
			{
				MessageBox.Show("Favor de llenar todos los campos correctamente", "Aviso");
			}
			else
			{
				String query = "Insert into Cliente (nombre, apellidoP, apellidoM, direcion, telefono, estatus) values ('" + txtNombre.Text + "', '" + txtPaterno.Text + "','" + txtMaterno.Text + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', 1)";
				conexion.Alta_baja_cambio(query);

				MessageBox.Show("Cliente Capturado Exitosamente!", "Guardar");

				//ActiveForm.Close();
				if (!reserva)
				{
					catalogoClientes catalogoClientes = new catalogoClientes();
					catalogoClientes.Show();
					this.Close();
				}
				else
				{
					ElegirCliente y = new ElegirCliente();
					y.Show();
					this.Close();
				}
               
            }
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

        private void agregarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
