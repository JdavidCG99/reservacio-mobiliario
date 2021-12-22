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
    public partial class verReservaciones : Form
    {
        Conexion conexion = new Conexion();
		Conexion2 conexion2 = new Conexion2();
		Validaciones validar = new Validaciones();

        public verReservaciones()
        {
            InitializeComponent();
        }
        private void verReservaciones_Load(object sender, EventArgs e)
        {
			dtFechaEntrega.Value = DateTime.Now;
			dtFechaRegreso.Value = DateTime.Now;
			string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
                " fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
                "telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
                "where estatus = 1";
            gvReservaciones.DataSource = conexion.llenarVistas(query);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
			if (tbFolio.TextLength > 0)
			{
				string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
			   " fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
			   "telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
			   "where estatus = 1 and idReserva=" + tbFolio.Text;
				DataTable d;
				d = conexion.llenarVistas(query);
				if (d.Rows.Count > 0)
				{
					gvReservaciones.DataSource = d;
				}
				else
				{
					MessageBox.Show("No existe ninguna reservacion con esa id", "Atencion");
				}
			}
			else {
				MessageBox.Show("No existe ninguna reservacion con esa id", "Atencion");
			}

           
        }
        private void tbFolio_TextChanged(object sender, EventArgs e)
        {
            if (tbFolio.TextLength == 0)
            {
                string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
                " fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
                "telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
                "where estatus = 1";
                gvReservaciones.DataSource = conexion.llenarVistas(query);
				tbTotalDeuda.Text = "";
			}
        }

        private void tbBuscarCleinte_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscarCleinte.TextLength==0) {
                string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
                " fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
                "telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
                "where estatus = 1";
                gvReservaciones.DataSource = conexion.llenarVistas(query);
				tbTotalDeuda.Text = "";
			}
            else {
                string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
                " fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
                "telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
                "where nombre like '%"+tbBuscarCleinte.Text+ "%' and estatus = 1";
                gvReservaciones.DataSource = conexion.llenarVistas(query);
				tbTotalDeuda.Text = "";
			}
        }

        private void gvReservaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idActual = gvReservaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            mostarInfoReserva(idActual);
        }
        private void mostarInfoReserva(string idActual) {
            string query = "select d.idProductos as Id,p.nombre as Nombre,p.descripcion as Descripcion," +
                "d.cantidad as Cantidad,p.precioVenta as Precio, d.total as Total from Detalle_Reserva as d " +
                "inner join Productos as p on d.idProductos=p.idProductos where d.idReserva=" + idActual + " and estatus=1 and cantidad> 0";
            gvProductos.DataSource = conexion.llenarVistas(query);
            tbId.Text = idActual;
            string total = Convert.ToString(conexion.getUnDato("select total from Reserva where estatus=1 and idReserva=" + idActual));
            string deposito = Convert.ToString(conexion.getUnDato("select deposito from Reserva where estatus=1 and idReserva=" + idActual));
            string restante = Convert.ToString(conexion.getUnDato("select restante from Reserva where estatus=1 and idReserva=" + idActual));
            string anticipo = Convert.ToString(conexion.getUnDato("select anticipo from Reserva where estatus=1 and idReserva=" + tbId.Text));
			string flete = Convert.ToString(conexion.getUnDato("select flete from Reserva where estatus=1 and idReserva=" + tbId.Text));
			tbFlete.Text = flete;
            tbTotal.Text = total;
            tbDeposito.Text = deposito;
            tbRestante.Text = restante;
            tbAnticipo.Text = anticipo;

            if (restante.Equals("0"))
            {
                MessageBox.Show("Esta reservacion ya esta liquidada", "Atencion");
                tbMulta.ReadOnly = false;
                tbAbono.ReadOnly = true;
                btnAbonar.Enabled = false;
                btnLiquidar.Enabled = false;
            }
            else {
                tbMulta.ReadOnly = false;
                tbAbono.ReadOnly = false;
                btnAbonar.Enabled = true;
                btnLiquidar.Enabled = true;
            }
        }
        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tbRestante.Equals(""))
                {
                    if (tbAbono.TextLength > 0)
                    {
                        double abono = Convert.ToDouble(tbAbono.Text);
                        double res = Convert.ToDouble(conexion.getUnDato("select restante from Reserva where estatus=1 and idReserva=" + tbId.Text));

                        if (abono > res)
                        {
                            MessageBox.Show("El abono no puede ser mayor a lo restante", "Atencion");
                        }
                        else
                        {
                            DialogResult yus = MessageBox.Show("Estas segura que desea abonar " + tbAbono.Text + " esta reservcion" +
                            " \nNo existe manera de revertir esta accion una vez cargada", "Atencion", MessageBoxButtons.YesNo);
                            if (yus == DialogResult.Yes && tbId.TextLength > 0)
                            {
								string entrada2 = conexion.getUnDato("select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' from entradaDepositos where idReserva =" + tbId.Text);
								if (entrada2.Equals(""))
								{
									entrada2 = "0";
								}
								double depositodado = Convert.ToDouble(entrada2);
								double depositofaltante = Convert.ToDouble(tbDeposito.Text)-depositodado;


								double rest = Convert.ToDouble(tbRestante.Text) - depositofaltante;
								if (abono <= rest)
								{
									double anticipo = Convert.ToDouble(tbAnticipo.Text) + Convert.ToDouble(tbAbono.Text);
									tbAnticipo.Text = Convert.ToString(anticipo);
									double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
									tbRestante.Text = Convert.ToString(restante);


									conexion.ejecutar("update Reserva set total=" + tbTotal.Text + " ,anticipo=" + tbAnticipo.Text + " , restante=" + tbRestante.Text + " , actualizacion='" + DateTime.Now.ToShortDateString() + "' where estatus=1 and idReserva=" + tbId.Text);
									conexion.ejecutar("insert into abonos values(" + tbId.Text + "," + tbAbono.Text + ",'" + DateTime.Now.ToShortDateString() + "')");
									tbAbono.Text = "";
									if (tbRestante.Text.Equals("0"))
									{
										conexion.ejecutar("update Reserva set liquidacion=1 , actualizacion='" + DateTime.Now.ToShortDateString() + "' where estatus=1 and idReserva=" + tbId.Text);
									}
									mostarInfoReserva(tbId.Text);
									string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
						" fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
						"telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
						"where estatus = 1";
									gvReservaciones.DataSource = conexion.llenarVistas(query);
								}
								else
								{
									conexion.ejecutar("insert into abonos values(" + tbId.Text + "," + rest + ",'" + DateTime.Now.ToShortDateString() + "')");
									conexion.ejecutar("insert into entradaDepositos values(" + tbId.Text + "," + Convert.ToString(abono - rest) + ",'" + DateTime.Now.ToShortDateString() + "')");
									double anticipo = Convert.ToDouble(tbAnticipo.Text) + Convert.ToDouble(tbAbono.Text);
									tbAnticipo.Text = Convert.ToString(anticipo);
									double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
									tbRestante.Text = Convert.ToString(restante);


									conexion.ejecutar("update Reserva set total=" + tbTotal.Text + " ,anticipo=" + tbAnticipo.Text + " , restante=" + tbRestante.Text + " , actualizacion='" + DateTime.Now.ToShortDateString() + "' where estatus=1 and idReserva=" + tbId.Text);
									if (tbRestante.Text.Equals("0")) {
										conexion.ejecutar("update Reserva set liquidacion=1 , actualizacion='" + DateTime.Now.ToShortDateString() + "' where estatus=1 and idReserva=" + tbId.Text);
									}
									tbAbono.Text = "";
									mostarInfoReserva(tbId.Text);
									string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
						" fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
						"telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
						"where estatus = 1";
									gvReservaciones.DataSource = conexion.llenarVistas(query);
								}


							}
                            else
                            {
                                tbAbono.Text = "";
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un abono valido", "Atencion");
                    }

                }
            }
            catch {
                MessageBox.Show("Error","Atencion");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbId.TextLength>0) {
                DialogResult yus = MessageBox.Show("Estas segura que desea eliminar esta reservcion" +
                " \nNo existe manera de revertir esta accion una vez eliminada", "Atencion", MessageBoxButtons.YesNo);
                if (yus == DialogResult.Yes && tbId.TextLength > 0)
                {
					MessageBox.Show("Reservacion eliminada con exito","Atencion");
                    conexion.ejecutar("update Reserva set estatus=0 where idReserva=" + tbId.Text);
                    condicionesLimpias();
                }
                else
                {
                    if (!(yus == DialogResult.No))
                    {
                        MessageBox.Show("No se tiene seleccionada ninguna reservacion", "Atencion");
                    }

                }
            }
            else {
                MessageBox.Show("Elige una reservacion","Atencion");
            }
            
        }


        private void condicionesLimpias()
        {
            tbFolio.Text = "";
            tbBuscarCleinte.Text = "";
            string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
               " fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
               "telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
               "where estatus = 1";
            gvReservaciones.DataSource = conexion.llenarVistas(query);
            gvProductos.DataSource = null;
            tbId.Text = "";
            tbTotal.Text = "";
            tbDeposito.Text = "";
            tbRestante.Text = "";
            tbAnticipo.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMulta_KeyPress(object sender, KeyPressEventArgs e)
        {
			try
			{
				if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
				{
					e.Handled = true;
				}
				if (e.KeyChar == (char)13)
				{
					if (tbId.TextLength > 0 && tbMulta.TextLength > 0)
					{
						DialogResult yus = MessageBox.Show("Estas segura que desea agregar un cargo de " + tbMulta.Text +
						 " \nReservacion con folio " + tbId.Text, "Atencion", MessageBoxButtons.YesNo);
						if (yus == DialogResult.Yes)
						{
							double nuevoTotal = Convert.ToDouble(tbTotal.Text) + Convert.ToDouble(tbMulta.Text);
							tbTotal.Text = Convert.ToString(nuevoTotal);
							double nuevoRestante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(nuevoRestante);
							conexion.ejecutar("update Reserva set total=" + tbTotal.Text + ", restante=" + tbRestante.Text + " where estatus=1 and idReserva=" + tbId.Text);
							tbMulta.Text = "";
							mostarInfoReserva(tbId.Text);
						}
						else
						{
							tbMulta.Text = "";
						}

					}
					else
					{
						MessageBox.Show("Error \nVerifque que esta seleccionada una reservacion \nVerifique que puso una multa valida", "Atencion");
					}
				}
			}
			catch
			{
				MessageBox.Show("Atencion","Entrada de la multa invalida");
			}
			

        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbId.TextLength > 0)
                {
                    DialogResult yus = MessageBox.Show("Estas segura que desea dar liquidada esta reservacion" +
                         " \nReservacion con folio " + tbId.Text + "\nDebe recibir un pago de " + tbRestante.Text, "Atencion", MessageBoxButtons.YesNo);
                    if (yus == DialogResult.Yes)
                    {
						string entrada2 = conexion.getUnDato("select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' from entradaDepositos where idReserva ="+tbId.Text);
						if (entrada2.Equals(""))
						{
							entrada2 = "0";
						}
						double depositodado = Convert.ToDouble(entrada2);
						double depositonecesario = Convert.ToDouble(tbDeposito.Text) - depositodado;
						double abono = Convert.ToDouble(tbRestante.Text) - depositonecesario;
                        conexion.ejecutar("insert into abonos values(" + tbId.Text + "," + Convert.ToString(abono) + ",'" + DateTime.Now.ToShortDateString() + "')");
						conexion.ejecutar("insert into entradaDepositos values(" + tbId.Text + "," + depositonecesario + ",'" + DateTime.Now.ToShortDateString() + "')");
						conexion.ejecutar("update Reserva set total=" + tbTotal.Text + ", anticipo="+tbTotal.Text+", restante=0 ,liquidacion=1 where idReserva=" + tbId.Text);
                        MessageBox.Show("Reservacion liquidada. \nCon esta accion se da por echo que el cliente no debe dinero ya.", "Listo");
                        imprimir yus2 = new imprimir(tbId.Text);
                        yus2.Show();
                        condicionesLimpias();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una reservacion", "Atencion");
                }
            }
            catch {
                MessageBox.Show("Error inesperado","Atencion");
            }
            
        }

        private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
        }

        private void tbBuscarCleinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.letras(e);
        }

        private void tbAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            validar.numerosEnteros(e);
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (tbId.TextLength > 0)
            {
                string idediytar = tbId.Text;
                EditarReservacion er = new EditarReservacion(idediytar);
                er.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Selecciona una reservacion","Atencion");
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {

            if (tbId.TextLength > 0)
            {
                imprimir yus = new imprimir(tbId.Text);
                yus.Show();
            }
            else
            {
                MessageBox.Show("Selecciona una reservacion", "Atencion");
            }
           
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

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnAgregarProductos_MouseHover(object sender, EventArgs e)
        {
            btnAgregarProductos.BackColor = Color.LightGreen;
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.Tomato;
        }

        private void btnAbonar_MouseHover(object sender, EventArgs e)
        {
            btnAbonar.BackColor = Color.RoyalBlue;
        }

        private void btnLiquidar_MouseHover(object sender, EventArgs e)
        {
            btnLiquidar.BackColor = Color.BlueViolet;
        }

        private void btnTicket_MouseHover(object sender, EventArgs e)
        {
            btnTicket.BackColor = Color.RoyalBlue;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }

        private void btnAgregarProductos_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarProductos.BackColor = Color.White;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.BackColor = Color.White;
        }

        private void btnAbonar_MouseLeave(object sender, EventArgs e)
        {
            btnAbonar.BackColor = Color.White;
        }

        private void btnLiquidar_MouseLeave(object sender, EventArgs e)
        {
            btnLiquidar.BackColor = Color.White;
        }

        private void btnTicket_MouseLeave(object sender, EventArgs e)
        {
            btnTicket.BackColor = Color.White;
        }

		private void btnFechas_Click(object sender, EventArgs e)
		{
			lblFechaSalida.Enabled = true;
			label5.Enabled = true;
			dtFechaEntrega.Enabled = true;
			dtFechaRegreso.Enabled = true;
			btnActu.Enabled = true;
		}
		private Boolean estaDisponibleProducto(string idProducto, string cantidad)
		{
			DataTable reservaciones = conexion2.llenarVistas("select idReserva from Reserva where (fechaSalida between '" + dtFechaEntrega.Text + "' and '" + dtFechaRegreso.Text + "' or " +
				" fechaRegreso between '" + dtFechaEntrega.Text + "' and '" + dtFechaRegreso.Text + "') and estatus=1 and idReserva!="+tbId.Text);

			string[] reserCercanas = reservaciones.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			double productoStock = Convert.ToDouble(conexion2.getUnDato("select stock from Productos where idProductos =" + idProducto + " and estatus=1"));

			double stockEnUso = 0;
			for (int al = 0; al < reserCercanas.Length; al++)
			{

				DataTable detalleResId = conexion2.llenarVistas("select idProductos from Detalle_Reserva where idReserva=" + reserCercanas[al]);
				string[] detalleReservacionId = detalleResId.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

				DataTable detalleResCant = conexion2.llenarVistas("select cantidad from Detalle_Reserva where idReserva=" + reserCercanas[al]);
				string[] detalleReservacionCant = detalleResCant.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

				if (detalleReservacionId.Length == detalleReservacionCant.Length)
				{

					for (int l = 0; l < detalleReservacionId.Length; l++)
					{

						if (detalleReservacionId[l].Equals(idProducto))
						{

							stockEnUso = stockEnUso + Convert.ToDouble(detalleReservacionCant[l]);
						}
					}
				}
				else
				{
					stockEnUso = 0;
					MessageBox.Show("Inconsistencia de datos consulte a uno de los programadores");
				}
			}
			double stockSolicitado = stockEnUso + Convert.ToDouble(cantidad);
			if (stockSolicitado > productoStock)
			{
				double sobrante = productoStock - stockEnUso;
				return false;
			}
			else
			{
				return true;
			}

		}
		private Boolean revisar()
		{
			Boolean res = true;
			int nes = gvProductos.RowCount-1;
			for (int y = 0; y <= nes; y++) {
				res = estaDisponibleProducto(gvProductos.Rows[y].Cells[0].Value.ToString(), gvProductos.Rows[y].Cells[3].Value.ToString());
				if (res==false) {
					break;
				}
			}
			return res;
		}
		private void btnActu_Click(object sender, EventArgs e)
		{
			if (tbId.TextLength > 0)
			{
				DialogResult yus = MessageBox.Show("Segura que deseas cambiar las fechas de entrega y regreso"
			 , "Atencion", MessageBoxButtons.YesNo);
				if (yus == DialogResult.Yes)
				{
					if (revisar()) {
						string query = "update Reserva set  fechaSalida='" + dtFechaEntrega.Text + "',fechaRegreso = '" + dtFechaRegreso.Text + "' where idReserva=" + tbId.Text;
						conexion.ejecutar(query);
						MessageBox.Show("Fechas actualizadas con exito", "Atencion");
						string query2 = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
					" fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
					"telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
					"where estatus = 1";
						gvReservaciones.DataSource = conexion.llenarVistas(query2);
					}
					else {
						MessageBox.Show("Algunos productos de esta reservacion \nya estan asiganados a otras reservaciones \n con las nuevas fecha. Cancela esta reservacion y hazlo manualmente","Atencion");
					}
					
				}
			}
			else {
				MessageBox.Show("Selecciona una reservacion","Atencion");
			}
			lblFechaSalida.Enabled = false;
			label5.Enabled = false;
			dtFechaEntrega.Enabled = false;
			dtFechaRegreso.Enabled = false;
			btnActu.Enabled = false;
		}

		private void radioButton2_Click(object sender, EventArgs e)
		{
			if (tbBuscarCleinte.TextLength == 0)
			{
				string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
				" fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
				"telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
				"where estatus = 1";
				gvReservaciones.DataSource = conexion.llenarVistas(query);
			}
			else
			{
				string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
				" fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
				"telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
				"where nombre like '%" + tbBuscarCleinte.Text + "%' and estatus = 1";
				gvReservaciones.DataSource = conexion.llenarVistas(query);
			}
			tbTotalDeuda.Text = "";
		}

		private void radioButton1_Click(object sender, EventArgs e)
		{
			if (tbBuscarCleinte.TextLength == 0)
			{
				string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
				" fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
				"telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
				"where estatus = 1 and liquidacion=0";
				gvReservaciones.DataSource = conexion.llenarVistas(query);
				tbTotalDeuda.Text = "";
			}
			else
			{
				string query = "select idReserva as Id,fechaReserva as Fecha_solicitud,fechaSalida as Fecha_entrega," +
				" fechaRegreso as Fecha_Recoleccion,nombre as Cliente, " +
				"telefono as Celular, total as Total, anticipo as Anticipo, restante as Restante from Reserva " +
				"where nombre like '%" + tbBuscarCleinte.Text + "%' and estatus = 1 and liquidacion=0";
				gvReservaciones.DataSource = conexion.llenarVistas(query);
				tbTotalDeuda.Text = "";
			}
		}

		private void btnTotalReserva_Click(object sender, EventArgs e)
		{
			try
			{
				double totaldeuda = 0;
				int num_requeridos = gvReservaciones.Rows.Count;
				for (int a = 0; a < num_requeridos; a++)
				{
					int renglon = a;
					int subtotal = 8;
					string subs = gvReservaciones.Rows[renglon].Cells[subtotal].Value.ToString();
					totaldeuda += Convert.ToDouble(subs);
				}
				tbTotalDeuda.Text = Convert.ToString(totaldeuda);
				
			}
			catch
			{
				MessageBox.Show("Error inesperado", "Atencion");

			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}

	
}
