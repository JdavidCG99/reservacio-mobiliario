using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sistema_Reservaciones
{
    public partial class corte : Form
    {
        Conexion2 con = new Conexion2();
        double entrada;
        double dineroAnterior;
        double luz;
        double agua;
        double empleados;
        double contador;
        double gasolina;
        double og;
		double deposito;
        double gastos;
        double ganaciaReal;
        double dineroCaja;
		double dinerocortes;

		string ib;

        public corte()
        {
            InitializeComponent();
        }

        private void corte_Load(object sender, EventArgs e)
        {
            string entrada2 = con.getUnDato("select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' from abonos where fecha='" + DateTime.Now.ToShortDateString() + "'");
            if (entrada2.Equals(""))
            {
                entrada2 = "0";
            }
            entrada = Convert.ToDouble(entrada2);
            //txtLuz.Text = luz2;
            //entrada = Convert.ToDouble(con.getUnDato("select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' from abonos where fecha='" + DateTime.Now.ToShortDateString() + "'"));
            txtTotal.Text = Convert.ToString(entrada2);

            dineroAnterior = Convert.ToDouble(con.getUnDato("select cantidad from dineroCaja where id=1"));
			dinerocortes = Convert.ToDouble(con.getUnDato("select cantidad from dineroCaja where id=2"));

			string luz2 = con.getUnDato("select Sum(convert(numeric(10, 2), (costo)))  from gastos where fecha='" + DateTime.Now.ToShortDateString() + "' and descripcion='Luz'");
            if (luz2.Equals("")) {
                luz2 = "0";
            }
            luz = Convert.ToDouble(luz2);
            txtLuz.Text = luz2;

            string agua2 = con.getUnDato("select Sum(convert(numeric(10, 2), (costo)))  from gastos where fecha='" + DateTime.Now.ToShortDateString() + "' and descripcion='Agua'");
            if (agua2.Equals(""))
            {
                agua2 = "0";
            }
            agua = Convert.ToDouble(agua2);
            txtAgua.Text = agua2;

            string empleados2 = con.getUnDato("select Sum(convert(numeric(10, 2), (costo)))  from gastos where fecha='" + DateTime.Now.ToShortDateString() + "' and descripcion='Empleados'");
            if (empleados2.Equals(""))
            {
                empleados2 = "0";
            }
            empleados = Convert.ToDouble(empleados2);
            txtEmpleados.Text = empleados2;

            string contador2 = con.getUnDato("select Sum(convert(numeric(10, 2), (costo)))  from gastos where fecha='" + DateTime.Now.ToShortDateString() + "' and descripcion='Contador'");
            if (contador2.Equals(""))
            {
                contador2 = "0";
            }
            contador = Convert.ToDouble(contador2);
            txtContador.Text = contador2;

            string gasolina2 = con.getUnDato("select Sum(convert(numeric(10, 2), (costo)))  from gastos where fecha='" + DateTime.Now.ToShortDateString() + "' and descripcion='Gasolina'");
            if (gasolina2.Equals(""))
            {
                gasolina2 = "0";
            }
            gasolina = Convert.ToDouble(gasolina2);
            txtGasolina.Text = gasolina2;

            string og2 = con.getUnDato("select Sum(convert(numeric(10, 2), (costo)))  from gastos where fecha='" + DateTime.Now.ToShortDateString() + "' and descripcion='Otros gastos'");
            if (og2.Equals(""))
            {
                og2 = "0";
            }
            og = Convert.ToDouble(og2);
            txtGastos.Text = og2;

			string dep = con.getUnDato("select Sum(convert(numeric(10, 2), (costo)))  from gastos where fecha='" + DateTime.Now.ToShortDateString() + "' and descripcion='Depositos'");
			if (dep.Equals(""))
			{
				dep = "0";
			}
			deposito = Convert.ToDouble(dep);
			tbDepositos.Text = dep;

			gastos = luz + agua + empleados + contador + gasolina + og;
            ganaciaReal = entrada-gastos;
            dineroCaja = ganaciaReal + dineroAnterior;

            txtGanciaReal.Text = Convert.ToString(ganaciaReal);

            textBox1.Text = Convert.ToString(dineroCaja);

			string estdep = con.getUnDato("select Sum(convert(numeric(10, 2), (cantidad)))  from entradaDepositos where fecha='" + DateTime.Now.ToShortDateString()+"'");
			if (estdep.Equals(""))
			{
				estdep = "0";
			}
			dinerocortes = dinerocortes + Convert.ToDouble(estdep);
			dinerocortes = dinerocortes - Convert.ToDouble(tbDepositos.Text);

			tbdindep.Text = Convert.ToString(dinerocortes);

			string query = "select costo as Importe,descripcion as Categoria,info as Descripcion from gastos where fecha='" + DateTime.Now.ToShortDateString() + "'";
			dggastos.DataSource = con.llenarVistas(query);
			string query2 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,a.cantidad as Cantidad from abonos as a inner join Reserva r on a.idReserva = r.idReserva where a.fecha = '"+ DateTime.Now.ToShortDateString() + "' and a.cantidad > 0 order by  r.idReserva ";
			dgabonos.DataSource = con.llenarVistas(query2);
			string query3 = "select r.idReserva as Id_Reserva,r.nombre as Nombre_Cliente,ed.cantidad as Cantidad from entradaDepositos as ed inner join Reserva as r on ed.idReserva = r.idReserva where ed.fecha = '" + DateTime.Now.ToShortDateString() + "' and ed.cantidad>0 order by  r.idReserva ";
			dgdepositos.DataSource = con.llenarVistas(query3);
			//textBox1 = Convert.ToString(ganaciaReal + Convert.ToDouble(dineroAnterior));
			//txtTotal.Text = con.getUnDato("select Sum(convert(numeric(10, 2), (Cantidad))) AS 'Ganancia' from abonos where fecha='" + DateTime.Now.ToShortDateString() + "'");
		}

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que desea salir"
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult yus = MessageBox.Show("Segura que desea dar fin al corte de caja"
             , "Atencion", MessageBoxButtons.YesNo);
            if (yus == DialogResult.Yes)
            {
                //this.Close();
                ib = Interaction.InputBox("Ingrese la cantidad de dinero que se quedara en caja");
                if (noContieneLetras(ib))
                {
					//entrada2 dinero que entro en el dia
					//gastos dinero gastado en el dia
					//gananciareal dinero que entro en el dia menos los gastos
					
                    string query1 = "insert into cortes values("+ganaciaReal+",'"+DateTime.Now.ToShortDateString()+"',"+entrada+","+gastos+")";
                    con.ejecutar(query1);
                    string query = "update dineroCaja set cantidad="+ib+" where id=1";
                    con.ejecutar(query);
					string query7 = "update dineroCaja set cantidad=" + tbdindep.Text + " where id=2";
					con.ejecutar(query7);
					MessageBox.Show("Corte de caja del dia finalizado \nPara ver las ganancias se puede ver en el apartado de ganancias \nDado el corte se da por echo que las cuentas del dia estan bien \nSaludos que descansen!!", "Atencion");
                    menu_inicio menu = new menu_inicio();
                    if (Program.NombreUsuario == "admin")
                    {
                        menu.toolStripMenuItem2.Visible = true;
                    }
                    menu.Show();
                    this.Close();
                }
                else {
                    MessageBox.Show("Ingresa un valo de solo numeros","Atencion");
                }
                
            }
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
    }
}
