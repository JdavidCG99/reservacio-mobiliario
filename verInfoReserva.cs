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
    public partial class verInfoReserva : Form
    {
        string id;
		int identificador;
        Conexion conexion = new Conexion();
        public verInfoReserva(string id)
        {
            InitializeComponent();
            this.id = id;
        }
		public verInfoReserva(string id, int identificador)
		{
			InitializeComponent();
			this.id = id;
			this.identificador = identificador;
		}
		private void label4_Click(object sender, EventArgs e)
        {

        }

        private void verInfoReserva_Load(object sender, EventArgs e)
        {
            string [] datos = conexion.verInfoReserva("select r.idReserva, r.fechaReserva,r.fechaSalida,r.fechaRegreso," +
                "r.nombre,r.telefono,f.ubicacion,r.descripcionUbicacion,r.total,r.anticipo,r.restante,r.deposito " +
                "from Reserva as r inner join Flete as f on r.idFlete=f.idFlete where r.idReserva="+id);
            tbFolio.Text = datos[0];
            tbFechaPedido.Text = datos[1];
            tbFechaEntrega.Text = datos[2];
            tbFechaRegreso.Text = datos[3];
            tbCliente.Text = datos[4];
            tbCelular.Text = datos[5];
            tbUbicacion.Text = datos[6];
            tbDescripcion.Text = datos[7];
            tbTotal.Text = datos[8];
            tbAnticipo.Text = datos[9];
            tbRestante.Text = datos[10];
            tbDeposito.Text = datos[11];
            string query = "select d.idProductos as Id,p.nombre as Nombre,p.descripcion as Descripcion," +
                "d.cantidad as Cantidad_a_llevar from Detalle_Reserva as d " +
                "inner join Productos as p on d.idProductos=p.idProductos where d.idReserva=" + id + " and estatus=1 and cantidad>0";
            gvProductos.DataSource = conexion.llenarVistas(query);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir yus = new imprimir(tbFolio.Text);
            yus.Show();
        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BackColor = Color.RoyalBlue;
        }

        private void btnRegresar_MouseHover(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.Tomato;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BackColor = Color.White;
        }

        private void btnRegresar_MouseLeave(object sender, EventArgs e)
        {
            btnRegresar.BackColor = Color.White;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
			if (identificador == 1)
			{
				recoleccionesDiarias yus = new recoleccionesDiarias();
				yus.Show();
				this.Close();
			}
			else if(identificador == 2){

				entegasDiarias y = new entegasDiarias();
				y.Show();
				this.Close();

			}else{

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
}
