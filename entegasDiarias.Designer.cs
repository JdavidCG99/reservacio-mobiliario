namespace Sistema_Reservaciones
{
    partial class entegasDiarias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entegasDiarias));
			this.lbFecha = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnVerHoy = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtDia = new System.Windows.Forms.DateTimePicker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.gvReservaciones = new System.Windows.Forms.DataGridView();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnSalida = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.tbFolio = new System.Windows.Forms.TextBox();
			this.lblFolio = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.tbBuscarCleinte = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvReservaciones)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbFecha
			// 
			this.lbFecha.AutoSize = true;
			this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFecha.Location = new System.Drawing.Point(5, 28);
			this.lbFecha.Name = "lbFecha";
			this.lbFecha.Size = new System.Drawing.Size(79, 29);
			this.lbFecha.TabIndex = 3;
			this.lbFecha.Text = "label2";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnVerHoy);
			this.groupBox1.Controls.Add(this.lbFecha);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(21, 17);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(749, 70);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dia de hoy";
			// 
			// btnVerHoy
			// 
			this.btnVerHoy.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
			this.btnVerHoy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnVerHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerHoy.Location = new System.Drawing.Point(587, 21);
			this.btnVerHoy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVerHoy.Name = "btnVerHoy";
			this.btnVerHoy.Size = new System.Drawing.Size(133, 34);
			this.btnVerHoy.TabIndex = 4;
			this.btnVerHoy.Text = "Ver hoy";
			this.btnVerHoy.UseVisualStyleBackColor = false;
			this.btnVerHoy.Click += new System.EventHandler(this.btnVerHoy_Click);
			this.btnVerHoy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnVerHoy_MouseClick);
			this.btnVerHoy.MouseLeave += new System.EventHandler(this.btnVerHoy_MouseLeave);
			this.btnVerHoy.MouseHover += new System.EventHandler(this.btnVerHoy_MouseHover);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtDia);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(803, 19);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(223, 69);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ver entregas de otro dia";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// dtDia
			// 
			this.dtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtDia.Location = new System.Drawing.Point(23, 27);
			this.dtDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtDia.Name = "dtDia";
			this.dtDia.Size = new System.Drawing.Size(159, 27);
			this.dtDia.TabIndex = 0;
			this.dtDia.ValueChanged += new System.EventHandler(this.dtDia_ValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gvReservaciones);
			this.groupBox3.Location = new System.Drawing.Point(21, 173);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(1158, 578);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			// 
			// gvReservaciones
			// 
			this.gvReservaciones.AllowUserToAddRows = false;
			this.gvReservaciones.AllowUserToDeleteRows = false;
			this.gvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gvReservaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvReservaciones.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.gvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvReservaciones.DefaultCellStyle = dataGridViewCellStyle4;
			this.gvReservaciones.GridColor = System.Drawing.Color.CornflowerBlue;
			this.gvReservaciones.Location = new System.Drawing.Point(11, 22);
			this.gvReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gvReservaciones.Name = "gvReservaciones";
			this.gvReservaciones.ReadOnly = true;
			this.gvReservaciones.RowTemplate.Height = 24;
			this.gvReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvReservaciones.Size = new System.Drawing.Size(1128, 538);
			this.gvReservaciones.TabIndex = 0;
			this.gvReservaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvReservaciones_CellContentDoubleClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(1039, 771);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 24;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			this.btnRegresar.MouseLeave += new System.EventHandler(this.btnRegresar_MouseLeave);
			this.btnRegresar.MouseHover += new System.EventHandler(this.btnRegresar_MouseHover);
			// 
			// btnSalida
			// 
			this.btnSalida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalida.Location = new System.Drawing.Point(36, 771);
			this.btnSalida.Margin = new System.Windows.Forms.Padding(4);
			this.btnSalida.Name = "btnSalida";
			this.btnSalida.Size = new System.Drawing.Size(221, 44);
			this.btnSalida.TabIndex = 29;
			this.btnSalida.Text = "Marcar salida";
			this.btnSalida.UseVisualStyleBackColor = false;
			this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnBuscar);
			this.groupBox4.Controls.Add(this.tbFolio);
			this.groupBox4.Controls.Add(this.lblFolio);
			this.groupBox4.Controls.Add(this.lblCliente);
			this.groupBox4.Controls.Add(this.tbBuscarCleinte);
			this.groupBox4.Location = new System.Drawing.Point(21, 94);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(944, 73);
			this.groupBox4.TabIndex = 30;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Buscar";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
			this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
			this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBuscar.Location = new System.Drawing.Point(281, 15);
			this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(45, 36);
			this.btnBuscar.TabIndex = 11;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// tbFolio
			// 
			this.tbFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFolio.Location = new System.Drawing.Point(139, 23);
			this.tbFolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbFolio.Multiline = true;
			this.tbFolio.Name = "tbFolio";
			this.tbFolio.Size = new System.Drawing.Size(135, 25);
			this.tbFolio.TabIndex = 1;
			this.tbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFolio_KeyPress);
			// 
			// lblFolio
			// 
			this.lblFolio.AutoSize = true;
			this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFolio.Location = new System.Drawing.Point(7, 28);
			this.lblFolio.Name = "lblFolio";
			this.lblFolio.Size = new System.Drawing.Size(112, 20);
			this.lblFolio.TabIndex = 7;
			this.lblFolio.Text = "Num. de folio:";
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCliente.Location = new System.Drawing.Point(363, 28);
			this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(66, 20);
			this.lblCliente.TabIndex = 10;
			this.lblCliente.Text = "Cliente:";
			// 
			// tbBuscarCleinte
			// 
			this.tbBuscarCleinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbBuscarCleinte.Location = new System.Drawing.Point(444, 23);
			this.tbBuscarCleinte.Margin = new System.Windows.Forms.Padding(4);
			this.tbBuscarCleinte.Name = "tbBuscarCleinte";
			this.tbBuscarCleinte.Size = new System.Drawing.Size(362, 27);
			this.tbBuscarCleinte.TabIndex = 9;
			this.tbBuscarCleinte.TextChanged += new System.EventHandler(this.tbBuscarCleinte_TextChanged);
			this.tbBuscarCleinte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCleinte_KeyPress);
			// 
			// entegasDiarias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1216, 828);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.btnSalida);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "entegasDiarias";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Entregas del dia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.entegasDiarias_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvReservaciones)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerHoy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtDia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvReservaciones;
        private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnSalida;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox tbFolio;
		private System.Windows.Forms.Label lblFolio;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.TextBox tbBuscarCleinte;
	}
}