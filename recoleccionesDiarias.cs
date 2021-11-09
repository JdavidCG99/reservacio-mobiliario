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
    public partial class recoleccionesDiarias : Form
    {
        Conexion bdd = new Conexion();
        public recoleccionesDiarias()
        {
            InitializeComponent();
        }

        private void recoleccionesDiarias_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
			dtpos.Text = DateTime.Now.ToLongDateString();
			string query = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida,"+
				" r.nombre as Nombre_Cliente,f.ubicacion,dr.idProductos,dr.cantidad,p.nombre,r.volvio as Regreso from Reserva as r inner join Flete as f on r.idFlete = f.idFlete inner join "+
				"Detalle_Reserva as dr on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos "+
				"where r.estatus = 1 and fechaRegreso ='" + DateTime.Now.ToShortDateString() + "'";
            gvReservaciones.DataSource = bdd.llenarVistas(query);
        }

        private void dtDia_ValueChanged(object sender, EventArgs e)
        {
			string query = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
				" r.nombre as Nombre_Cliente,f.ubicacion,dr.idProductos,dr.cantidad,p.nombre,r.volvio as Regreso from Reserva as r inner join Flete as f on r.idFlete = f.idFlete inner join " +
				"Detalle_Reserva as dr on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos " +
				"where r.estatus = 1 and fechaRegreso ='" + dtDia.Text + "'";
			//string query = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
			//	"r.nombre as Nombre_Cliente,f.ubicacion,r.volvio as Regreso  from Reserva as r inner join Flete as f on r.idFlete=f.idFlete " +
   //             "where estatus=1 and fechaRegreso='" + dtDia.Text + "'";
            gvReservaciones.DataSource = bdd.llenarVistas(query);
        }

        private void gvReservaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idActual = gvReservaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            
            verInfoReserva vir = new verInfoReserva(idActual,1);
            vir.Show();
            this.Close();
        }

        private void btnVerHoy_Click_1(object sender, EventArgs e)
        {
			string query = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
				 " r.nombre as Nombre_Cliente,f.ubicacion,dr.idProductos,dr.cantidad,p.nombre,r.volvio as Regreso from Reserva as r inner join Flete as f on r.idFlete = f.idFlete inner join " +
				 "Detalle_Reserva as dr on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos " +
				 "where r.estatus = 1 and fechaRegreso ='" + DateTime.Now.ToShortDateString() + "'";
			gvReservaciones.DataSource = bdd.llenarVistas(query);
        }
		private void btnPosponer_Click(object sender, EventArgs e)
		{
			string resrevacion = gvReservaciones.Rows[gvReservaciones.CurrentRow.Index].Cells[0].Value.ToString();
			DialogResult yus = MessageBox.Show("Segura que quieres posponer esta reservacion"
			   , "Atencion", MessageBoxButtons.YesNo);
			if (yus == DialogResult.Yes) {
				//MessageBox.Show(resrevacion,"Atencion");
				string query = "update Reserva set fechaRegreso = '"+dtpos.Text+"' where idReserva="+resrevacion;
				bdd.ejecutar(query);
				string query2 = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
					" r.nombre as Nombre_Cliente,f.ubicacion,dr.idProductos,dr.cantidad,p.nombre,r.volvio as Regreso from Reserva as r inner join Flete as f on r.idFlete = f.idFlete inner join " +
					"Detalle_Reserva as dr on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos " +
					"where r.estatus = 1 and fechaRegreso ='" + DateTime.Now.ToShortDateString() + "'";
				gvReservaciones.DataSource = bdd.llenarVistas(query2);

			}
			//btnPosponer.Enabled = false;

		}
		private void btnSalida_Click(object sender, EventArgs e)
		{
			string resrevacion = gvReservaciones.Rows[gvReservaciones.CurrentRow.Index].Cells[0].Value.ToString();
			DialogResult yus = MessageBox.Show("La reservacion ya volvio"
			   , "Atencion", MessageBoxButtons.YesNo);
			if (yus == DialogResult.Yes)
			{
				//MessageBox.Show(resrevacion,"Atencion");
				//DateTime fn = DateTime.Now.Date - 1;
				string query = "update Reserva set volvio = 'Si' , fechaRegreso='"+ DateTime.Now.AddDays(-1).ToShortDateString() + "' where idReserva=" + resrevacion;
				bdd.ejecutar(query);
				string query2 = "select r.idReserva as id, r.fechaReserva as Fecha_Reservacion,r.fechaSalida as Fecha_salida," +
				 " r.nombre as Nombre_Cliente,f.ubicacion,dr.idProductos,dr.cantidad,p.nombre,r.volvio as Regreso from Reserva as r inner join Flete as f on r.idFlete = f.idFlete inner join " +
				 "Detalle_Reserva as dr on r.idReserva = dr.idReserva inner join Productos as p on dr.idProductos = p.idProductos " +
				 "where r.estatus = 1 and fechaRegreso ='" + DateTime.Now.ToShortDateString() + "'";
				gvReservaciones.DataSource = bdd.llenarVistas(query2);
			}
		}
		private void groupBox3_Enter(object sender, EventArgs e)
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


        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            //this.Close();
            menu_inicio menu = new menu_inicio();
            if (Program.NombreUsuario == "admin")
            {
                menu.toolStripMenuItem2.Visible = true;
            }
            menu.Show();
            this.Close();
        }

		private void dtpos_ValueChanged(object sender, EventArgs e)
		{
			//btnPosponer.Enabled = true;
		}

		
	}
}
