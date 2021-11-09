namespace Sistema_Reservaciones
{
	partial class registroFaltante
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroFaltante));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.tbFolio = new System.Windows.Forms.TextBox();
			this.lblFolio = new System.Windows.Forms.Label();
			this.tbCliente = new System.Windows.Forms.TextBox();
			this.tbCelular = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gvProductos = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tbIdProducto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbProducto = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbCantidad = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnAgg = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tbDescripcion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.tbFolio);
			this.groupBox1.Controls.Add(this.lblFolio);
			this.groupBox1.Location = new System.Drawing.Point(62, 32);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(542, 127);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
			// 
			// tbId
			// 
			this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbId.Location = new System.Drawing.Point(262, 72);
			this.tbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbId.Multiline = true;
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(165, 25);
			this.tbId.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(205, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Reservacion seleccionada";
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
			// tbCliente
			// 
			this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCliente.Location = new System.Drawing.Point(125, 22);
			this.tbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCliente.Multiline = true;
			this.tbCliente.Name = "tbCliente";
			this.tbCliente.ReadOnly = true;
			this.tbCliente.Size = new System.Drawing.Size(387, 29);
			this.tbCliente.TabIndex = 23;
			// 
			// tbCelular
			// 
			this.tbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCelular.Location = new System.Drawing.Point(125, 68);
			this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCelular.Multiline = true;
			this.tbCelular.Name = "tbCelular";
			this.tbCelular.ReadOnly = true;
			this.tbCelular.Size = new System.Drawing.Size(259, 29);
			this.tbCelular.TabIndex = 22;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 21;
			this.label3.Text = "Celular:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 20;
			this.label1.Text = "Cliente:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbCliente);
			this.groupBox2.Controls.Add(this.tbCelular);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(624, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(570, 127);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos cliente";
			// 
			// gvProductos
			// 
			this.gvProductos.AllowUserToAddRows = false;
			this.gvProductos.AllowUserToDeleteRows = false;
			this.gvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvProductos.Location = new System.Drawing.Point(22, 26);
			this.gvProductos.Name = "gvProductos";
			this.gvProductos.ReadOnly = true;
			this.gvProductos.RowTemplate.Height = 24;
			this.gvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvProductos.Size = new System.Drawing.Size(994, 340);
			this.gvProductos.TabIndex = 25;
			this.gvProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvProductos_CellMouseClick);
			this.gvProductos.Click += new System.EventHandler(this.gvProductos_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gvProductos);
			this.groupBox3.Location = new System.Drawing.Point(62, 181);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1057, 387);
			this.groupBox3.TabIndex = 26;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Productos de la reservacion";
			// 
			// tbIdProducto
			// 
			this.tbIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIdProducto.Location = new System.Drawing.Point(114, 17);
			this.tbIdProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbIdProducto.Multiline = true;
			this.tbIdProducto.Name = "tbIdProducto";
			this.tbIdProducto.ReadOnly = true;
			this.tbIdProducto.Size = new System.Drawing.Size(141, 29);
			this.tbIdProducto.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 20);
			this.label4.TabIndex = 24;
			this.label4.Text = "Id producto:";
			// 
			// tbProducto
			// 
			this.tbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbProducto.Location = new System.Drawing.Point(379, 17);
			this.tbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbProducto.Multiline = true;
			this.tbProducto.Name = "tbProducto";
			this.tbProducto.ReadOnly = true;
			this.tbProducto.Size = new System.Drawing.Size(311, 29);
			this.tbProducto.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(292, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 27;
			this.label5.Text = "Producto:";
			// 
			// tbCantidad
			// 
			this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCantidad.Location = new System.Drawing.Point(801, 17);
			this.tbCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCantidad.Multiline = true;
			this.tbCantidad.Name = "tbCantidad";
			this.tbCantidad.Size = new System.Drawing.Size(178, 29);
			this.tbCantidad.TabIndex = 30;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(715, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 29;
			this.label6.Text = "Cantidad:";
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(1269, 39);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 32;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// btnAgg
			// 
			this.btnAgg.BackColor = System.Drawing.Color.White;
			this.btnAgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgg.Location = new System.Drawing.Point(886, 70);
			this.btnAgg.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgg.Name = "btnAgg";
			this.btnAgg.Size = new System.Drawing.Size(131, 44);
			this.btnAgg.TabIndex = 31;
			this.btnAgg.Text = "Agregar";
			this.btnAgg.UseVisualStyleBackColor = false;
			this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tbDescripcion);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.btnAgg);
			this.groupBox4.Controls.Add(this.tbCantidad);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.tbProducto);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.tbIdProducto);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Location = new System.Drawing.Point(61, 589);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1057, 133);
			this.groupBox4.TabIndex = 33;
			this.groupBox4.TabStop = false;
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescripcion.Location = new System.Drawing.Point(379, 70);
			this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDescripcion.Multiline = true;
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.ReadOnly = true;
			this.tbDescripcion.Size = new System.Drawing.Size(472, 29);
			this.tbDescripcion.TabIndex = 33;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(292, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 20);
			this.label7.TabIndex = 32;
			this.label7.Text = "Producto:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(1184, 611);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(216, 44);
			this.button1.TabIndex = 34;
			this.button1.Text = "Ver pendientes";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// registroFaltante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1426, 742);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "registroFaltante";
			this.Text = "Registrar faltante";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.registroFaltante_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox tbFolio;
		private System.Windows.Forms.Label lblFolio;
		private System.Windows.Forms.TextBox tbCliente;
		private System.Windows.Forms.TextBox tbCelular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView gvProductos;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbIdProducto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbProducto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbCantidad;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnAgg;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox tbDescripcion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
	}
}