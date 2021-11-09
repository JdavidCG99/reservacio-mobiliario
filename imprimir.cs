﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace Sistema_Reservaciones
{
    public partial class imprimir : Form
    {
        Conexion bdd = new Conexion();
        string id;
        public imprimir(string id)
        {
            InitializeComponent();
            this.id = id;
        }
		bool previo = false;
		string[] datosPrevios =  new string[14];
		DataTable productosPrevios;
		string ivaPrev;
		string[] idsp;
		string[] cantidades;
		string[] nombres;
		string[] precios;
		string[] totales;

		public imprimir(string id,string fechaReserva,string fechaSalida,string FechaRegreso,string nombre,string celular,
			string ubicacion,string precioFlete,string descripcion,string total,string anticipo,string restante,string deposito, string descuento
			,string iva,string[] idsp,string[] cantidades,string[] nombres,string[] precios,string[] totales)
		{
			InitializeComponent();
			datosPrevios[0] = id;
			datosPrevios[1] = fechaReserva;
			datosPrevios[2] = fechaSalida;
			datosPrevios[3] = FechaRegreso;
			datosPrevios[4] = nombre;
			datosPrevios[5] = celular;
			datosPrevios[6] = ubicacion;
			datosPrevios[7] = precioFlete;
			datosPrevios[8] = descripcion;
			datosPrevios[9] = total;
			datosPrevios[10] = anticipo;
			datosPrevios[11] = restante;
			datosPrevios[12] = deposito;
			datosPrevios[13] = descuento;
			ivaPrev = iva;
			//productosPrevios = productos;
			this.previo = true;
			this.idsp = idsp;
			this.cantidades = cantidades;
			this.nombres = nombres;
			this.precios = precios;
			this.totales = totales;
		}
        //public imprimir()
        //{
        //    InitializeComponent();

        //}

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ImprimirTickets = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                string nombreImpresora="";
                //string nombreImpresora= "Microsoft Print To PDF";
                //ps.PrinterName("Microsoft Print To PDF");
                ImprimirTickets.PrinterSettings = ps;
                if (rbTicket.Checked == true)
                {
                    nombreImpresora = "58 Printer";
                }
                else if (rbNota.Checked == true)
                {
                    nombreImpresora = "EPSON L3110 Series";
                }
                else
                {
                    nombreImpresora = "Microsoft Print To PDF";
                }
                ImprimirTickets.PrinterSettings.PrinterName = nombreImpresora;
                ImprimirTickets.PrintPage += ImprimirTickets_PrintPage;
                ImprimirTickets.Print();

            }
            catch
            {
                MessageBox.Show("Error al imprimir \nContacte con alguno de los desarrolladores", "Atencion");
            }

        }   

        private void ImprimirTickets_PrintPage(object sender, PrintPageEventArgs e)
        {
			if (!previo)
			{
				if (rbTicket.Checked == true)
				{
					ticket(id, e);
				}
				else if (rbNota.Checked == true)
				{
					nota(id, e);
				}
				else
				{
					nota(this.id, e);
				}
			}
			else
			{
				if (rbTicket.Checked == true)
				{
					ticketPrevio(e);
				}
				else if (rbNota.Checked == true)
				{
					notaPrevia(e);
				}
				else
				{
					notaPrevia(e);
				}
			}
           
            //mas grueso usar tamaño fuente 12
            //e.Graphics.DrawString("---------- Lolis rents ----------",font,Brushes.Black,new RectangleF(0,y+20,ancho,20));
        }

        private void ticket(string id, PrintPageEventArgs e) {
            string query = "select r.idReserva, r.fechaReserva,r.fechaSalida,r.fechaRegreso,r.nombre,r.telefono,f.ubicacion," +
               "f.Precio,r.descripcionUbicacion,r.total,r.anticipo,r.restante,r.deposito,r.descuento from Reserva as r inner join Flete as f " +
               "on r.idFlete=f.idFlete where r.idReserva=" + id;
            string[] datos = bdd.verInfoTicket(query);
            string folio = datos[0];
            string fechaReserva = datos[1];
            string fechaSalida = datos[2];
            string fechaRegreso = datos[3];
            string nombre = datos[4];
            string celular = datos[5];
            string ubicacion = datos[6];
            string precio = datos[7];
            string descripcion = datos[8];
            string total = datos[9];
            string anticipo = datos[10];
            string restante = datos[11];
            string deposito = datos[12];
            string descuento = datos[13];
			precio = Convert.ToString(bdd.getUnDato("select flete from Reserva where estatus=1 and idReserva=" + id));
			string iva = Convert.ToString(bdd.getUnDato("select iva from Reserva where estatus=1 and idReserva=" + id));
			Font font = new Font("Arial", 8);
            Font name = new Font("Brush Script MT", 30);
            StringFormat izquierda = new StringFormat();
            izquierda.Alignment = StringAlignment.Far;
            izquierda.LineAlignment = StringAlignment.Far;
            StringFormat centro = new StringFormat();
            centro.Alignment = StringAlignment.Center;
            centro.LineAlignment = StringAlignment.Center;
            int ancho = 200;
            int y = 20;
            int mi = 0;
            e.Graphics.DrawString("  Nota: " + folio + "      " + "Fecha:" + fechaReserva.Substring(0, 10), font, Brushes.Black, new RectangleF(0, y + 20, ancho, 20));
            e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 30, 250, 140));
            e.Graphics.DrawString(" Lolis Rent's", name, Brushes.Black, new RectangleF(0, y + 40, ancho, 100));
            e.Graphics.DrawString("Mobiliario para fiestas", font, Brushes.Black, new RectangleF(0, y + 80, ancho, 15), centro);
            e.Graphics.DrawString("Calle Escobedo #7 \nColonia Escobedo \nEldorado, Sinaloa \nTeléfono: 6677262275", font, Brushes.Black, new RectangleF(0, y + 100, ancho, 55));
            e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 145, 250, 20));
            y = -50;
            //e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 220, 250, 20));
            e.Graphics.DrawString("Cliente: " + nombre, font, Brushes.Black, new RectangleF(mi, y + 230, ancho, 20));
            e.Graphics.DrawString("Celular: " + celular, font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
            e.Graphics.DrawString("Ubicacion: " + ubicacion, font, Brushes.Black, new RectangleF(mi, y + 270, ancho, 20));
            e.Graphics.DrawString("Descripcion: " + descripcion, font, Brushes.Black, new RectangleF(mi, y + 290, ancho, 50));
           // e.Graphics.DrawString("Fecha evento: " + fecha, font, Brushes.Black, new RectangleF(mi, y + 342, ancho, 50));
            e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 330, 250, 20));
            e.Graphics.DrawString("Productos. ", font, Brushes.Black, new RectangleF(mi, y + 340, ancho, 10));
            DataTable ids = bdd.llenarVistas("select dr.idProductos from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] idsp = ids.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable nombrep = bdd.llenarVistas("select p.nombre from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] nombres = nombrep.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable preciop = bdd.llenarVistas("select p.precioVenta from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] precios = preciop.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable cantidadp = bdd.llenarVistas("select dr.cantidad from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] cantidades = cantidadp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable totalp = bdd.llenarVistas("select dr.total from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] totales = totalp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            y = y + 355;
            int subtotal = 0;
			e.Graphics.DrawString("Cant |  Producto             | P.unit |Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
			y = y + 12;
			for (int c = 0; c < idsp.Length; c++)
            {
                //e.Graphics.DrawString("Cant |  Producto             | P.unit |Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
                //y = y + 12;
                e.Graphics.DrawString(" " + cantidades[c] + "      " + nombres[c], font, Brushes.Black, new RectangleF(mi, y, ancho-70, 15));
                e.Graphics.DrawString(precios[c] + "    "+ totales[c], font, Brushes.Black, new RectangleF(mi+140, y, ancho-140, 15));
				y = y + 12;
                //e.Graphics.DrawString("P.unit  |  Cantidad    |  Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
                //y = y + 12;
                //e.Graphics.DrawString("  " + precios[c] + "           " + cantidades[c] + "               " + totales[c], font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
                //y = y + 12;
                subtotal = subtotal + Convert.ToInt32(totales[c]);
            }
            int anchoDinero = 185;
            e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y, 250, 20));
            e.Graphics.DrawString("Subtotal:   " + Convert.ToString(subtotal) + "  ", font, Brushes.Black, new RectangleF(mi, y + 15, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Flete:       " + precio + "  ", font, Brushes.Black, new RectangleF(mi, y + 30, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Iva:        " + iva + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
			y = y + 15;
			e.Graphics.DrawString("Deposito:     " + deposito + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Descuento: " + descuento + "  ", font, Brushes.Black, new RectangleF(mi, y + 60, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Total:  " + total + "  ", font, Brushes.Black, new RectangleF(mi, y + 75, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Anticipo:   " + anticipo + "  ", font, Brushes.Black, new RectangleF(mi, y + 90, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Restante:  " + restante + "  ", font, Brushes.Black, new RectangleF(mi, y + 105, anchoDinero, 20), izquierda);
            // e.Graphics.DrawString("------------- TICKET -------------", font, Brushes.Black, new RectangleF(0, y + 40, ancho, 20));
            e.Graphics.DrawString(
                              "Nota: El deposito será reembolsado al momento de devolver los productos en buen estado."
                              , font, Brushes.Black, new RectangleF(mi, y + 120, 195, 50), centro);
            e.Graphics.DrawString("Fecha de entrega.", font, Brushes.Black, new RectangleF(mi, y + 5, ancho, 15));
            e.Graphics.DrawString(" " + fechaSalida.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 20, ancho, 15));
            e.Graphics.DrawString("Fecha recoleccion.", font, Brushes.Black, new RectangleF(mi, y + 35, ancho, 20));
            e.Graphics.DrawString(" " + fechaRegreso.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 50, ancho, 20));
            e.Graphics.DrawString("             Estimado cliente.", font, Brushes.Black, new RectangleF(0, y + 165, ancho, 20));
            e.Graphics.DrawString(
                               "Favor de cuidar los manteles si presenta daños con silicón, " +
                               "quemaduras o pintura se cobrará el importe de mismo. \nEl deposito " +
                               "es para que regreses la mantelería al día siguiente del evento." +
                               "Sin excepción de personas. "
                               , font, Brushes.Black, new RectangleF(mi, y + 180, ancho, 160));
            e.Graphics.DrawString("     Por tu comprension gracias.", font, Brushes.Black, new RectangleF(0, y + 270, ancho, 20));
            e.Graphics.DrawString("            --------------------------------", font, Brushes.Black, new RectangleF(0, y + 300, ancho, 20));
            e.Graphics.DrawString("                  Firma del cliente.", font, Brushes.Black, new RectangleF(mi, y + 308, ancho, 20));


        }
        private void nota(string id,  PrintPageEventArgs e)
        {
            string query = "select r.idReserva, r.fechaReserva,r.fechaSalida,r.fechaRegreso,r.nombre,r.telefono,f.ubicacion," +
               "f.Precio,r.descripcionUbicacion,r.total,r.anticipo,r.restante,r.deposito,r.descuento from Reserva as r inner join Flete as f " +
               "on r.idFlete=f.idFlete where r.idReserva=" + id;
            string[] datos = bdd.verInfoTicket(query);
            string folio = datos[0];
            string fechaReserva = datos[1];
            string fechaSalida = datos[2];
            string fechaRegreso = datos[3];
            string nombre = datos[4];
            string celular = datos[5];
            string ubicacion = datos[6];
            string precio = datos[7];
            string descripcion = datos[8];
            string total = datos[9];
            string anticipo = datos[10];
            string restante = datos[11];
            string deposito = datos[12];
            string descuento = datos[13];
			precio = Convert.ToString(bdd.getUnDato("select flete from Reserva where estatus=1 and idReserva=" + id));
			string iva = Convert.ToString(bdd.getUnDato("select iva from Reserva where estatus=1 and idReserva=" + id));
			Font font = new Font("Arial", 10);
            Font subs = new Font("Arial", 12);
            Font name = new Font("Brush Script MT", 40);
            StringFormat izquierda = new StringFormat();
            izquierda.Alignment = StringAlignment.Far;
            izquierda.LineAlignment = StringAlignment.Far;
            StringFormat centro = new StringFormat();
            centro.Alignment = StringAlignment.Center;
            centro.LineAlignment = StringAlignment.Center;
            int ancho = 395;
            int y = 20;
            int mi = 200;
            int md = 200;
            Pen blackPen = new Pen(Color.Black, 1);
            //e.Graphics.DrawRectangle(blackPen,210,20,390,800);

            //e.Graphics.DrawString("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25", font, Brushes.Black, new RectangleF(md, y, ancho, 20));
            e.Graphics.DrawString("  Nota: " + folio, font, Brushes.Black, new RectangleF(md, y + 20, ancho, 20));
            e.Graphics.DrawString("Fecha:" + fechaReserva.Substring(0, 10), font, Brushes.Black, new RectangleF(md+275, y + 20, ancho, 20));
            int p2l = mi + ancho;
            e.Graphics.DrawLine(blackPen, mi, y + 40, p2l, y + 40);
            //e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 30, ancho, 140));
            e.Graphics.DrawString("Lolis Rent's", name, Brushes.Black, new RectangleF(md, y + 40, ancho, 50));
            e.Graphics.DrawString("        Mobiliario para fiestas", subs, Brushes.Black, new RectangleF(md, y + 95, ancho, 20));
            e.Graphics.DrawString("Calle Escobedo #7 \nColonia Escobedo \nEldorado, Sinaloa \nTeléfono: 6677262275", font, Brushes.Black, new RectangleF(md, y + 40, ancho, 75), izquierda);
            //e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 145, 250, 20));
            e.Graphics.DrawLine(blackPen, mi, y + 125, p2l, y + 125);
            y = -100;
            //e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 220, 250, 20));
            e.Graphics.DrawString("Cliente: " + nombre + "      Celular: " + celular, font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
            //e.Graphics.DrawString("Celular: " + celular, font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
            e.Graphics.DrawString("Ubicacion: " + ubicacion ,font, Brushes.Black, new RectangleF(mi, y + 270, ancho, 40));
            e.Graphics.DrawString("Descripcion: " + descripcion, font, Brushes.Black, new RectangleF(mi, y + 290, ancho, 50));
            e.Graphics.DrawLine(blackPen, mi, y + 340, p2l, y + 340);
            //e.Graphics.DrawString("Fecha evento: " + fecha, font, Brushes.Black, new RectangleF(mi, y + 340, ancho, 50));
            //e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 353, 250, 20));
            //e.Graphics.DrawString("Productos. ", subs, Brushes.Black, new RectangleF(mi, y + 345, ancho, 20));
            DataTable ids = bdd.llenarVistas("select dr.idProductos from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] idsp = ids.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable nombrep = bdd.llenarVistas("select p.nombre from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] nombres = nombrep.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable preciop = bdd.llenarVistas("select p.precioVenta from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] precios = preciop.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable cantidadp = bdd.llenarVistas("select dr.cantidad from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] cantidades = cantidadp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            DataTable totalp = bdd.llenarVistas("select dr.total from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
            string[] totales = totalp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            y = y + 345;
            int subtotal = 0;
			//e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(md, y, 395, 20));
			//y = y + 13;
			e.Graphics.DrawString("Cant.|  Producto                                                  | P.unit | Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
			y = y + 13;
			for (int c = 0; c < idsp.Length; c++)
            {
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(md, y, 395, 20));
                y = y + 13;
                //e.Graphics.DrawString("Id. |  Producto                                           | P.unit | Cant. | Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
                //y = y + 13;
                //e.Graphics.DrawString(" " + idsp[c] + "     " + nombres[c]+ "  " + precios[c] + "           " + cantidades[c] + "               " + totales[c], font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
                e.Graphics.DrawString(cantidades[c], font, Brushes.Black, new RectangleF(mi+5, y, 45, 15));
                e.Graphics.DrawString(nombres[c], font, Brushes.Black, new RectangleF(mi + 45, y, 255, 15));
                e.Graphics.DrawString(precios[c], font, Brushes.Black, new RectangleF(mi + 310, y, 50, 15));
                //e.Graphics.DrawString(cantidades[c], font, Brushes.Black, new RectangleF(mi + 310, y, 50, 15));
                e.Graphics.DrawString(totales[c], font, Brushes.Black, new RectangleF(mi + 350, y, 50, 15));
                y = y + 10;
                //e.Graphics.DrawString("P.unit  |  Cantidad    |  Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
                //y = y + 15;
                //e.Graphics.DrawString("  " + precios[c] + "           " + cantidades[c] + "               " + totales[c], font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
                //y = y + 15;
                subtotal = subtotal + Convert.ToInt32(totales[c]);
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(md, y, ancho, 20));
            //y = y + 13;
            int anchoDinero = 380;
            //e.Graphics.DrawLine(blackPen, mi, y + 125, p2l, y + 125);
            e.Graphics.DrawString("Subtotal:    " + Convert.ToString(subtotal) + "  ", font, Brushes.Black, new RectangleF(mi, y + 15, anchoDinero, 20),izquierda);
            e.Graphics.DrawString("Flete:         " + precio + "  ", font, Brushes.Black, new RectangleF(mi, y + 30, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Iva:       " + iva + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
			y = y + 15;
			e.Graphics.DrawString("Deposito:       " + deposito + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Descuento:      " + descuento + "  ", font, Brushes.Black, new RectangleF(mi, y + 60, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Total:   " + total + "  ", font, Brushes.Black, new RectangleF(mi, y + 75, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Anticipo:      " + anticipo + "  ", font, Brushes.Black, new RectangleF(mi, y + 90, anchoDinero, 20), izquierda);
            e.Graphics.DrawString("Restante:   " + restante + "  ", font, Brushes.Black, new RectangleF(mi, y + 105, anchoDinero, 20), izquierda);
            // e.Graphics.DrawString("------------- TICKET -------------", font, Brushes.Black, new RectangleF(0, y + 40, ancho, 20));
            e.Graphics.DrawString(
                              "Nota: El deposito será reembolsado al momento de devolver los productos sin daños y al dia siguiente del evento."
                              , font, Brushes.Black, new RectangleF(mi, y + 118, ancho, 50), centro);
            e.Graphics.DrawString("Fecha del evento: " + fechaSalida.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 20, ancho, 15));

            e.Graphics.DrawString("Fecha de recoleccion: " + fechaRegreso.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 35, ancho, 20));
            e.Graphics.DrawString("                                      Estimado cliente.", font, Brushes.Black, new RectangleF(md, y + 160, ancho, 20));
            e.Graphics.DrawString(
                               "Favor de cuidar los manteles si presenta daños con silicón, " +
                               "quemaduras o pintura se cobrará el importe de mismo."
                               , font, Brushes.Black, new RectangleF(mi, y + 110, ancho, 160), centro);
            e.Graphics.DrawString("                                Por tu comprension gracias.", font, Brushes.Black, new RectangleF(md, y + 205, ancho, 20));
            e.Graphics.DrawString("                                  --------------------------------", font, Brushes.Black, new RectangleF(md, y + 240, ancho, 20));
            e.Graphics.DrawString("                                        Firma del cliente.", font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
            e.Graphics.DrawString(
                               "Acepto haber recibido el material completo y en buen estado."
                               , font, Brushes.Black, new RectangleF(mi, y + 200, ancho, 160), centro);
        }
		private void ticketPrevio(PrintPageEventArgs e)
		{
			//string query = "select r.idReserva, r.fechaReserva,r.fechaSalida,r.fechaRegreso,r.nombre,r.telefono,f.ubicacion," +
			//   "f.Precio,r.descripcionUbicacion,r.total,r.anticipo,r.restante,r.deposito,r.descuento from Reserva as r inner join Flete as f " +
			//   "on r.idFlete=f.idFlete where r.idReserva=" + id;
			//string[] datos = bdd.verInfoTicket(query);
			string[] datos = this.datosPrevios;
			string folio = datos[0];
			string fechaReserva = datos[1];
			string fechaSalida = datos[2];
			string fechaRegreso = datos[3];
			string nombre = datos[4];
			string celular = datos[5];
			string ubicacion = datos[6];
			string precio = datos[7];
			string descripcion = datos[8];
			string total = datos[9];
			string anticipo = datos[10];
			string restante = datos[11];
			string deposito = datos[12];
			string descuento = datos[13];
			//precio = Convert.ToString(bdd.getUnDato("select flete from Reserva where estatus=1 and idReserva=" + id));
			//string iva = Convert.ToString(bdd.getUnDato("select iva from Reserva where estatus=1 and idReserva=" + id));
			string iva = this.ivaPrev;
			Font font = new Font("Arial", 8);
			Font name = new Font("Brush Script MT", 30);
			StringFormat izquierda = new StringFormat();
			izquierda.Alignment = StringAlignment.Far;
			izquierda.LineAlignment = StringAlignment.Far;
			StringFormat centro = new StringFormat();
			centro.Alignment = StringAlignment.Center;
			centro.LineAlignment = StringAlignment.Center;
			int ancho = 200;
			int y = 20;
			int mi = 0;
			e.Graphics.DrawString("  Nota: " + folio + "      " + "Fecha:" + fechaReserva.Substring(0, 10), font, Brushes.Black, new RectangleF(0, y + 20, ancho, 20));
			e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 30, 250, 140));
			e.Graphics.DrawString(" Lolis Rent's", name, Brushes.Black, new RectangleF(0, y + 40, ancho, 100));
			e.Graphics.DrawString("Mobiliario para fiestas", font, Brushes.Black, new RectangleF(0, y + 80, ancho, 15), centro);
			e.Graphics.DrawString("Calle Escobedo #7 \nColonia Escobedo \nEldorado, Sinaloa \nTeléfono: 6677262275", font, Brushes.Black, new RectangleF(0, y + 100, ancho, 55));
			e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 145, 250, 20));
			y = -50;
			//e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 220, 250, 20));
			e.Graphics.DrawString("Cliente: " + nombre, font, Brushes.Black, new RectangleF(mi, y + 230, ancho, 20));
			e.Graphics.DrawString("Celular: " + celular, font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
			e.Graphics.DrawString("Ubicacion: " + ubicacion, font, Brushes.Black, new RectangleF(mi, y + 270, ancho, 20));
			e.Graphics.DrawString("Descripcion: " + descripcion, font, Brushes.Black, new RectangleF(mi, y + 290, ancho, 50));
			// e.Graphics.DrawString("Fecha evento: " + fecha, font, Brushes.Black, new RectangleF(mi, y + 342, ancho, 50));
			e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 330, 250, 20));
			e.Graphics.DrawString("Productos. ", font, Brushes.Black, new RectangleF(mi, y + 340, ancho, 10));

			//string[] idsp = productosPrevios.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//string[] nombres = productosPrevios.Rows.OfType<DataRow>().Select(k => k[1].ToString()).ToArray();
			//string[] precios = productosPrevios.Rows.OfType<DataRow>().Select(k => k[3].ToString()).ToArray();
			//string[] cantidades = productosPrevios.Rows.OfType<DataRow>().Select(k => k[4].ToString()).ToArray();
			//string[] totales = productosPrevios.Rows.OfType<DataRow>().Select(k => k[5].ToString()).ToArray();
			//DataTable ids = bdd.llenarVistas("select dr.idProductos from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] idsp = ids.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable nombrep = bdd.llenarVistas("select p.nombre from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] nombres = nombrep.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable preciop = bdd.llenarVistas("select p.precioVenta from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] precios = preciop.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable cantidadp = bdd.llenarVistas("select dr.cantidad from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] cantidades = cantidadp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable totalp = bdd.llenarVistas("select dr.total from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] totales = totalp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

			y = y + 355;
			int subtotal = 0;
			e.Graphics.DrawString("Cant |  Producto             | P.unit |Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
			y = y + 12;
			for (int c = 0; c < idsp.Length-1; c++)
			{
				//e.Graphics.DrawString("Cant |  Producto             | P.unit |Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
				//y = y + 12;
				e.Graphics.DrawString(" " + cantidades[c] + "      " + nombres[c], font, Brushes.Black, new RectangleF(mi, y, ancho - 70, 15));
				e.Graphics.DrawString(precios[c] + "    " + totales[c], font, Brushes.Black, new RectangleF(mi + 140, y, ancho - 140, 15));
				y = y + 12;
				//e.Graphics.DrawString("P.unit  |  Cantidad    |  Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
				//y = y + 12;
				//e.Graphics.DrawString("  " + precios[c] + "           " + cantidades[c] + "               " + totales[c], font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
				//y = y + 12;
				subtotal = subtotal + Convert.ToInt32(totales[c]);
			}
			int anchoDinero = 185;
			e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y, 250, 20));
			e.Graphics.DrawString("Subtotal:   " + Convert.ToString(subtotal) + "  ", font, Brushes.Black, new RectangleF(mi, y + 15, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Flete:       " + precio + "  ", font, Brushes.Black, new RectangleF(mi, y + 30, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Iva:        " + iva + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
			y = y + 15;
			e.Graphics.DrawString("Deposito:     " + deposito + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Descuento: " + descuento + "  ", font, Brushes.Black, new RectangleF(mi, y + 60, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Total:  " + total + "  ", font, Brushes.Black, new RectangleF(mi, y + 75, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Anticipo:   " + anticipo + "  ", font, Brushes.Black, new RectangleF(mi, y + 90, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Restante:  " + restante + "  ", font, Brushes.Black, new RectangleF(mi, y + 105, anchoDinero, 20), izquierda);
			// e.Graphics.DrawString("------------- TICKET -------------", font, Brushes.Black, new RectangleF(0, y + 40, ancho, 20));
			e.Graphics.DrawString(
							  "Nota: El deposito será reembolsado al momento de devolver los productos en buen estado."
							  , font, Brushes.Black, new RectangleF(mi, y + 120, 195, 50), centro);
			e.Graphics.DrawString("Fecha de entrega.", font, Brushes.Black, new RectangleF(mi, y + 5, ancho, 15));
			e.Graphics.DrawString(" " + fechaSalida.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 20, ancho, 15));
			e.Graphics.DrawString("Fecha recoleccion.", font, Brushes.Black, new RectangleF(mi, y + 35, ancho, 20));
			e.Graphics.DrawString(" " + fechaRegreso.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 50, ancho, 20));
			e.Graphics.DrawString("             Estimado cliente.", font, Brushes.Black, new RectangleF(0, y + 165, ancho, 20));
			e.Graphics.DrawString(
							   "Favor de cuidar los manteles si presenta daños con silicón, " +
							   "quemaduras o pintura se cobrará el importe de mismo. \nEl deposito " +
							   "es para que regreses la mantelería al día siguiente del evento." +
							   "Sin excepción de personas. "
							   , font, Brushes.Black, new RectangleF(mi, y + 180, ancho, 160));
			e.Graphics.DrawString("     Por tu comprension gracias.", font, Brushes.Black, new RectangleF(0, y + 270, ancho, 20));
			e.Graphics.DrawString("            --------------------------------", font, Brushes.Black, new RectangleF(0, y + 300, ancho, 20));
			e.Graphics.DrawString("                  Firma del cliente.", font, Brushes.Black, new RectangleF(mi, y + 308, ancho, 20));


		}
		private void notaPrevia(PrintPageEventArgs e)
		{
			//string query = "select r.idReserva, r.fechaReserva,r.fechaSalida,r.fechaRegreso,r.nombre,r.telefono,f.ubicacion," +
			//   "f.Precio,r.descripcionUbicacion,r.total,r.anticipo,r.restante,r.deposito,r.descuento from Reserva as r inner join Flete as f " +
			//   "on r.idFlete=f.idFlete where r.idReserva=" + id;
			//string[] datos = bdd.verInfoTicket(query);
			string[] datos = datosPrevios;
			string folio = datos[0];
			string fechaReserva = datos[1];
			string fechaSalida = datos[2];
			string fechaRegreso = datos[3];
			string nombre = datos[4];
			string celular = datos[5];
			string ubicacion = datos[6];
			string precio = datos[7];
			string descripcion = datos[8];
			string total = datos[9];
			string anticipo = datos[10];
			string restante = datos[11];
			string deposito = datos[12];
			string descuento = datos[13];
			//precio = Convert.ToString(bdd.getUnDato("select flete from Reserva where estatus=1 and idReserva=" + id));
			//string iva = Convert.ToString(bdd.getUnDato("select iva from Reserva where estatus=1 and idReserva=" + id));
			string iva = this.ivaPrev;
			Font font = new Font("Arial", 10);
			Font subs = new Font("Arial", 12);
			Font name = new Font("Brush Script MT", 40);
			StringFormat izquierda = new StringFormat();
			izquierda.Alignment = StringAlignment.Far;
			izquierda.LineAlignment = StringAlignment.Far;
			StringFormat centro = new StringFormat();
			centro.Alignment = StringAlignment.Center;
			centro.LineAlignment = StringAlignment.Center;
			int ancho = 395;
			int y = 20;
			int mi = 200;
			int md = 200;
			Pen blackPen = new Pen(Color.Black, 1);
			//e.Graphics.DrawRectangle(blackPen,210,20,390,800);

			//e.Graphics.DrawString("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25", font, Brushes.Black, new RectangleF(md, y, ancho, 20));
			e.Graphics.DrawString("  Nota: " + folio, font, Brushes.Black, new RectangleF(md, y + 20, ancho, 20));
			e.Graphics.DrawString("Fecha:" + fechaReserva.Substring(0, 10), font, Brushes.Black, new RectangleF(md + 275, y + 20, ancho, 20));
			int p2l = mi + ancho;
			e.Graphics.DrawLine(blackPen, mi, y + 40, p2l, y + 40);
			//e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 30, ancho, 140));
			e.Graphics.DrawString("Lolis Rent's", name, Brushes.Black, new RectangleF(md, y + 40, ancho, 50));
			e.Graphics.DrawString("        Mobiliario para fiestas", subs, Brushes.Black, new RectangleF(md, y + 95, ancho, 20));
			e.Graphics.DrawString("Calle Escobedo #7 \nColonia Escobedo \nEldorado, Sinaloa \nTeléfono: 6677262275", font, Brushes.Black, new RectangleF(md, y + 40, ancho, 75), izquierda);
			//e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 145, 250, 20));
			e.Graphics.DrawLine(blackPen, mi, y + 125, p2l, y + 125);
			y = -100;
			//e.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 220, 250, 20));
			e.Graphics.DrawString("Cliente: " + nombre + "      Celular: " + celular, font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
			//e.Graphics.DrawString("Celular: " + celular, font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
			e.Graphics.DrawString("Ubicacion: " + ubicacion, font, Brushes.Black, new RectangleF(mi, y + 270, ancho, 40));
			e.Graphics.DrawString("Descripcion: " + descripcion, font, Brushes.Black, new RectangleF(mi, y + 290, ancho, 50));
			e.Graphics.DrawLine(blackPen, mi, y + 340, p2l, y + 340);
			//e.Graphics.DrawString("Fecha evento: " + fecha, font, Brushes.Black, new RectangleF(mi, y + 340, ancho, 50));
			//e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y + 353, 250, 20));
			//e.Graphics.DrawString("Productos. ", subs, Brushes.Black, new RectangleF(mi, y + 345, ancho, 20));
			//DataTable ids = bdd.llenarVistas("select dr.idProductos from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] idsp = ids.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable nombrep = bdd.llenarVistas("select p.nombre from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] nombres = nombrep.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable preciop = bdd.llenarVistas("select p.precioVenta from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] precios = preciop.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable cantidadp = bdd.llenarVistas("select dr.cantidad from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] cantidades = cantidadp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//DataTable totalp = bdd.llenarVistas("select dr.total from Detalle_Reserva as dr inner join Productos as p on dr.idProductos=p.idProductos where idReserva=" + id + " and cantidad>0");
			//string[] totales = totalp.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//string[] idsp = productosPrevios.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
			//string[] nombres = productosPrevios.Rows.OfType<DataRow>().Select(k => k[1].ToString()).ToArray();
			//string[] precios = productosPrevios.Rows.OfType<DataRow>().Select(k => k[3].ToString()).ToArray();
			//string[] cantidades = productosPrevios.Rows.OfType<DataRow>().Select(k => k[4].ToString()).ToArray();
			//string[] totales = productosPrevios.Rows.OfType<DataRow>().Select(k => k[5].ToString()).ToArray();
			y = y + 345;
			int subtotal = 0;
			//e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(md, y, 395, 20));
			//y = y + 13;
			e.Graphics.DrawString("Cant.|  Producto                                                  | P.unit | Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
			y = y + 13;
			for (int c = 0; c < idsp.Length-1; c++)
			{
				e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(md, y, 395, 20));
				y = y + 13;
				//e.Graphics.DrawString("Id. |  Producto                                           | P.unit | Cant. | Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
				//y = y + 13;
				//e.Graphics.DrawString(" " + idsp[c] + "     " + nombres[c]+ "  " + precios[c] + "           " + cantidades[c] + "               " + totales[c], font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
				e.Graphics.DrawString(cantidades[c], font, Brushes.Black, new RectangleF(mi + 5, y, 45, 15));
				e.Graphics.DrawString(nombres[c], font, Brushes.Black, new RectangleF(mi + 45, y, 255, 15));
				e.Graphics.DrawString(precios[c], font, Brushes.Black, new RectangleF(mi + 310, y, 50, 15));
				//e.Graphics.DrawString(cantidades[c], font, Brushes.Black, new RectangleF(mi + 310, y, 50, 15));
				e.Graphics.DrawString(totales[c], font, Brushes.Black, new RectangleF(mi + 350, y, 50, 15));
				y = y + 10;
				//e.Graphics.DrawString("P.unit  |  Cantidad    |  Total", font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
				//y = y + 15;
				//e.Graphics.DrawString("  " + precios[c] + "           " + cantidades[c] + "               " + totales[c], font, Brushes.Black, new RectangleF(mi, y, ancho, 15));
				//y = y + 15;
				subtotal = subtotal + Convert.ToInt32(totales[c]);
			}
			e.Graphics.DrawString("-------------------------------------------------------------------------------------------", font, Brushes.Black, new RectangleF(md, y, ancho, 20));
			//y = y + 13;
			int anchoDinero = 380;
			//e.Graphics.DrawLine(blackPen, mi, y + 125, p2l, y + 125);
			e.Graphics.DrawString("Subtotal:    " + Convert.ToString(subtotal) + "  ", font, Brushes.Black, new RectangleF(mi, y + 15, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Flete:         " + precio + "  ", font, Brushes.Black, new RectangleF(mi, y + 30, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Iva:       " + iva + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
			y = y + 15;
			e.Graphics.DrawString("Deposito:       " + deposito + "  ", font, Brushes.Black, new RectangleF(mi, y + 45, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Descuento:      " + descuento + "  ", font, Brushes.Black, new RectangleF(mi, y + 60, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Total:   " + total + "  ", font, Brushes.Black, new RectangleF(mi, y + 75, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Anticipo:      " + anticipo + "  ", font, Brushes.Black, new RectangleF(mi, y + 90, anchoDinero, 20), izquierda);
			e.Graphics.DrawString("Restante:   " + restante + "  ", font, Brushes.Black, new RectangleF(mi, y + 105, anchoDinero, 20), izquierda);
			// e.Graphics.DrawString("------------- TICKET -------------", font, Brushes.Black, new RectangleF(0, y + 40, ancho, 20));
			e.Graphics.DrawString(
							  "Nota: El deposito será reembolsado al momento de devolver los productos sin daños y al dia siguiente del evento."
							  , font, Brushes.Black, new RectangleF(mi, y + 118, ancho, 50), centro);
			e.Graphics.DrawString("Fecha del evento: " + fechaSalida.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 20, ancho, 15));

			e.Graphics.DrawString("Fecha de recoleccion: " + fechaRegreso.Substring(0, 10), font, Brushes.Black, new RectangleF(mi, y + 35, ancho, 20));
			e.Graphics.DrawString("                                      Estimado cliente.", font, Brushes.Black, new RectangleF(md, y + 160, ancho, 20));
			e.Graphics.DrawString(
							   "Favor de cuidar los manteles si presenta daños con silicón, " +
							   "quemaduras o pintura se cobrará el importe de mismo."
							   , font, Brushes.Black, new RectangleF(mi, y + 110, ancho, 160), centro);
			e.Graphics.DrawString("                                Por tu comprension gracias.", font, Brushes.Black, new RectangleF(md, y + 205, ancho, 20));
			e.Graphics.DrawString("                                  --------------------------------", font, Brushes.Black, new RectangleF(md, y + 240, ancho, 20));
			e.Graphics.DrawString("                                        Firma del cliente.", font, Brushes.Black, new RectangleF(mi, y + 250, ancho, 20));
			e.Graphics.DrawString(
							   "Acepto haber recibido el material completo y en buen estado."
							   , font, Brushes.Black, new RectangleF(mi, y + 200, ancho, 160), centro);
		}
		private void imprimir_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BackColor = Color.RoyalBlue;

        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BackColor = Color.White;
        }

		private void rbTicket_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
