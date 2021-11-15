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

            DataTable dt = new DataTable();

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
			dggastos.DataSource = conexion.llenarVistas(query3);
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad from abonos as a inner join Reserva r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and convert(numeric(10, 2), (a.cantidad)) > 0 and a.fecha != '" + DateTime.Now + "'";
			dgabonos.DataSource = conexion.llenarVistas(query2);
		}

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            chartGanancia.Series[0].Points.Clear();

            DataTable dt = new DataTable();

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

			dggastos.DataSource = conexion.llenarVistas(query3);
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad from abonos as a inner join Reserva r on a.idReserva = r.idReserva where (a.fecha  between'" + dtpInical.Text + "' and '" + dtpFinal.Text + "') and convert(numeric(10, 2), (a.cantidad)) > 0 and a.fecha != '" + DateTime.Now + "'";
			dgabonos.DataSource = conexion.llenarVistas(query2);

		}

        private void ganancia_Load(object sender, EventArgs e)
        {
			dtpFinal.Value = DateTime.Now;

			DateTime nuevaFecha = DateTime.Now;
			nuevaFecha = nuevaFecha.AddDays(-15);
			dtpInical.Value = nuevaFecha;
		}


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
