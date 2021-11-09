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
    public partial class ganancia : Form
    {
        Conexion conexion = new Conexion();
        Validaciones validaciones = new Validaciones();
        public ganancia()
        {
            InitializeComponent();
		}

        private void dtpInical_ValueChanged(object sender, EventArgs e)
        {
			

			chartGanancia.Series[0].Points.Clear();
            //txtGanciaReal.Text = "";
            //txtLuz.Text = "";
            //txtAgua.Text = "";
            //txtEmpleados.Text = "";
            //txtContador.Text = "";
            //txtGasolina.Text = "";
            //txtGastos.Text = "";

            DataTable dt = new DataTable();

            //String query = "select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' , convert(varchar,fecha) AS 'Fecha' from abonos inner join Reserva on Reserva.idReserva = abonos.idReserva where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "' and Reserva.estatus = 1 group by fecha";
            String query = "select Sum(convert(numeric(10, 2), (ganacia))) AS 'Ganancia' , convert(varchar, fecha) AS 'Fecha' from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "' group by fecha";
            dt = conexion.grafica(query);
            int noFilas = dt.Rows.Count;
            decimal gananciaTotal = 0;

            for(int i = 0; i <= noFilas - 1; i++)
            {
                chartGanancia.Series["Fecha"].Points.AddXY(dt.Rows[i][Convert.ToString("Fecha")], dt.Rows[i]["Ganancia"]);
                gananciaTotal = gananciaTotal + Convert.ToDecimal(dt.Rows[i]["Ganancia"]);
            }
            txtTotal.Text = Convert.ToString(gananciaTotal);
			string entrada = conexion.getUnDato("select Sum(convert(numeric(10, 2), (entrada)))  from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'");

			if (entrada.Equals(""))
			{
				entrada = "0";
			}
			tbEntrada.Text = entrada;

			string salida = conexion.getUnDato("select Sum(convert(numeric(10, 2), (salidas)))  from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'");
			if (salida.Equals(""))
			{
				salida = "0";
			}
			tbSalidas.Text = salida;

			string query3 = "select costo as Importe,descripcion as Categoria,info as Descripcion from gastos where (fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and descripcion != 'Depositos' and fecha != '" + DateTime.Now + "'";
			//string query3 = "select costo as Importe,descripcion as Categoria,info as Descripcion from gastos where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'";
			dggastos.DataSource = conexion.llenarVistas(query3);
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad from abonos as a inner join Reserva r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and convert(numeric(10, 2), (a.cantidad)) > 0 and a.fecha != '" + DateTime.Now + "'";
			dgabonos.DataSource = conexion.llenarVistas(query2);

			//string query9 = "select costo as Cantidad,fecha as Fecha,info as Descripcion from gastos where descripcion = 'depositos' and fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'";
			//dvDespositos.DataSource = conexion.llenarVistas(query9);
		}

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            chartGanancia.Series[0].Points.Clear();
            //txtGanciaReal.Text = "";
            //txtLuz.Text = "";
            //txtAgua.Text = "";
            //txtEmpleados.Text = "";
            //txtContador.Text = "";
            //txtGasolina.Text = "";
            //txtGastos.Text = "";

            DataTable dt = new DataTable();

            //String query = "select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' , convert(varchar,fecha) AS 'Fecha' from abonos inner join Reserva on Reserva.idReserva = abonos.idReserva where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "' and Reserva.estatus = 1 group by fecha";
            String query = "select Sum(convert(numeric(10, 2), (ganacia))) AS 'Ganancia' , convert(varchar, fecha) AS 'Fecha' from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "' group by fecha";
            dt = conexion.grafica(query);
            int noFilas = dt.Rows.Count;
            decimal gananciaTotal = 0;

            for (int i = 0; i <= noFilas - 1; i++)
            {
                chartGanancia.Series["Fecha"].Points.AddXY(dt.Rows[i][Convert.ToString("Fecha")], dt.Rows[i]["Ganancia"]);
                gananciaTotal = gananciaTotal + Convert.ToDecimal(dt.Rows[i]["Ganancia"]);
            }
            txtTotal.Text = Convert.ToString(gananciaTotal);
			string entrada = conexion.getUnDato("select Sum(convert(numeric(10, 2), (entrada)))  from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'");

			if (entrada.Equals(""))
			{
				entrada = "0";
			}
			tbEntrada.Text = entrada;

			string salida = conexion.getUnDato("select Sum(convert(numeric(10, 2), (salidas)))  from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'");
			if (salida.Equals(""))
			{
				salida = "0";
			}
			tbSalidas.Text = salida;

			string query3 = "select costo as Importe,descripcion as Categoria,info as Descripcion from gastos where (fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and descripcion != 'Depositos' and fecha != '" + DateTime.Now +"'";
			//string query3 = "select costo as Importe,descripcion as Categoria,info as Descripcion from gastos where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'";
			dggastos.DataSource = conexion.llenarVistas(query3);
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad from abonos as a inner join Reserva r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and convert(numeric(10, 2), (a.cantidad)) > 0 and a.fecha != '" + DateTime.Now + "'";
			dgabonos.DataSource = conexion.llenarVistas(query2);

			//string query9 = "select costo as Cantidad,fecha as Fecha,info as Descripcion from gastos where descripcion = 'depositos' and fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'";
			//dvDespositos.DataSource = conexion.llenarVistas(query9);

		}

        private void ganancia_Load(object sender, EventArgs e)
        {
			//entrada2 dinero que entro en el dia
			//gastos dinero gastado en el dia
			//gananciareal dinero que entro en el dia menos los gastos
			//numero de reservaciones echas ver cuales son
			dtpFinal.Value = DateTime.Now;

			DateTime nuevaFecha = DateTime.Now;
			nuevaFecha = nuevaFecha.AddDays(-15);
			dtpInical.Value = nuevaFecha;


			//chartGanancia.Series[0].Points.Clear();
           
			////txtGanciaReal.Text = "";
			////txtLuz.Text = "";
			////txtAgua.Text = "";
			////txtEmpleados.Text = "";
			////txtContador.Text = "";
			////txtGasolina.Text = "";
			////txtGastos.Text = "";

			//DataTable dt = new DataTable();

   //         //String query = "select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' , convert(varchar,fecha) AS 'Fecha' from abonos inner join Reserva on Reserva.idReserva = abonos.idReserva where fecha between '" + dtpInical.Text+"' and '"+dtpFinal.Text+"' and Reserva.estatus = 1 group by fecha";
   //         String query = "select Sum(convert(numeric(10, 2), (ganacia))) AS 'Ganancia' , convert(varchar, fecha) AS 'Fecha' from cortes  where fecha between '"+dtpInical.Text+"' and '"+dtpFinal.Text+"' group by fecha";

   //         dt = conexion.grafica(query);
   //         int noFilas = dt.Rows.Count;
   //         decimal gananciaTotal = 0;

   //         for (int i = 0; i <= noFilas - 1; i++)
   //         {
   //             chartGanancia.Series["Fecha"].Points.AddXY(dt.Rows[i][Convert.ToString("Fecha")], dt.Rows[i]["Ganancia"]);
   //             gananciaTotal = gananciaTotal + Convert.ToDecimal(dt.Rows[i]["Ganancia"]);
   //         }
   //         txtTotal.Text = Convert.ToString(gananciaTotal);

			//string entrada = conexion.getUnDato("select Sum(convert(numeric(10, 2), (entrada)))  from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'");
			
			//if (entrada.Equals(""))
			//{
			//	entrada = "0";
			//}
			//tbEntrada.Text = entrada;

			//string salida = conexion.getUnDato("select Sum(convert(numeric(10, 2), (salidas)))  from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'");
			//if (salida.Equals(""))
			//{
			//	salida = "0";
			//}
			//tbSalidas.Text = salida;

			//string query3 = "select costo as Importe,descripcion as Categoria,info as Descripcion from gastos where (fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and descripcion != 'Depositos'";
			////string query3 = "select costo as Importe,descripcion as Categoria,info as Descripcion from gastos where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "'";
			//dggastos.DataSource = conexion.llenarVistas(query3);
			//string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad from abonos as a inner join Reserva r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '"+dtpFinal.Text+"') and a.cantidad > 0";
			//dgabonos.DataSource = conexion.llenarVistas(query2);

			//string query9 = "select costo as Cantidad,fecha as Fecha,info as Descripcion from gastos where descripcion = 'depositos' and fecha between '"+dtpInical.Text+"' and '"+dtpFinal.Text+"'";
			//dvDespositos.DataSource = conexion.llenarVistas(query9);
			//String query2 = "select Sum(convert(numeric(10, 2), (ganacia))) AS 'Ganancia' , convert(varchar, fecha) AS 'Fecha' from cortes  where fecha between '" + dtpInical.Text + "' and '" + dtpFinal.Text + "' group by fecha";
		}

        //private void btnGananciaReal_Click(object sender, EventArgs e)
        //{
        //    if (txtLuz.TextLength > 0 && txtAgua.TextLength > 0 && txtEmpleados.TextLength > 0 && txtContador.TextLength > 0 && txtGastos.TextLength > 0)
        //    {
        //        double gananciaReal = Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtLuz.Text) - Convert.ToDouble(txtAgua.Text) - Convert.ToDouble(txtEmpleados.Text) - Convert.ToDouble(txtContador.Text) - Convert.ToDouble(txtGasolina.Text) - Convert.ToDouble(txtGastos.Text);
        //        txtGanciaReal.Text = Convert.ToString(gananciaReal);
        //    }
        //    else {
        //        MessageBox.Show("Verifique que han sido ingresado los gastos \nSi no se gasto dinero en un gasto ingrese un 0","Atencion");
        //    }
            
        //}

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            menu_inicio menu = new menu_inicio();
            if (Program.NombreUsuario == "admin")
            {
                menu.toolStripMenuItem2.Visible = true;
            }
            menu.Show();
            this.Close();
        }

     

    }
}
