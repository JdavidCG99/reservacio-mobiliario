namespace Sistema_Reservaciones
{
    partial class menu_inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_inicio));
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.lbHora = new System.Windows.Forms.Label();
			this.lbFecha = new System.Windows.Forms.Label();
			this.hora = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.opcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.opcionesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otrasOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosFueraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dineroPendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarFaltanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosFaltantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.depositosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comfiguracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.abonosReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.AutoSize = true;
			this.lbl_nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_nombre.ForeColor = System.Drawing.Color.Purple;
			this.lbl_nombre.Location = new System.Drawing.Point(12, 203);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(493, 93);
			this.lbl_nombre.TabIndex = 0;
			this.lbl_nombre.Text = "Lolis Rent’s";
			// 
			// lbHora
			// 
			this.lbHora.AutoSize = true;
			this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHora.Location = new System.Drawing.Point(960, 364);
			this.lbHora.Name = "lbHora";
			this.lbHora.Size = new System.Drawing.Size(249, 91);
			this.lbHora.TabIndex = 1;
			this.lbHora.Text = "label1";
			// 
			// lbFecha
			// 
			this.lbFecha.AutoSize = true;
			this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFecha.Location = new System.Drawing.Point(924, 472);
			this.lbFecha.Name = "lbFecha";
			this.lbFecha.Size = new System.Drawing.Size(103, 38);
			this.lbFecha.TabIndex = 2;
			this.lbFecha.Text = "label2";
			// 
			// hora
			// 
			this.hora.Tick += new System.EventHandler(this.hora_Tick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = System.Drawing.Color.White;
			this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.reservacionesToolStripMenuItem,
            this.opcionesToolStripMenuItem1,
            this.opcionesToolStripMenuItem2,
            this.toolStripMenuItem4,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.gastosToolStripMenuItem,
            this.otrasOpcionesToolStripMenuItem,
            this.toolStripMenuItem2});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1553, 49);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// opcionesToolStripMenuItem
			// 
			this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(186, 45);
			this.opcionesToolStripMenuItem.Text = "Nueva Reservacion";
			this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
			// 
			// reservacionesToolStripMenuItem
			// 
			this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
			this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(147, 45);
			this.reservacionesToolStripMenuItem.Text = "Reservaciones";
			this.reservacionesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesToolStripMenuItem_Click);
			// 
			// opcionesToolStripMenuItem1
			// 
			this.opcionesToolStripMenuItem1.Name = "opcionesToolStripMenuItem1";
			this.opcionesToolStripMenuItem1.Size = new System.Drawing.Size(98, 45);
			this.opcionesToolStripMenuItem1.Text = "Entregas";
			this.opcionesToolStripMenuItem1.Click += new System.EventHandler(this.opcionesToolStripMenuItem1_Click);
			// 
			// opcionesToolStripMenuItem2
			// 
			this.opcionesToolStripMenuItem2.Name = "opcionesToolStripMenuItem2";
			this.opcionesToolStripMenuItem2.Size = new System.Drawing.Size(114, 45);
			this.opcionesToolStripMenuItem2.Text = "Recolectas";
			this.opcionesToolStripMenuItem2.Click += new System.EventHandler(this.opcionesToolStripMenuItem2_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 45);
			this.toolStripMenuItem4.Text = "Clientes reservacion";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(108, 45);
			this.productosToolStripMenuItem.Text = "Productos";
			this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(92, 45);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.AutoSize = false;
			this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 25);
			this.toolStripMenuItem1.Text = "Fletes";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 45);
			this.toolStripMenuItem3.Text = "Gastos";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// gastosToolStripMenuItem
			// 
			this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
			this.gastosToolStripMenuItem.Size = new System.Drawing.Size(132, 45);
			this.gastosToolStripMenuItem.Text = "Corte de caja";
			this.gastosToolStripMenuItem.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
			// 
			// otrasOpcionesToolStripMenuItem
			// 
			this.otrasOpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosFueraToolStripMenuItem,
            this.dineroPendienteToolStripMenuItem,
            this.registrarFaltanteToolStripMenuItem,
            this.productosFaltantesToolStripMenuItem,
            this.abonosReservacionesToolStripMenuItem,
            this.depositosToolStripMenuItem,
            this.comfiguracionToolStripMenuItem});
			this.otrasOpcionesToolStripMenuItem.Name = "otrasOpcionesToolStripMenuItem";
			this.otrasOpcionesToolStripMenuItem.Size = new System.Drawing.Size(148, 45);
			this.otrasOpcionesToolStripMenuItem.Text = "Otras opciones";
			// 
			// productosFueraToolStripMenuItem
			// 
			this.productosFueraToolStripMenuItem.Name = "productosFueraToolStripMenuItem";
			this.productosFueraToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
			this.productosFueraToolStripMenuItem.Text = "Productos fuera";
			this.productosFueraToolStripMenuItem.Click += new System.EventHandler(this.productosFueraToolStripMenuItem_Click);
			// 
			// dineroPendienteToolStripMenuItem
			// 
			this.dineroPendienteToolStripMenuItem.Name = "dineroPendienteToolStripMenuItem";
			this.dineroPendienteToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
			this.dineroPendienteToolStripMenuItem.Text = "Dinero pendiente";
			this.dineroPendienteToolStripMenuItem.Click += new System.EventHandler(this.dineroPendienteToolStripMenuItem_Click);
			// 
			// registrarFaltanteToolStripMenuItem
			// 
			this.registrarFaltanteToolStripMenuItem.Name = "registrarFaltanteToolStripMenuItem";
			this.registrarFaltanteToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
			this.registrarFaltanteToolStripMenuItem.Text = "Registrar faltante";
			this.registrarFaltanteToolStripMenuItem.Click += new System.EventHandler(this.registrarFaltanteToolStripMenuItem_Click);
			// 
			// productosFaltantesToolStripMenuItem
			// 
			this.productosFaltantesToolStripMenuItem.Name = "productosFaltantesToolStripMenuItem";
			this.productosFaltantesToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
			this.productosFaltantesToolStripMenuItem.Text = "Productos faltantes";
			this.productosFaltantesToolStripMenuItem.Click += new System.EventHandler(this.productosFaltantesToolStripMenuItem_Click);
			// 
			// depositosToolStripMenuItem
			// 
			this.depositosToolStripMenuItem.Name = "depositosToolStripMenuItem";
			this.depositosToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
			this.depositosToolStripMenuItem.Text = "Depositos";
			this.depositosToolStripMenuItem.Click += new System.EventHandler(this.depositosToolStripMenuItem_Click);
			// 
			// comfiguracionToolStripMenuItem
			// 
			this.comfiguracionToolStripMenuItem.Name = "comfiguracionToolStripMenuItem";
			this.comfiguracionToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
			this.comfiguracionToolStripMenuItem.Text = "Configuracion";
			this.comfiguracionToolStripMenuItem.Click += new System.EventHandler(this.comfiguracionToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 45);
			this.toolStripMenuItem2.Text = "Ganancia";
			this.toolStripMenuItem2.Visible = false;
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// abonosReservacionesToolStripMenuItem
			// 
			this.abonosReservacionesToolStripMenuItem.Name = "abonosReservacionesToolStripMenuItem";
			this.abonosReservacionesToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
			this.abonosReservacionesToolStripMenuItem.Text = "Abonos reservaciones";
			this.abonosReservacionesToolStripMenuItem.Click += new System.EventHandler(this.abonosReservacionesToolStripMenuItem_Click);
			// 
			// menu_inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1553, 638);
			this.Controls.Add(this.lbFecha);
			this.Controls.Add(this.lbHora);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "menu_inicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Lolis Rent\'s";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_inicio_FormClosed);
			this.Load += new System.EventHandler(this.menu_inicio_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem otrasOpcionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosFueraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dineroPendienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarFaltanteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosFaltantesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem depositosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comfiguracionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abonosReservacionesToolStripMenuItem;
	}
}

