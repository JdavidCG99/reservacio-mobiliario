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
    public partial class menu_inicio : Form
    {
        public menu_inicio()
        {
            InitializeComponent();
        }

        private void menu_inicio_Load(object sender, EventArgs e)
        {
            hora.Enabled = true;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            
            ElegirCliente reservacion = new ElegirCliente();
            reservacion.Show();
            this.Hide();
            //this.Close();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            verReservaciones verReservacion = new verReservaciones();
            verReservacion.Show();
            this.Hide();
        }

        private void opcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            entegasDiarias entegasDiarias = new entegasDiarias();
            entegasDiarias.Show();
            this.Hide();
        }

        private void opcionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            recoleccionesDiarias recoleccionesDiarias = new recoleccionesDiarias();
            recoleccionesDiarias.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            catalogoClientes catalogoClientes = new catalogoClientes();
            catalogoClientes.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ///ActiveForm.Hide();
            catalogoFletes catalogoFletes = new catalogoFletes();
            catalogoFletes.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //ActiveForm.Hide();
            ganancia ganancia = new ganancia();
            ganancia.Show();
            this.Hide();
        }

        private void menu_inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Exit();
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            corte c = new corte();
            c.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Gastos ganancia = new Gastos();
            ganancia.Show();
            this.Hide();
        }

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			ClientesReservacion y = new ClientesReservacion();
			y.Show();
			this.Hide();
		}

		private void productosFueraToolStripMenuItem_Click(object sender, EventArgs e)
		{
			materialFuera y = new materialFuera();
			y.Show();
			this.Hide();
		}

		private void dineroPendienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DineroRetenido y = new DineroRetenido();
			y.Show();
			this.Hide();
		}

		private void registrarFaltanteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			registroFaltante y = new registroFaltante();
			y.Show();
			this.Hide();
		}

		private void productosFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProductosFaltantes y = new ProductosFaltantes();
			y.Show();
			this.Hide();
		}

		private void depositosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			depositos y = new depositos();
			y.Show();
			this.Hide();
		}

		private void comfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			avctualizarUsuario y = new avctualizarUsuario();
			y.Show();
			this.Hide();
		}

		private void abonosReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			abonos y = new abonos();
			y.Show();
			this.Hide();
		}
	}
}
