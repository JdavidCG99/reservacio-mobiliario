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
    public partial class catalogoFletes : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();
        public catalogoFletes()
        {
            InitializeComponent();

            string query = "select idFlete, ubicacion, precio from Flete";
            conexion.grid(gvFlete, query);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            agregarFletes agregarFletes = new agregarFletes();
            agregarFletes.Show();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string query = "select idFlete, ubicacion, precio from Flete  " +
               "where ubicacion like '%" + txtBuscador.Text + "%'";
            conexion.grid(gvFlete, query);
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.letrasNumeros(e);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            menu_inicio yus = new menu_inicio();
            if (Program.NombreUsuario == "admin")
            {
                yus.toolStripMenuItem2.Visible = true;
            }
            yus.Show();
            this.Close();
        }

        private void gvFlete_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ActiveForm.Hide();
            actualizacionFletes actualizacionFletes = new actualizacionFletes();
            actualizacionFletes.Show();

            actualizacionFletes.txtID.Text = this.gvFlete.CurrentRow.Cells[0].Value.ToString();
            actualizacionFletes.txtLocalidad.Text = this.gvFlete.CurrentRow.Cells[1].Value.ToString();
            actualizacionFletes.txtPrecio.Text = this.gvFlete.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAgregar_MouseHover(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.RoyalBlue;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackColor = Color.White;
        }

        private void btnsalir_MouseHover(object sender, EventArgs e)
        {
            btnsalir.BackColor = Color.Tomato;
        }

        private void btnsalir_MouseLeave(object sender, EventArgs e)
        {
            btnsalir.BackColor = Color.White;
        }
    }
}
