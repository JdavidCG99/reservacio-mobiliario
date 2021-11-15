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
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
        }
        Validaciones val = new Validaciones();
        Conexion2 con = new Conexion2();
        private void gastos_Load(object sender, EventArgs e)
        {
            cbDescripcion.SelectedIndex = 0;
            dtFecha.Value= DateTime.Now;
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtImporte.TextLength > 0)
            {
                string query = "insert into gastos values("+txtImporte.Text+",'"+cbDescripcion.Text+"','"+dtFecha.Text+"','"+textBox1.Text+"')";
                con.ejecutar(query);
                MessageBox.Show("Salida de dinero guardada con exito","Atencion");
                txtImporte.Text = "0";
                cbDescripcion.SelectedIndex = 0;
				textBox1.Text = "";
            }
            else {
                MessageBox.Show("Error al guardar","Atencion");
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numerosEnteros(e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que desea salir"
            , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes)
            {
                menu_inicio menu = new menu_inicio();
                if (Program.NombreUsuario == "admin")
                {
                    menu.toolStripMenuItem2.Visible = true;
                }
                menu.Show();
                this.Close();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGreen;
        }

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }
    }
}
