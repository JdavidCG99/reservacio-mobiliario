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
    public partial class entegasDiarias : Form
    {
        Conexion bdd = new Conexion();

        public entegasDiarias()
        {
            InitializeComponent();
        }

        private void entegasDiarias_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            string query = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
                "r.nombre as Nombre_Cliente,f.ubicacion,r.salio as Salio from Reserva as r inner join Flete as f on r.idFlete=f.idFlete " +
                "where estatus=1 and fechaSalida='" + DateTime.Now.ToShortDateString() + "'";
            gvReservaciones.DataSource = bdd.llenarVistas(query);
        }

        private void btnVerHoy_Click(object sender, EventArgs e)
        {
            string query = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
				"r.nombre as Nombre_Cliente,f.ubicacion,r.salio as Salio from Reserva as r inner join Flete as f on r.idFlete=f.idFlete " +
                "where estatus=1 and fechaSalida='"+ DateTime.Now.ToShortDateString() + "'";
            gvReservaciones.DataSource = bdd.llenarVistas(query);
        }

        private void dtDia_ValueChanged(object sender, EventArgs e)
        {
            string query = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
				"r.nombre as Nombre_Cliente,f.ubicacion,r.salio as Salio  from Reserva as r inner join Flete as f on r.idFlete=f.idFlete " +
                "where estatus=1 and fechaSalida='" + dtDia.Text + "'";
            gvReservaciones.DataSource = bdd.llenarVistas(query);
        }

        private void gvReservaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idActual = gvReservaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            verInfoReserva vir = new verInfoReserva(idActual,2);
            vir.Show();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerHoy_MouseHover(object sender, EventArgs e)
        {
            btnVerHoy.BackColor = Color.LightGreen;
        }

        private void btnVerHoy_MouseLeave(object sender, EventArgs e)
        {
            btnVerHoy.BackColor = Color.White;
        }

        private void btnVerHoy_MouseClick(object sender, MouseEventArgs e)
        {
            btnVerHoy.BackColor = Color.RoyalBlue;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menu_inicio menu = new menu_inicio();
            if (Program.NombreUsuario == "admin")
            {
                menu.toolStripMenuItem2.Visible = true;
            }
            menu.Show();
            this.Close();
        }

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }

		private void btnSalida_Click(object sender, EventArgs e)
		{
			string resrevacion = gvReservaciones.Rows[gvReservaciones.CurrentRow.Index].Cells[0].Value.ToString();
			DialogResult yus = MessageBox.Show("Marcar como salida la reservacion"
			   , "Atencion", MessageBoxButtons.YesNo);
			if (yus == DialogResult.Yes)
			{
				string query = "update Reserva set salio = 'Si' where idReserva=" + resrevacion;
				bdd.ejecutar(query);
				string query2 = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
			   "r.nombre as Nombre_Cliente,f.ubicacion,r.salio as Salio from Reserva as r inner join Flete as f on r.idFlete=f.idFlete " +
			   "where estatus=1 and fechaRegreso='" + DateTime.Now.ToShortDateString() + "'";
				gvReservaciones.DataSource = bdd.llenarVistas(query2);
			}
		}
	}
}
