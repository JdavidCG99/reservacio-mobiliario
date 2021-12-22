using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sistema_Reservaciones
{
    public partial class reservacion : Form
    {
        Conexion2 conexion2 = new Conexion2();
        Validaciones validar = new Validaciones();
        double totalInicio;
        string NombreCliente;
        string idCliente;
        public reservacion()
        {
            InitializeComponent();
        }
		public reservacion(string idCliente, string nombreCliente)
		{
			InitializeComponent();
			this.NombreCliente = nombreCliente;
			this.idCliente = idCliente;
		}

		private void reservacion_Load(object sender, EventArgs e)
        {
            dtFechaEntrega.Value = DateTime.Now;
            dtFechaRegreso.Value = DateTime.Now;
            tbFolio.Text = Convert.ToString(conexion2.getId("select max(idReserva) from Reserva"));
            
            conexion2.select(cbUbicacion, "select ubicacion from Flete");
            conexion2.select(cbCategorias, "select nombre from Categorias");
            string query = "select idProductos as ID,nombre, descripcion, precioVenta from Productos where estatus=1";
            gvProductos.DataSource = conexion2.llenarVistas(query);
			cbUbicacion.SelectedIndex = 0;
			tbCliente.Text = this.NombreCliente;
			string[] info = conexion2.telefono("select telefono from Cliente where idCliente=" + this.idCliente);
			tbCelular.Text = info[0];


			if (!tbCliente.Text.Equals("Cliente General "))
			{
				lblBonificacion.Visible = true;
				rbBonificacion.Visible = true;
				rbNoBonificaion.Visible = true;
				lblNombreDescuento.Text = "Descuento:";
				tbNombreCliente.Width = 40;
				tbNombreCliente.Text = "0";
				tbNombreCliente.Enabled = false;
				lblPorcentaje.Visible = true;
				string[] info2 = conexion2.telefono("select telefono from Cliente where idCliente=" + this.idCliente);
				tbCelular.Text = info2[0];
				tbCelular.ReadOnly = true;

				string info23 = conexion2.getUnDato("select direcion from Cliente where idCliente=" + this.idCliente);
				tbDescripcion.Text = info23;
			}
			else
			{
				lblBonificacion.Visible = false;
				rbBonificacion.Visible = false;
				rbNoBonificaion.Visible = false;
				lblNombreDescuento.Text = "Nombre:";
				tbNombreCliente.Width = 190;
				tbNombreCliente.Enabled = true;
				rbNoBonificaion.Checked = true;
				tbNombreCliente.Text = "";
				lblPorcentaje.Visible = false;
				tbCelular.Text = "";
				tbCelular.ReadOnly = false;
				tbDescripcion.Text = "";

			}
			btnVerificar.BackColor = Color.White;
		}
		private void cbCliente_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		private void cbCliente_TextChanged(object sender, EventArgs e)
		{
			
		}
		private void dtFechaRegreso_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaRegreso.Value < dtFechaEntrega.Value.AddDays(-1))
            {
                MessageBox.Show("Fecha invalida \nLa fecha de regreso no puede ser anterios a la de salida", "Atencion");
                dtFechaRegreso.Value = dtFechaEntrega.Value;
            }
          
        }
        private void dtFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            dtFechaRegreso.Value = dtFechaEntrega.Value;
        }
        private void gvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnActualizar.BackColor = System.Drawing.Color.Yellow;
        }
        private void btnEditFolio_Click(object sender, EventArgs e)
        {
            tbFolio.Enabled = true;
        }

        private void rbBonificacion_CheckedChanged(object sender, EventArgs e)
        {
            tbNombreCliente.Text = "10";
        }

        private void rbNoBonificaion_CheckedChanged(object sender, EventArgs e)
        {
            tbNombreCliente.Text = "0";
        }

        private void cbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFlete.Text = conexion2.getUnDato("select Precio from Flete where ubicacion='" + cbUbicacion.Text + "'");
			btnVerificar.BackColor = Color.Yellow;
		}

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select Productos.idProductos, Productos.nombre, Productos.descripcion, Productos.precioVenta from Productos " +
                "inner join Categorias on Categorias.idCategoria = Productos.idCategoria " +
                "where Categorias.nombre = '" + cbCategorias.Text + "' and Productos.estatus=1";
            gvProductos.DataSource = conexion2.llenarVistas(query);

        }

        private void txtBuscadorProducto_TextChanged(object sender, EventArgs e)
        {
            string query = "select idProductos,nombre, descripcion, precioVenta from Productos  " +
               "where nombre like '%" + txtBuscadorProducto.Text + "%' and estatus=1";
            gvProductos.DataSource = conexion2.llenarVistas(query);
        }

        private Boolean noContieneLetras(string yus)
        {
            Boolean al = true;
            string[] letras = {"q","w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "ñ", "z", "x", "c", "v", "b", "n", "m", "Q", "W", "E", "R", "T",
                "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ñ", "Z", "X", "C", "V", "B", "N", "M", "<", ">", ",", ";", "-", "_", "{", "[", "}",
                "]", "´", "*", "+", "¿", "¡", "'", "?" };
            for (int l = 0; l < letras.Length; l++)
            {
                if (yus.Contains(letras[l]))
                {
                    al = false;
                    break;
                }
            }
            return al;
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private Boolean validarPedidos()
        {
            int num_requeridos = gvPedido.Rows.Count - 1;
            Boolean yus = true;
            for (int a = 0; a < num_requeridos; a++)
            {
                int renglon = a;
                int cantidad = 4;
                int subtotal = 5;
                string cantidadNecesario = gvPedido.Rows[renglon].Cells[cantidad].Value.ToString();
                string total = gvPedido.Rows[renglon].Cells[subtotal].Value.ToString();

                if (cantidadNecesario.Equals("") || total.Equals(""))
                {
                    yus = false;
                }
            }
            return yus;
        }
        private void gvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idActual = gvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                string[] datos;
                string ib = "";
                datos = conexion2.ObtenerInformacionAddProduct("select idProductos,nombre, descripcion, precioVenta from Productos where idProductos=" + idActual + " and estatus=1");
                if (datos != null)
                {
                    if (siSePuedeAgg(idActual))
                    {
                        ib = Interaction.InputBox("Ingrese la cantidad de " + datos[0] + " " + datos[1]);
                        if (!ib.Equals(""))
                        {
                            if (noContieneLetras(ib))
                            {
                                if (estaDisponibleProducto(idActual, ib))
                                {
									if ( (Convert.ToInt32(datos[0])>=1274 && Convert.ToInt32(datos[0]) <= 1285)  || (Convert.ToInt32(datos[0]) >= 1003 && Convert.ToInt32(datos[0]) <= 1070) || datos[0].Equals("1300") || datos[0].Equals("1301") || datos[0].Equals("2317"))
									{
										DialogResult con = MessageBox.Show("Se esta vendiendo como paquete?"
										 , "Atencion", MessageBoxButtons.YesNo);
										if (con == DialogResult.Yes)
										{
											switch (datos[0])
											{

												case "1274":
													int yus = gvPedido.Rows.Add();
													gvPedido.Rows[yus].Cells[0].Value = datos[0];
													gvPedido.Rows[yus].Cells[1].Value = datos[1];
													gvPedido.Rows[yus].Cells[2].Value = datos[2];
													gvPedido.Rows[yus].Cells[3].Value = "30";
													gvPedido.Rows[yus].Cells[4].Value = ib;
													double total = Convert.ToDouble(ib) * 30;
													gvPedido.Rows[yus].Cells[5].Value = Convert.ToString(total);
													break;
												case "1275":
													int yus1 = gvPedido.Rows.Add();
													gvPedido.Rows[yus1].Cells[0].Value = datos[0];
													gvPedido.Rows[yus1].Cells[1].Value = datos[1];
													gvPedido.Rows[yus1].Cells[2].Value = datos[2];
													gvPedido.Rows[yus1].Cells[3].Value = "55";
													gvPedido.Rows[yus1].Cells[4].Value = ib;
													double total1 = Convert.ToDouble(ib) * 55;
													gvPedido.Rows[yus1].Cells[5].Value = Convert.ToString(total1);
													break;
												case "1276":
													int yus2 = gvPedido.Rows.Add();
													gvPedido.Rows[yus2].Cells[0].Value = datos[0];
													gvPedido.Rows[yus2].Cells[1].Value = datos[1];
													gvPedido.Rows[yus2].Cells[2].Value = datos[2];
													gvPedido.Rows[yus2].Cells[3].Value = "30";
													gvPedido.Rows[yus2].Cells[4].Value = ib;
													double total2 = Convert.ToDouble(ib) * 30;
													gvPedido.Rows[yus2].Cells[5].Value = Convert.ToString(total2);
													break;
												case "1277":
													int yus3 = gvPedido.Rows.Add();
													gvPedido.Rows[yus3].Cells[0].Value = datos[0];
													gvPedido.Rows[yus3].Cells[1].Value = datos[1];
													gvPedido.Rows[yus3].Cells[2].Value = datos[2];
													gvPedido.Rows[yus3].Cells[3].Value = "30";
													gvPedido.Rows[yus3].Cells[4].Value = ib;
													double total3 = Convert.ToDouble(ib) * 30;
													gvPedido.Rows[yus3].Cells[5].Value = Convert.ToString(total3);
													break;
												case "1278":
													int yus4 = gvPedido.Rows.Add();
													gvPedido.Rows[yus4].Cells[0].Value = datos[0];
													gvPedido.Rows[yus4].Cells[1].Value = datos[1];
													gvPedido.Rows[yus4].Cells[2].Value = datos[2];
													gvPedido.Rows[yus4].Cells[3].Value = "10";
													gvPedido.Rows[yus4].Cells[4].Value = ib;
													double total4 = Convert.ToDouble(ib) * 10;
													gvPedido.Rows[yus4].Cells[5].Value = Convert.ToString(total4);
													break;
												case "1279":
													int yus5 = gvPedido.Rows.Add();
													gvPedido.Rows[yus5].Cells[0].Value = datos[0];
													gvPedido.Rows[yus5].Cells[1].Value = datos[1];
													gvPedido.Rows[yus5].Cells[2].Value = datos[2];
													gvPedido.Rows[yus5].Cells[3].Value = "20";
													gvPedido.Rows[yus5].Cells[4].Value = ib;
													double total5 = Convert.ToDouble(ib) * 20;
													gvPedido.Rows[yus5].Cells[5].Value = Convert.ToString(total5);
													break;
												case "1280":
													int yus6 = gvPedido.Rows.Add();
													gvPedido.Rows[yus6].Cells[0].Value = datos[0];
													gvPedido.Rows[yus6].Cells[1].Value = datos[1];
													gvPedido.Rows[yus6].Cells[2].Value = datos[2];
													gvPedido.Rows[yus6].Cells[3].Value = "10";
													gvPedido.Rows[yus6].Cells[4].Value = ib;
													double total6 = Convert.ToDouble(ib) * 10;
													gvPedido.Rows[yus6].Cells[5].Value = Convert.ToString(total6);
													break;
												case "1281":
													int yus7 = gvPedido.Rows.Add();
													gvPedido.Rows[yus7].Cells[0].Value = datos[0];
													gvPedido.Rows[yus7].Cells[1].Value = datos[1];
													gvPedido.Rows[yus7].Cells[2].Value = datos[2];
													gvPedido.Rows[yus7].Cells[3].Value = "11";
													gvPedido.Rows[yus7].Cells[4].Value = ib;
													double total7 = Convert.ToDouble(ib) * 11;
													gvPedido.Rows[yus7].Cells[5].Value = Convert.ToString(total7);
													break;
												case "1282":
													int yus8 = gvPedido.Rows.Add();
													gvPedido.Rows[yus8].Cells[0].Value = datos[0];
													gvPedido.Rows[yus8].Cells[1].Value = datos[1];
													gvPedido.Rows[yus8].Cells[2].Value = datos[2];
													gvPedido.Rows[yus8].Cells[3].Value = "10";
													gvPedido.Rows[yus8].Cells[4].Value = ib;
													double total8 = Convert.ToDouble(ib) * 10;
													gvPedido.Rows[yus8].Cells[5].Value = Convert.ToString(total8);
													break;
												case "1283":
													int yus9 = gvPedido.Rows.Add();
													gvPedido.Rows[yus9].Cells[0].Value = datos[0];
													gvPedido.Rows[yus9].Cells[1].Value = datos[1];
													gvPedido.Rows[yus9].Cells[2].Value = datos[2];
													gvPedido.Rows[yus9].Cells[3].Value = "10";
													gvPedido.Rows[yus9].Cells[4].Value = ib;
													double total9 = Convert.ToDouble(ib) * 10;
													gvPedido.Rows[yus9].Cells[5].Value = Convert.ToString(total9);
													break;
												case "1284":
													int yusl = gvPedido.Rows.Add();
													gvPedido.Rows[yusl].Cells[0].Value = datos[0];
													gvPedido.Rows[yusl].Cells[1].Value = datos[1];
													gvPedido.Rows[yusl].Cells[2].Value = datos[2];
													gvPedido.Rows[yusl].Cells[3].Value = "21";
													gvPedido.Rows[yusl].Cells[4].Value = ib;
													double totall = Convert.ToDouble(ib) * 21;
													gvPedido.Rows[yusl].Cells[5].Value = Convert.ToString(totall);
													break;
												case "1285":
													int yusli = gvPedido.Rows.Add();
													gvPedido.Rows[yusli].Cells[0].Value = datos[0];
													gvPedido.Rows[yusli].Cells[1].Value = datos[1];
													gvPedido.Rows[yusli].Cells[2].Value = datos[2];
													gvPedido.Rows[yusli].Cells[3].Value = "8";
													gvPedido.Rows[yusli].Cells[4].Value = ib;
													double totalyus = Convert.ToDouble(ib) * 8;
													gvPedido.Rows[yusli].Cells[5].Value = Convert.ToString(totalyus);
													break;
												case "1300":
													int yuslinc = gvPedido.Rows.Add();
													gvPedido.Rows[yuslinc].Cells[0].Value = datos[0];
													gvPedido.Rows[yuslinc].Cells[1].Value = datos[1];
													gvPedido.Rows[yuslinc].Cells[2].Value = datos[2];
													gvPedido.Rows[yuslinc].Cells[3].Value = "1100";
													gvPedido.Rows[yuslinc].Cells[4].Value = ib;
													double totalyusnc = Convert.ToDouble(ib) * 1100;
													gvPedido.Rows[yuslinc].Cells[5].Value = Convert.ToString(totalyusnc);
													break;
												case "1301":
													int yuslim = gvPedido.Rows.Add();
													gvPedido.Rows[yuslim].Cells[0].Value = datos[0];
													gvPedido.Rows[yuslim].Cells[1].Value = datos[1];
													gvPedido.Rows[yuslim].Cells[2].Value = datos[2];
													gvPedido.Rows[yuslim].Cells[3].Value = "1700";
													gvPedido.Rows[yuslim].Cells[4].Value = ib;
													double totalyusm = Convert.ToDouble(ib) * 1700;
													gvPedido.Rows[yuslim].Cells[5].Value = Convert.ToString(totalyusm);
													break;
												default:
													int yuslin = gvPedido.Rows.Add();
													gvPedido.Rows[yuslin].Cells[0].Value = datos[0];
													gvPedido.Rows[yuslin].Cells[1].Value = datos[1];
													gvPedido.Rows[yuslin].Cells[2].Value = datos[2];
													gvPedido.Rows[yuslin].Cells[3].Value = "0";
													gvPedido.Rows[yuslin].Cells[4].Value = ib;
													double totalyusn = Convert.ToDouble(ib) * 0;
													gvPedido.Rows[yuslin].Cells[5].Value = Convert.ToString(totalyusn);
													break;
											}
										}
										else {
											int yus = gvPedido.Rows.Add();
											gvPedido.Rows[yus].Cells[0].Value = datos[0];
											gvPedido.Rows[yus].Cells[1].Value = datos[1];
											gvPedido.Rows[yus].Cells[2].Value = datos[2];
											gvPedido.Rows[yus].Cells[3].Value = datos[3];
											gvPedido.Rows[yus].Cells[4].Value = ib;
											string precios = datos[3];
											double total = Convert.ToDouble(ib) * Convert.ToDouble(datos[3]);
											gvPedido.Rows[yus].Cells[5].Value = Convert.ToString(total);
										}
									}
									else {
										int yus = gvPedido.Rows.Add();
										gvPedido.Rows[yus].Cells[0].Value = datos[0];
										gvPedido.Rows[yus].Cells[1].Value = datos[1];
										gvPedido.Rows[yus].Cells[2].Value = datos[2];
										gvPedido.Rows[yus].Cells[3].Value = datos[3];
										gvPedido.Rows[yus].Cells[4].Value = ib;
										string precios = datos[3];
										double total = Convert.ToDouble(ib) * Convert.ToDouble(datos[3]);
										gvPedido.Rows[yus].Cells[5].Value = Convert.ToString(total);
									}

								}
                            }
                            else
                            {
                                MessageBox.Show("El valor inresado de cantidad no es valido. \nProbablemente introdujo una letra y no un numero.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ese producto ya esta agregado a la reservacion " +
                            "\nPuedes actualizar la cantidad en la columna de cantidad" +
                            " \n Despues de eso da clic en el boton actualizar", "Atencion");
                    }

                }
            }
            catch {
                MessageBox.Show("Da clic en un producto");
            }


        }
        private Boolean siSePuedeAgg(string idProducto) {
            return true;
        }
        private Boolean estaDisponibleProducto(string idProducto, string cantidad) {
            DataTable reservaciones = conexion2.llenarVistas("select idReserva from Reserva where (fechaSalida between '" + dtFechaEntrega.Text + "' and '" + dtFechaRegreso.Text + "' or " +
                " fechaRegreso between '" + dtFechaEntrega.Text + "' and '" + dtFechaRegreso.Text + "') and estatus=1");

            string[] reserCercanas = reservaciones.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            double productoStock = Convert.ToDouble(conexion2.getUnDato("select stock from Productos where idProductos =" + idProducto + " and estatus=1"));

            double stockEnUso = 0;
            for (int al = 0; al < reserCercanas.Length; al++) {

                DataTable detalleResId = conexion2.llenarVistas("select idProductos from Detalle_Reserva where idReserva=" + reserCercanas[al]);
                string[] detalleReservacionId = detalleResId.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

                DataTable detalleResCant = conexion2.llenarVistas("select cantidad from Detalle_Reserva where idReserva=" + reserCercanas[al]);
                string[] detalleReservacionCant = detalleResCant.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

                if (detalleReservacionId.Length == detalleReservacionCant.Length) {

                    for (int l = 0; l < detalleReservacionId.Length; l++) {

                        if (detalleReservacionId[l].Equals(idProducto)) {

							stockEnUso = stockEnUso + Convert.ToDouble(detalleReservacionCant[l]);
                        }
					}
                }
                else {
                    stockEnUso = 0;
                    MessageBox.Show("Inconsistencia de datos consulte a uno de los programadores");
                }
            }
			//aqui hay qque hacer el cambio
            double stockSolicitado = stockEnUso + Convert.ToDouble(cantidad);
            if (stockSolicitado > productoStock) {
                double sobrante = productoStock - stockEnUso;
                MessageBox.Show("No se cuenta con el stock suficiente \nStock existente disponible = " + Convert.ToString(sobrante), "Atencion");
                return false;
            } else {
                return true;
            }

        }

        private Boolean validarStock(int stock, int cantidad) {
            if (cantidad > stock) {
                return false;
            } else {
                return true;
            }

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

            try
            {
                int num_requeridos = gvPedido.Rows.Count - 1;
                for (int a = 0; a < num_requeridos; a++)
                {
                    int renglon = a;
                    int id = 0;
                    int nom = 1;
                    int precio = 3;
                    int cantidad = 4;
                    int subtotal = 5;
                    string idProducto = gvPedido.Rows[renglon].Cells[id].Value.ToString();
                    string nombre = gvPedido.Rows[renglon].Cells[nom].Value.ToString();
                    string precioProducto = gvPedido.Rows[renglon].Cells[precio].Value.ToString();
                    string cantidadNecesario = gvPedido.Rows[renglon].Cells[cantidad].Value.ToString();

                    if (estaDisponibleProducto(idProducto, cantidadNecesario))
                    {
                        double sub = Convert.ToDouble(precioProducto) * Convert.ToDouble(cantidadNecesario);
                        gvPedido.Rows[renglon].Cells[subtotal].Value = Convert.ToString(sub);
                    }
                    else {
                        MessageBox.Show("No se cuenta con el stock suficiente del producto " + nombre, "Atencion");
                        gvPedido.Rows[renglon].Cells[cantidad].Value = "";
                        gvPedido.Rows[renglon].Cells[subtotal].Value = "";


                    }
                }
                btnActualizar.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                MessageBox.Show("Verifique que ingreso la cantidad de todos los productos", "Atencion");

            }

        }
        private Boolean validarId() {
            return true;
        }
        private Boolean validarDatos()
        {
            if (tbFolio.TextLength > 0 && tbNombreCliente.TextLength > 0 && tbFlete.TextLength > 0 && tbCelular.TextLength > 0 && tbDescripcion.TextLength > 0)
            {
                if (validarPedidos() && validarId())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Agregue productos a la reservacion \nRevise que los productos tengan cantidad y costo", "Atencion");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Verifique que los datos estan completos", "Atencion");
                return false;
            }
        }
        private double costoProductos()
        {
            double total = 0;
            int num_requeridos = gvPedido.Rows.Count - 1;
            for (int a = 0; a < num_requeridos; a++)
            {
                int renglon = a;
                int subtotal = 5;

                string totalProducto = gvPedido.Rows[renglon].Cells[subtotal].Value.ToString();
                total = total + Convert.ToDouble(totalProducto);
            }
            return total;
        }
        private void limpiarCotizacion() {
            tbSubTotal.Text = "0";
            tbDescuento.Text = "0";
            tbDeposito.Text = "0";
            tbTotal.Text = "";
            tbAnticipo.Text = "0";
            tbRestante.Text = "";
        }
        public void Cotizar() {
			try
			{
				if (validarDatos())
				{
					bool fail = false;
					double flete = Convert.ToInt32(tbFlete.Text);
					double totalProductos = costoProductos();

					tbSubTotal.Text = Convert.ToString(totalProductos);

					double descuento = 0;
					if (!tbCliente.Text.Equals("Cliente General "))
					{
						descuento = Convert.ToDouble(tbNombreCliente.Text);
					}
					double aDescontar = Convert.ToDouble(tbSubTotal.Text) / 100 * descuento;
					double descuentoActual = 0;
					if (tbDescuento.TextLength > 0)
					{
						descuentoActual = Convert.ToDouble(tbDescuento.Text);
					}
					double anticipo = 0;
					if (tbAnticipo.TextLength > 0)
					{
						anticipo = Convert.ToDouble(tbAnticipo.Text);
					}
					if (tbTotal.TextLength > 0)
					{
						double toyus = Convert.ToDouble(tbTotal.Text) + flete;
						if (anticipo <= toyus)
						{
							double total = Convert.ToDouble(tbTotal.Text) - anticipo;
							tbRestante.Text = Convert.ToString(total);
						}
						else
						{
							MessageBox.Show("El anticipo no puede ser mayor al total de la reservacion", "Atencion");
							tbAnticipo.Text = "0";
						}
					}
					else
					{
						double total = Convert.ToDouble(tbSubTotal.Text) - Convert.ToDouble(tbDescuento.Text) - Convert.ToDouble(tbAnticipo.Text);
						tbRestante.Text = Convert.ToString(total);
					}
					if (tbTotal.TextLength > 0)
					{
							if (descuentoActual <= Convert.ToDouble(tbSubTotal.Text))
							{
								if (!tbCliente.Text.Equals("Cliente General "))
								{

									tbDescuento.Text = Convert.ToString(descuentoActual + aDescontar);
									double total = Convert.ToDouble(tbSubTotal.Text) + flete - Convert.ToDouble(tbDescuento.Text);
									tbTotal.Text = Convert.ToString(total);
								}
								else
								{

									tbDescuento.Text = Convert.ToString(descuentoActual);
									double total = Convert.ToDouble(tbSubTotal.Text) + flete - Convert.ToDouble(tbDescuento.Text);
									tbTotal.Text = Convert.ToString(total);

								}

							}
						else
						{
							MessageBox.Show("El descuento no puede ser mayor al total de la reservacion al total de productos", "Atencion");
							tbDescuento.Text = "0";
							fail = true;
							double total = Convert.ToDouble(tbSubTotal.Text) + flete + Convert.ToDouble(tbDeposito.Text);
							tbTotal.Text = Convert.ToString(total);

							double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(restante);
						}
					}
					else
					{
						if (!tbCliente.Text.Equals("Cliente General "))
						{
							tbDescuento.Text = Convert.ToString(descuentoActual + aDescontar);
						}
						double total = Convert.ToDouble(tbSubTotal.Text) + flete - Convert.ToDouble(tbDescuento.Text);
						tbTotal.Text = Convert.ToString(total);
					}
					if (!fail) {
						double deposito = 0;
						if (tbDeposito.TextLength > 0)
						{
							deposito = Convert.ToDouble(tbDeposito.Text);
						}
						if (tbTotal.TextLength > 0)
						{
							double total = Convert.ToDouble(tbTotal.Text) + deposito;
							tbTotal.Text = Convert.ToString(total);

							double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(restante);
						}
						else
						{
							double total = Convert.ToDouble(tbSubTotal.Text) - Convert.ToDouble(tbDescuento.Text) - Convert.ToDouble(tbAnticipo.Text) + Convert.ToDouble(tbDeposito.Text);
							tbTotal.Text = Convert.ToString(total);
							double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(restante);
						}
					}
				}
				if (tbSubTotal.TextLength > 0 && tbDescuento.TextLength > 0 && tbDeposito.TextLength > 0 &&
					tbTotal.TextLength > 0 && tbAnticipo.TextLength > 0 && tbRestante.TextLength > 0)
				{
					btnReservar.Enabled = true;
				}
			}
			catch
			{
				MessageBox.Show("Verifique que todos los datos monetarios estan llenos", "Atencion");
			}
		}
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Cotizar();
			btnImp.Enabled = true;
			btnVerificar.BackColor = Color.White;

		}
        private void btnReservar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que quieres agendar esta reservacion" 
                , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes)
            {
                try
                {
					int idflete = cbUbicacion.SelectedIndex + 1;

					if (tbCliente.Text.Equals("Cliente General "))
					{
						this.NombreCliente = tbNombreCliente.Text;
					}

					string query = "insert into Reserva values (" + tbFolio.Text + ",'" + DateTime.Now.ToShortDateString() + "','" + dtFechaEntrega.Text + "','" + dtFechaRegreso.Text + "'," + this.idCliente + ",'" + this.NombreCliente + "'," +
                         "'" + tbDescripcion.Text + "','" + tbCelular.Text + "'," + Convert.ToString(idflete) + "," + tbTotal.Text + "," + tbAnticipo.Text + "," + tbRestante.Text + "," + tbDeposito.Text + ",1,0,'" + DateTime.Now.ToShortDateString()+ "' ,"+tbDescuento.Text+",'No','No',"+tbFlete.Text+","+tbiva.Text+")";
                    conexion2.ejecutar(query);
					if (Convert.ToDouble(tbAnticipo.Text) <= (Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbDeposito.Text)))
					{
						conexion2.ejecutar("insert into abonos values(" + tbFolio.Text + "," + tbAnticipo.Text + ",'" + DateTime.Now.ToShortDateString() + "')");
					}
					else {
						double abono = Convert.ToDouble(tbAnticipo.Text) - Convert.ToDouble(tbDeposito.Text);
						conexion2.ejecutar("insert into abonos values(" + tbFolio.Text + "," + Convert.ToString(abono) + ",'" + DateTime.Now.ToShortDateString() + "')");
						double deposito = Convert.ToDouble(tbAnticipo.Text) - abono;
						conexion2.ejecutar("insert into entradaDepositos values(" + tbFolio.Text + "," + Convert.ToString(deposito) + ",'" + DateTime.Now.ToShortDateString() + "')");

					}
					if (tbAnticipo.Text.Equals(tbTotal.Text)) {
						conexion2.ejecutar("update Reserva set liquidacion=1 , actualizacion='" + DateTime.Now.ToShortDateString() + "' where estatus=1 and idReserva=" + tbFolio.Text);
					}
					int num_requeridos = gvPedido.Rows.Count - 1;
                    string idReservacion = tbFolio.Text;
                    for (int a = 0; a < num_requeridos; a++)
                    {
                        int renglon = a;
                        string producto = gvPedido.Rows[renglon].Cells[0].Value.ToString();
                        string cantidad = gvPedido.Rows[renglon].Cells[4].Value.ToString();
                        string total = gvPedido.Rows[renglon].Cells[5].Value.ToString();
                        string q = "insert into Detalle_Reserva values (" + idReservacion + "," + producto + "," + cantidad + "," + total + ")";
                        conexion2.ejecutar(q);
                    }
                    MessageBox.Show("Reservacion echa con exito", "Nota");

                    imprimir imp = new imprimir(tbFolio.Text);
                    imp.Show();
                    limpiarReservacion();
                }
                catch {
                    MessageBox.Show("Hubo un error al guardar la reservacion \nContacte a uno de los programadores", "Atencion");
                }
               
            }
        }
        public void limpiarReservacion() {
            cbUbicacion.SelectedIndex = 0;
            limpiarCotizacion();
            rbBonificacion.Checked = false;
            rbNoBonificaion.Checked = true;
            gvPedido.Rows.Clear();
            tbFolio.Text = Convert.ToString(conexion2.getId("select max(idReserva) from Reserva"));
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que elimnar este producto de la reservacion"
               , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes) {
                gvPedido.Rows.Remove(gvPedido.CurrentRow);
            }
                
        }
        private void tbFolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
        }

        private void tbCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
        }

        private void tbSubTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar.numerosEnteros(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar.numerosEnteros(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
			//Cotizar();
			btnVerificar.BackColor = Color.Yellow;
		}

        private void tbDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validar.numerosEnteros(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
			btnVerificar.BackColor = Color.Yellow;
		}

        private void tbTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
			btnVerificar.BackColor = Color.Yellow;
		}

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Si no ha guardado la reservacion se perderan los datos \nSegura que desea salir"
               , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes)
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
            
        }

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }

        private void tbDescuento_TextChanged(object sender, EventArgs e)
        {
			btnVerificar.BackColor = Color.Yellow;
		}

        private void btnVerificar_MouseHover(object sender, EventArgs e)
        {
            btnVerificar.BackColor = Color.RoyalBlue;
        }

        private void btnReservar_MouseHover(object sender, EventArgs e)
        {
            btnReservar.BackColor = Color.LawnGreen;
        }

        private void btnReservar_MouseLeave(object sender, EventArgs e)
        {
            btnReservar.BackColor = Color.White;
        }

        private void btnVerificar_MouseLeave(object sender, EventArgs e)
        {
            btnVerificar.BackColor = Color.White;
        }

        private void btnQuitar_MouseHover(object sender, EventArgs e)
        {
            btnQuitar.BackColor = Color.Tomato;
        }

        private void btnQuitar_MouseLeave(object sender, EventArgs e)
        {
            btnQuitar.BackColor = Color.White;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void gvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void tbFlete_KeyPress(object sender, KeyPressEventArgs e)
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

		private void rbivasi_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void rbivano_CheckedChanged(object sender, EventArgs e)
		{
			
		
		}

		private void rbivasi_Click(object sender, EventArgs e)
		{
			try
			{
				double iva = Convert.ToDouble(tbSubTotal.Text) / 100 * 16;
				double actualTotal = Convert.ToDouble(tbTotal.Text);
				double actualSub = Convert.ToDouble(tbSubTotal.Text);
				double esperado = actualSub + iva;
				if (actualTotal >= esperado)
				{
					MessageBox.Show("Ya se calculo y sumo el iva", "Atencion");
				}
				else
				{
					tbiva.Text = Convert.ToString(iva);

					double nuevTotalfinal = Convert.ToDouble(tbTotal.Text) + iva;
					tbTotal.Text = Convert.ToString(nuevTotalfinal);

					double nuevRestante = Convert.ToDouble(tbRestante.Text) + iva;
					tbRestante.Text = Convert.ToString(nuevRestante);
				}
			}
			catch {
				MessageBox.Show("Los calculos del iva se hacen al final","Atencion");
			}
			
		}

		private void rbNo_Click(object sender, EventArgs e)
		{
			try {
				double nuevTotal = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbiva.Text);
				tbTotal.Text = Convert.ToString(nuevTotal);
				double nuevrestante = Convert.ToDouble(tbRestante.Text) - Convert.ToDouble(tbiva.Text);
				tbRestante.Text = Convert.ToString(nuevrestante);
				tbiva.Text = "0";
			}
			catch
			{
				MessageBox.Show("Los calculos del iva se hacen al final", "Atencion");
			}
			
		}

		private void btnImp_Click(object sender, EventArgs e)
		{
			int p = gvPedido.RowCount;
			string[] idsp = new string[p];
			string[] cantidades = new string[p];
			string[] nombres = new string[p];
			string[] precios = new string[p];
			string[] totales = new string[p];
			for (int y=0;y<p-1;y++)
			{
				idsp[y] = Convert.ToString(gvPedido.Rows[y].Cells[0].Value);
				cantidades[y] = Convert.ToString(gvPedido.Rows[y].Cells[4].Value);
				nombres[y] = Convert.ToString(gvPedido.Rows[y].Cells[1].Value);
				precios[y] = Convert.ToString(gvPedido.Rows[y].Cells[3].Value);
				totales[y] = Convert.ToString(gvPedido.Rows[y].Cells[5].Value);
			}

			imprimir yuslin = new imprimir(tbFolio.Text, dtFechaEntrega.Text,dtFechaEntrega.Text,dtFechaRegreso.Text,tbNombreCliente.Text,
				tbCelular.Text,cbUbicacion.Text,tbFlete.Text,tbDescripcion.Text,tbTotal.Text,tbAnticipo.Text,tbRestante.Text,tbDeposito.Text,tbDescuento.Text,
				tbiva.Text,idsp,cantidades,nombres,precios,totales);
			yuslin.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			agregarClientes yus = new agregarClientes(true);
			yus.Show();
			this.Close();
		}
	}
}
