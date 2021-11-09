using Microsoft.VisualBasic;
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
    public partial class EditarReservacion : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validar = new Validaciones();
        string id;
        string fechaSalida;
        string fechaRegreso;
        string nombre;
        string ubicacion;
        string precio;
        string total;
        string anticipo;
        string restante;
        string deposito;
        string descuento;
        int contador;
        double totalInicioprogram;
        double subtotal = 0;
		double fleteIncial;
        //string idFlete;
        public EditarReservacion(String id)
        {
            InitializeComponent();
            this.id = id;
        }
        int contadorProducto;
        private void EditarReservacion_Load(object sender, EventArgs e)
        {
            string []datos=conexion.geInfoReservacion("select r.fechaSalida,r.fechaRegreso,r.nombre as nombre,f.ubicacion," +
                "f.idFlete as precio,r.total," +
                "r.anticipo,r.restante,r.deposito,r.descripcionUbicacion,r.descuento " +
                "from Reserva as r inner join Flete as f on r.idFlete=f.idFlete where r.idReserva=" + id);
            tbFolio.Text =id;
            fechaSalida = datos[0];
            fechaRegreso = datos[1];
            nombre = datos[2];
            ubicacion = datos[3];
            precio = datos[4];
            total = datos[5];
           
            anticipo = datos[6];
            restante = datos[7];
            deposito = datos[8];
            descuento = datos[10];
            tbTotal.Text = total;
            tbAnticipo.Text = anticipo;
            tbRestante.Text = restante;
            tbDeposito.Text = deposito;
            tbDescuento.Text = datos[10];
			tbiva.Text = Convert.ToString(conexion.getUnDato("select iva from Reserva where estatus=1 and idReserva=" + id));
			tbCelular.Text = Convert.ToString(conexion.getUnDato("select telefono from Reserva where estatus=1 and idReserva=" + id));
			string idFlete = Convert.ToString(conexion.getUnDato("select idFlete from Reserva where estatus=1 and idReserva=" + id));
			//MessageBox.Show(idFlete);
			tbFleteCosto.Text = Convert.ToString(conexion.getUnDato("select Precio from Flete where idFlete=" + idFlete));
			if (Convert.ToDouble(tbiva.Text) > 0)
			{
				rbivasi.Checked = true;
				rbNo.Checked = false;
			}
			else
			{
				rbNo.Checked = true;
				rbivasi.Checked = false;
			}
			subtotal = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbDeposito.Text) + Convert.ToDouble(datos[10]) - Convert.ToDouble(tbiva.Text);
            totalInicioprogram = subtotal;
            tbSubTotal.Text= Convert.ToString(subtotal);
            //conexion.select(cbCliente, "select CONCAT(nombre,' ',apellidoP,' ',apellidoM) from Cliente where idCliente="+nombre);
            conexion.select(cbUbicacion, "select CONCAT(idFlete,' ',ubicacion) from Flete");
            conexion.select(cbCategorias, "select nombre from Categorias");
            string query = "select idProductos as ID,nombre, descripcion, precioVenta from Productos where estatus=1";
            gvProductos.DataSource = conexion.llenarVistas(query);
			cbCliente.Text = nombre;
            cbUbicacion.SelectedIndex = Convert.ToInt32(precio)-1;
             tbDescripcion.Text= datos[9];
            string query2 = "select d.idProductos as Id,p.nombre as Nombre,p.descripcion as Descripcion," +
                "d.cantidad as Cantidad, d.total as Total from Detalle_Reserva as d " +
                "inner join Productos as p on d.idProductos=p.idProductos where d.idReserva=" + id + " and estatus=1 and cantidad>0";
            gvPedido.DataSource = conexion.llenarVistas(query2);
			tbiva.Text = Convert.ToString(conexion.getUnDato("select iva from Reserva where estatus=1 and idReserva=" + id));
			if (Convert.ToDouble(tbiva.Text) > 0)
			{
				rbivasi.Checked = true;
				rbNo.Checked = false;
			}
			else {
				rbNo.Checked = true;
				rbivasi.Checked = false;
			}
			contador = gvPedido.RowCount-1;

            btnVerificar.BackColor = Color.White;
            btnVerificar.Enabled = false;
			fleteIncial = Convert.ToDouble(tbFleteCosto.Text);

        }

        private void btnEditFolio_Click(object sender, EventArgs e)
        {
        }

        private void cbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
			string texto = cbUbicacion.Text;
			int posicion = texto.IndexOf(" ");
			String substring = cbUbicacion.Text.Substring(0, posicion);
			string id = substring;
			tbFleteCosto.Text = Convert.ToString(conexion.getUnDato("select Precio from Flete where idFlete='" + id + "'"));
			btnVerificar.Enabled = true;
			btnVerificar.BackColor = Color.Yellow;
		}

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select Productos.idProductos, Productos.nombre, Productos.descripcion, Productos.precioVenta from Productos " +
                "inner join Categorias on Categorias.idCategoria = Productos.idCategoria " +
                "where Categorias.nombre = '" + cbCategorias.Text + "' and Productos.estatus=1";
            gvProductos.DataSource = conexion.llenarVistas(query);

        }

        private void txtBuscadorProducto_TextChanged(object sender, EventArgs e)
        {
            string query = "select idProductos,nombre, descripcion, precioVenta from Productos  " +
               "where nombre like '" + txtBuscadorProducto.Text + "%' and estatus=1";
            gvProductos.DataSource = conexion.llenarVistas(query);
        }

        private Boolean noContieneLetras(string yus)
        {
            Boolean al = true;
            string[] letras = {"q","w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "ñ", "z", "x", "c", "v", "b", "n", "m", "Q", "W", "E", "R", "T",
                "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Ñ", "Z", "X", "C", "V", "B", "N", "M", "<", ">", ",", ";", "_", "{", "[", "}",
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
        private void gvPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private Boolean validarPedidos()
        {
            int num_requeridos = gvNewProducts.Rows.Count - 1;
            Boolean yus = true;
            for (int a = 0; a < num_requeridos; a++)
            {
                int renglon = a;
                int cantidad = 4;
                int subtotal = 5;
                string cantidadNecesario = gvNewProducts.Rows[renglon].Cells[cantidad].Value.ToString();
                string total = gvNewProducts.Rows[renglon].Cells[subtotal].Value.ToString();

                if (cantidadNecesario.Equals("") || total.Equals(""))
                {
                    yus = false;
                }
            }
            return yus;
        }
        private void gvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idActual = gvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            string[] datos;
            string ib = "";
            datos = conexion.ObtenerInformacionAddProduct("select idProductos,nombre, descripcion, precioVenta from Productos where idProductos=" + idActual + " and estatus=1");
            if (datos != null)
            {
                //if (siSePuedeAgg(idActual) && siSePuedeAgg2(idActual))
                if (siSePuedeAgg2(idActual))
                {
                    ib = Interaction.InputBox("Ingrese la cantidad de " + datos[0] + " " + datos[1]);
                    if (!ib.Equals(""))
                    {
                        if (noContieneLetras(ib))
                        {
                            if (estaDisponibleProducto(idActual, ib))
                            {
								if ((Convert.ToInt32(datos[0]) >= 1274 && Convert.ToInt32(datos[0]) <= 1285) || (Convert.ToInt32(datos[0]) >= 1003 && Convert.ToInt32(datos[0]) <= 1070) || datos[0].Equals("1300") || datos[0].Equals("1301"))
								{
									DialogResult con = MessageBox.Show("Se esta vendiendo como paquete?"
									 , "Atencion", MessageBoxButtons.YesNo);
									if (con == DialogResult.Yes)
									{

										switch (datos[0])
										{

											case "1274":
												int yus = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus].Cells[3].Value = "30";
												gvNewProducts.Rows[yus].Cells[4].Value = ib;
												double total = Convert.ToDouble(ib) * 30;
												gvNewProducts.Rows[yus].Cells[5].Value = Convert.ToString(total);
												break;
											case "1275":
												int yus1 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus1].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus1].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus1].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus1].Cells[3].Value = "55";
												gvNewProducts.Rows[yus1].Cells[4].Value = ib;
												double total1 = Convert.ToDouble(ib) * 55;
												gvNewProducts.Rows[yus1].Cells[5].Value = Convert.ToString(total1);
												break;
											case "1276":
												int yus2 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus2].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus2].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus2].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus2].Cells[3].Value = "30";
												gvNewProducts.Rows[yus2].Cells[4].Value = ib;
												double total2 = Convert.ToDouble(ib) * 30;
												gvNewProducts.Rows[yus2].Cells[5].Value = Convert.ToString(total2);
												break;
											case "1277":
												int yus3 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus3].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus3].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus3].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus3].Cells[3].Value = "30";
												gvNewProducts.Rows[yus3].Cells[4].Value = ib;
												double total3 = Convert.ToDouble(ib) * 30;
												gvNewProducts.Rows[yus3].Cells[5].Value = Convert.ToString(total3);
												break;
											case "1278":
												int yus4 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus4].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus4].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus4].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus4].Cells[3].Value = "10";
												gvNewProducts.Rows[yus4].Cells[4].Value = ib;
												double total4 = Convert.ToDouble(ib) * 10;
												gvNewProducts.Rows[yus4].Cells[5].Value = Convert.ToString(total4);
												break;
											case "1279":
												int yus5 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus5].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus5].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus5].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus5].Cells[3].Value = "20";
												gvNewProducts.Rows[yus5].Cells[4].Value = ib;
												double total5 = Convert.ToDouble(ib) * 20;
												gvNewProducts.Rows[yus5].Cells[5].Value = Convert.ToString(total5);
												break;
											case "1280":
												int yus6 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus6].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus6].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus6].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus6].Cells[3].Value = "10";
												gvNewProducts.Rows[yus6].Cells[4].Value = ib;
												double total6 = Convert.ToDouble(ib) * 10;
												gvNewProducts.Rows[yus6].Cells[5].Value = Convert.ToString(total6);
												break;
											case "1281":
												int yus7 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus7].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus7].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus7].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus7].Cells[3].Value = "11";
												gvNewProducts.Rows[yus7].Cells[4].Value = ib;
												double total7 = Convert.ToDouble(ib) * 11;
												gvNewProducts.Rows[yus7].Cells[5].Value = Convert.ToString(total7);
												break;
											case "1282":
												int yus8 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus8].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus8].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus8].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus8].Cells[3].Value = "10";
												gvNewProducts.Rows[yus8].Cells[4].Value = ib;
												double total8 = Convert.ToDouble(ib) * 10;
												gvNewProducts.Rows[yus8].Cells[5].Value = Convert.ToString(total8);
												break;
											case "1283":
												int yus9 = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yus9].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yus9].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yus9].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yus9].Cells[3].Value = "10";
												gvNewProducts.Rows[yus9].Cells[4].Value = ib;
												double total9 = Convert.ToDouble(ib) * 10;
												gvNewProducts.Rows[yus9].Cells[5].Value = Convert.ToString(total9);
												break;
											case "1284":
												int yusl = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yusl].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yusl].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yusl].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yusl].Cells[3].Value = "21";
												gvNewProducts.Rows[yusl].Cells[4].Value = ib;
												double totall = Convert.ToDouble(ib) * 21;
												gvNewProducts.Rows[yusl].Cells[5].Value = Convert.ToString(totall);
												break;
											case "1285":
												int yusli = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yusli].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yusli].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yusli].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yusli].Cells[3].Value = "8";
												gvNewProducts.Rows[yusli].Cells[4].Value = ib;
												double totalyus = Convert.ToDouble(ib) * 8;
												gvNewProducts.Rows[yusli].Cells[5].Value = Convert.ToString(totalyus);
												break;
											case "1300":
												int yuslinc = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yuslinc].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yuslinc].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yuslinc].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yuslinc].Cells[3].Value = "1100";
												gvNewProducts.Rows[yuslinc].Cells[4].Value = ib;
												double totalyusnc = Convert.ToDouble(ib) * 1100;
												gvNewProducts.Rows[yuslinc].Cells[5].Value = Convert.ToString(totalyusnc);
												break;
											case "1301":
												int yuslim = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yuslim].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yuslim].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yuslim].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yuslim].Cells[3].Value = "1700";
												gvNewProducts.Rows[yuslim].Cells[4].Value = ib;
												double totalyusm = Convert.ToDouble(ib) * 1700;
												gvNewProducts.Rows[yuslim].Cells[5].Value = Convert.ToString(totalyusm);
												break;
											default:
												int yuslin = gvNewProducts.Rows.Add();
												gvNewProducts.Rows[yuslin].Cells[0].Value = datos[0];
												gvNewProducts.Rows[yuslin].Cells[1].Value = datos[1];
												gvNewProducts.Rows[yuslin].Cells[2].Value = datos[2];
												gvNewProducts.Rows[yuslin].Cells[3].Value = "0";
												gvNewProducts.Rows[yuslin].Cells[4].Value = ib;
												double totalyusn = Convert.ToDouble(ib) * 0;
												gvNewProducts.Rows[yuslin].Cells[5].Value = Convert.ToString(totalyusn);
												break;
										}
									}
									else
									{
										int yus = gvNewProducts.Rows.Add();
										gvNewProducts.Rows[yus].Cells[0].Value = datos[0];
										gvNewProducts.Rows[yus].Cells[1].Value = datos[1];
										gvNewProducts.Rows[yus].Cells[2].Value = datos[2];
										gvNewProducts.Rows[yus].Cells[3].Value = datos[3];
										gvNewProducts.Rows[yus].Cells[4].Value = ib;
										string precios = datos[3];
										double total = Convert.ToDouble(ib) * Convert.ToDouble(datos[3]);
										gvNewProducts.Rows[yus].Cells[5].Value = Convert.ToString(total);
									}
								}
								else
								{
									int yus = gvNewProducts.Rows.Add();
									gvNewProducts.Rows[yus].Cells[0].Value = datos[0];
									gvNewProducts.Rows[yus].Cells[1].Value = datos[1];
									gvNewProducts.Rows[yus].Cells[2].Value = datos[2];
									gvNewProducts.Rows[yus].Cells[3].Value = datos[3];
									gvNewProducts.Rows[yus].Cells[4].Value = ib;
									string precios = datos[3];
									double total = Convert.ToDouble(ib) * Convert.ToDouble(datos[3]);
									gvNewProducts.Rows[yus].Cells[5].Value = Convert.ToString(total);
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
      
        private Boolean siSePuedeAgg2(string idProducto)
        {
            Boolean res = true;


            return res;
        }

        private Boolean estaDisponibleProducto(string idProducto, string cantidad)
        {
            DataTable reservaciones = conexion.llenarVistas("select idReserva from Reserva where (fechaSalida between '" + fechaSalida + "' and '" + fechaRegreso + "' or " +
                " fechaRegreso between '" + fechaSalida + "' and '" + fechaRegreso + "') and estatus=1");

            string[] reserCercanas = reservaciones.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            int productoStock = Convert.ToInt32(conexion.getUnDato("select stock from Productos where idProductos =" + idProducto + " and estatus=1"));

            int stockEnUso = 0;
            for (int al = 0; al < reserCercanas.Length; al++)
            {

                DataTable detalleResId = conexion.llenarVistas("select idProductos from Detalle_Reserva where idReserva=" + reserCercanas[al]);
                string[] detalleReservacionId = detalleResId.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

                DataTable detalleResCant = conexion.llenarVistas("select cantidad from Detalle_Reserva where idReserva=" + reserCercanas[al]);
                string[] detalleReservacionCant = detalleResCant.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

                if (detalleReservacionId.Length == detalleReservacionCant.Length)
                {

                    for (int l = 0; l < detalleReservacionId.Length; l++)
                    {

                        if (detalleReservacionId[l].Equals(idProducto))
                        {
							stockEnUso = stockEnUso + Convert.ToInt32(detalleReservacionCant[l]);
						}
                    }
                }
                else
                {
                    stockEnUso = 0;
                    MessageBox.Show("Inconsistencia de datos consulte a uno de los programadores");
                }
            }
            int stockSolicitado = stockEnUso + Convert.ToInt32(cantidad);
            if (stockSolicitado > productoStock)
            {
                double sobrante = productoStock - stockEnUso;
                MessageBox.Show("No se cuenta con el stock suficiente \nStock existente disponible = " + Convert.ToString(sobrante), "Atencion");
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean validarStock(int stock, int cantidad)
        {
            if (cantidad > stock)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private Boolean validarId()
        {
            return true;
        }
        private Boolean validarDatos()
        {
            if (tbFolio.TextLength > 0  && tbDescripcion.TextLength > 0)
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
            int num_requeridos = gvNewProducts.Rows.Count - 1;
            for (int a = 0; a < num_requeridos; a++)
            {
                int renglon = a;
                int subtotal = 5;
                string totalProducto = gvNewProducts.Rows[renglon].Cells[subtotal].Value.ToString();
                total = total + Convert.ToDouble(totalProducto);
            }
            return total;
        }
        private void limpiarCotizacion()
        {
            tbSubTotal.Text = "0";
            tbDescuento.Text = "0";
            tbDeposito.Text = "0";
            tbTotal.Text = "";
            tbAnticipo.Text = "0";
            tbRestante.Text = "";
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
            validar.numerosEnteros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
        }

        private void tbDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
        }

        private void tbTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.numerosEnteros(e);
        }
        private void coti() {
            
            try
            {
                if (validarDatos())
                {
                    //double flete = Convert.ToInt32(tbFlete.Text);
                    double totalProductos = costoProductos();
                    tbSubTotal.Text = Convert.ToString(totalProductos + subtotal);
					bool fail = false;
					//totalInicio=to
					double descuento = 0;
                    //if (!cbCliente.Text.Equals("Cliente General "))
                    //{
                    //    descuento = Convert.ToDouble(tbNombreCliente.Text);
                    //}
                    double aDescontar = Convert.ToDouble(tbSubTotal.Text) / 100 * descuento;
                    double descuentoActual = 0;
                    if (tbDescuento.TextLength > 0)
                    {
                        descuentoActual = Convert.ToDouble(tbDescuento.Text);
                    }

                    if (tbTotal.TextLength > 0)
                    {
                        if (descuentoActual < Convert.ToDouble(tbSubTotal.Text))
                        {
                            if (!cbCliente.Text.Equals("Cliente General "))
                            {
                                //tbDescuento.Text = Convert.ToString(descuentoActual + aDescontar);
                                double total = Convert.ToDouble(tbSubTotal.Text) - Convert.ToDouble(tbDescuento.Text);
                                tbTotal.Text = Convert.ToString(total);
                            }
                            else
                            {

                                tbDescuento.Text = Convert.ToString(descuentoActual + aDescontar);
                                double total = Convert.ToDouble(tbSubTotal.Text) - Convert.ToDouble(tbDescuento.Text);
                                tbTotal.Text = Convert.ToString(total);

                            }

                        }
                        else
                        {
                            MessageBox.Show("El descuento no puede ser mayor al total de productos de la reservacion", "Atencion");
							tbDescuento.Text = "0";
							fail = true;
							double total = Convert.ToDouble(tbSubTotal.Text) + Convert.ToDouble(tbDeposito.Text) + Convert.ToDouble(tbFleteCosto.Text);
							tbTotal.Text = Convert.ToString(total);

							double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(restante);
						}
                    }
                    else
                    {
                        if (!cbCliente.Text.Equals("Cliente General "))
                        {
                            tbDescuento.Text = Convert.ToString(aDescontar);
                        }
                        double total = Convert.ToDouble(tbSubTotal.Text) - Convert.ToDouble(tbDescuento.Text);
                        tbTotal.Text = Convert.ToString(total);
                    }
					if (!fail)
					{
						double anticipo = 0;
						if (tbAnticipo.TextLength > 0)
						{
							anticipo = Convert.ToDouble(tbAnticipo.Text);
						}
						if (tbTotal.TextLength > 0)
						{
							if (anticipo <= Convert.ToDouble(tbTotal.Text))
							{
								//tbDescuento.Text = Convert.ToString(descuentoActual + aDescontar);
								double total = Convert.ToDouble(tbTotal.Text) - anticipo;
								tbRestante.Text = Convert.ToString(total);
							}
							else
							{
								MessageBox.Show("El anticipo no puede ser mayor al total de la reservacion", "Atencion");
							}
						}
						else
						{
							double total = Convert.ToDouble(tbSubTotal.Text) - Convert.ToDouble(tbDescuento.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(total);
							//tbRestante.Text = tbTotal.Text;
						}
						//MessageBox.Show(Convert.ToString(anticipo));
						double deposito = 0;
						if (tbDeposito.TextLength > 0)
						{
							deposito = Convert.ToDouble(tbDeposito.Text);
						}
						if (tbTotal.TextLength > 0)
						{

							double total2 = Convert.ToDouble(tbTotal.Text) + deposito;
							tbTotal.Text = Convert.ToString(total2);
							double fleteActual = Convert.ToDouble(tbFleteCosto.Text);
							if (fleteActual > fleteIncial)
							{
								double diferencia = fleteActual - fleteIncial;
								double total = Convert.ToDouble(tbTotal.Text);

								double totalNuevo = total + diferencia;

								tbTotal.Text = Convert.ToString(totalNuevo);
							}
							else if (fleteActual < fleteIncial)
							{
								double diferencia = fleteIncial - fleteActual;
								double total = Convert.ToDouble(tbTotal.Text);

								double totalNuevo = total - diferencia;

								tbTotal.Text = Convert.ToString(totalNuevo);
							}
							double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(restante);

						}
						else
						{
							double total2 = Convert.ToDouble(tbSubTotal.Text) - Convert.ToDouble(tbDescuento.Text) - Convert.ToDouble(tbAnticipo.Text) + Convert.ToDouble(tbDeposito.Text);
							tbTotal.Text = Convert.ToString(total2);

							double fleteActual = Convert.ToDouble(tbFleteCosto.Text);
							if (fleteActual > fleteIncial)
							{
								double diferencia = fleteActual - fleteIncial;
								double total = Convert.ToDouble(tbTotal.Text);

								double totalNuevo = total + diferencia;

								tbTotal.Text = Convert.ToString(totalNuevo);
							}
							else if (fleteActual < fleteIncial)
							{
								double diferencia = fleteIncial - fleteActual;
								double total = Convert.ToDouble(tbTotal.Text);

								double totalNuevo = total - diferencia;

								tbTotal.Text = Convert.ToString(totalNuevo);
							}

							double restante = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbAnticipo.Text);
							tbRestante.Text = Convert.ToString(restante);
							//tbRestante.Text = Convert.ToString(total);
						}
						//
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

        private void btnReservar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que quieres actualizar esta reservacion"
                , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes)
            {
                try
                {

					string texto = cbUbicacion.Text;
					int posicion = texto.IndexOf(" ");
					String substring = cbUbicacion.Text.Substring(0, posicion);
			
					int id = Convert.ToInt32(substring);

					string query = "update Reserva set idFlete=" + Convert.ToString(id) + ", nombre='"+cbCliente.Text +"' , descripcionUbicacion='" + tbDescripcion.Text + "' , telefono='" + tbCelular.Text +"' ,"+
                        "total=" + tbTotal.Text + " , descuento="+tbDescuento.Text+" , anticipo=" + tbAnticipo.Text + " , restante=" + tbRestante.Text + " , deposito=" + tbDeposito.Text + " , actualizacion='" + DateTime.Now.ToShortDateString() +
                        "', iva="+tbiva.Text+" where idReserva=" + tbFolio.Text;
                    conexion.ejecutar(query);
                    int num_requeridos = gvNewProducts.Rows.Count - 1;
                    string idReservacion = tbFolio.Text;
                    for (int a = 0; a < num_requeridos; a++)
                    {
                        int renglon = a;
                        string producto = gvNewProducts.Rows[renglon].Cells[0].Value.ToString();
                        string cantidad = gvNewProducts.Rows[renglon].Cells[4].Value.ToString();
                        string total = gvNewProducts.Rows[renglon].Cells[5].Value.ToString();
                        if (exiteEnLaReservacion(producto))
                        {
                           double cantidadActual = Convert.ToDouble(gvPedido.Rows[contadorProducto].Cells[3].Value.ToString());
                           double totalActual = Convert.ToDouble(gvPedido.Rows[contadorProducto].Cells[4].Value.ToString());
                            double nuevaCantidad = Convert.ToDouble(cantidad) + cantidadActual;
                            double nuevoTotal = Convert.ToDouble(total) + totalActual;
                            string q = "update Detalle_Reserva set cantidad="+Convert.ToString(nuevaCantidad) + " , total="+Convert.ToString(nuevoTotal)+" where idReserva="+tbFolio.Text+" and idProductos="+producto;
                            conexion.ejecutar(q);
                        }
                        else
                        {
                            string q = "insert into Detalle_Reserva values (" + idReservacion + "," + producto + "," + cantidad + "," + total + ")";
                            conexion.ejecutar(q);
                        }
                    }
                    MessageBox.Show("Cambios guardados con exito", "Nota");
                    verReservaciones l = new verReservaciones();
                    l.Show();
                    this.Close();
                    //Application.Restart();
                }
                catch
                {
                    MessageBox.Show("Hubo un error al guardar la reservacion \nContacte a uno de los programadores", "Atencion");
                }

            }
        }
        private Boolean exiteEnLaReservacion(string idProducto)
        {
            int num_requeridos = gvPedido.Rows.Count;
            Boolean res = false;
            int id = 0;
            for (int a = 0; a < num_requeridos; a++)
            {
                int renglon = a;
                if (idProducto.Equals(gvPedido.Rows[renglon].Cells[id].Value.ToString()))
                {
                    contadorProducto = renglon;
                    res = true;
                    break;
                }
            }
            return res;
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {

            coti();
            btnVerificar.BackColor = Color.White;
            btnVerificar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                int num_requeridos = gvNewProducts.Rows.Count - 1;
                for (int a = 0; a < num_requeridos; a++)
                {
                    int renglon = a;
                    int id = 0;
                    int nom = 1;
                    int precio = 3;
                    int cantidad = 4;
                    int subtotal = 5;
                    string idProducto = gvNewProducts.Rows[renglon].Cells[id].Value.ToString();
                    string nombre = gvNewProducts.Rows[renglon].Cells[nom].Value.ToString();
                    string precioProducto = gvNewProducts.Rows[renglon].Cells[precio].Value.ToString();
                    string cantidadNecesario = gvNewProducts.Rows[renglon].Cells[cantidad].Value.ToString();

                    if (estaDisponibleProducto(idProducto, cantidadNecesario))
                    {
                        double sub = Convert.ToDouble(precioProducto) * Convert.ToDouble(cantidadNecesario);
                        gvNewProducts.Rows[renglon].Cells[subtotal].Value = Convert.ToString(sub);
                    }
                    else
                    {
                        MessageBox.Show("No se cuenta con el stock suficiente del producto " + nombre, "Atencion");
                        gvNewProducts.Rows[renglon].Cells[cantidad].Value = "";
                        gvNewProducts.Rows[renglon].Cells[subtotal].Value = "";


                    }
                }

                btnActualizar.Enabled = false;
                btnActualizar.BackColor = Color.White;
                btnVerificar.Enabled = true;
                btnVerificar.BackColor = Color.White;
            }
            catch
            {
                MessageBox.Show("Verifique que ingreso la cantidad de todos los productos", "Atencion");

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que elimnar este producto de la reservacion"
              , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes)
            {
                try
                {
                    double subtotalactual = Convert.ToDouble(tbSubTotal.Text);
                    if (subtotalactual > totalInicioprogram)
                    {
                        double costo = Convert.ToDouble(gvNewProducts.Rows[gvNewProducts.CurrentRow.Index].Cells[5].Value.ToString());
                        tbSubTotal.Text = Convert.ToString(subtotalactual - costo);
                    }
                    gvNewProducts.Rows.Remove(gvNewProducts.CurrentRow);
                }
                catch {
                    MessageBox.Show("Error inesperado","Atencion");
                }
                
            }
        }

        private void tbSubTotal_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void tbDescuento_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void tbDeposito_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTotal_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void tbAnticipo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbRestante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que desea salir"
              , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes)
            {
                //this.Close();
                verReservaciones menu = new verReservaciones();
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

        private void btnReservar_MouseHover(object sender, EventArgs e)
        {
            btnReservar.BackColor = Color.LightGreen;
        }

        private void btnQuitar_MouseHover(object sender, EventArgs e)
        {
            btnQuitar.BackColor = Color.Tomato;
        }

        private void btnVerificar_MouseHover(object sender, EventArgs e)
        {
            btnVerificar.BackColor = Color.RoyalBlue;
        }

        private void btnReservar_MouseLeave(object sender, EventArgs e)
        {
            btnReservar.BackColor = Color.White;
        }

        private void btnVerificar_MouseLeave(object sender, EventArgs e)
        {
            btnVerificar.BackColor = Color.White;
        }

        private void btnQuitar_MouseLeave(object sender, EventArgs e)
        {
            btnVerificar.BackColor = Color.White;
        }

        private void gvNewProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnQuitar_MouseLeave_1(object sender, EventArgs e)
        {
            btnQuitar.BackColor = Color.White;
        }

        private void gvNewProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnVerificar.Enabled = true;
            btnVerificar.BackColor = Color.Yellow;
            //MessageBox.Show("se agrego");
        }

        private void gvNewProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvNewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            btnActualizar.BackColor = Color.Yellow;
        }

        private void tbDescuento_TextChanged(object sender, EventArgs e)
        {
            btnVerificar.Enabled = true;
            btnVerificar.BackColor = Color.Yellow;
        }

        private void tbDeposito_TextChanged(object sender, EventArgs e)
        {
            btnVerificar.Enabled = true;
            btnVerificar.BackColor = Color.Yellow;
        }

		private void rbivasi_CheckedChanged(object sender, EventArgs e)
		{
			double iva = Convert.ToDouble(tbTotal.Text) / 100 * 16;
			tbiva.Text = Convert.ToString(iva);
			double nuevTotal = Convert.ToDouble(tbiva.Text) + Convert.ToDouble(tbTotal.Text);
			tbTotal.Text = Convert.ToString(nuevTotal);
		}

		private void rbivano_CheckedChanged(object sender, EventArgs e)
		{
			tbiva.Text = "0";
		}

		private void rbNo_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rbNo_Click(object sender, EventArgs e)
		{
			double nuevTotal = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbiva.Text);
			tbTotal.Text = Convert.ToString(nuevTotal);
			double nuevrestante = Convert.ToDouble(tbRestante.Text) - Convert.ToDouble(tbiva.Text);
			tbRestante.Text = Convert.ToString(nuevrestante);
			tbiva.Text = "0";
		}

		private void rbivasi_Click(object sender, EventArgs e)
		{
			double iva = Convert.ToDouble(tbSubTotal.Text) / 100 * 16;
			double actualTotal = Convert.ToDouble(tbTotal.Text);
			double actualSub = Convert.ToDouble(tbSubTotal.Text);
			double esperado = actualSub + iva;
			if(actualTotal >= esperado)
			{
				MessageBox.Show("Ya se calculo y sumo el iva","Atencion");
			}
			else
			{
				tbiva.Text = Convert.ToString(iva);

				double nuevTotalfinal = Convert.ToDouble(tbTotal.Text) + iva;
				tbTotal.Text = Convert.ToString(nuevTotalfinal);

				double nuevRestante = Convert.ToDouble(tbRestante.Text) + iva;
				tbRestante.Text = Convert.ToString(nuevRestante);
			}
			//double nuevTotal = Convert.ToDouble(tbTotal.Text) - Convert.ToDouble(tbiva.Text);
			
		}

		private void tbCelular_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void tbCelular_KeyPress_1(object sender, KeyPressEventArgs e)
		{
			validar.numerosEnteros(e);
		}

		private void rbFlete_Click(object sender, EventArgs e)
		{
			btnVerificar.Enabled = true;
			btnVerificar.BackColor = Color.Yellow;
		}

	}
}
