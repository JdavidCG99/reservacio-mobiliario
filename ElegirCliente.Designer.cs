namespace Sistema_Reservaciones
{
	partial class ElegirCliente
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
			System.Windows.Forms.GroupBox groupBox2;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirCliente));
			this.gvClientes = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBuscadorCliente = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.btnReserva = new System.Windows.Forms.Button();
			groupBox2 = new System.Windows.Forms.GroupBox();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			groupBox2.CausesValidation = false;
			groupBox2.Controls.Add(this.gvClientes);
			groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			groupBox2.Location = new System.Drawing.Point(26, 147);
			groupBox2.Margin = new System.Windows.Forms.Padding(4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(4);
			groupBox2.Size = new System.Drawing.Size(1167, 565);
			groupBox2.TabIndex = 13;
			groupBox2.TabStop = false;
			groupBox2.Text = "Clientes Activos";
			groupBox2.UseCompatibleTextRendering = true;
			groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// gvClientes
			// 
			this.gvClientes.AllowUserToAddRows = false;
			this.gvClientes.AllowUserToDeleteRows = false;
			this.gvClientes.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.gvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvClientes.Location = new System.Drawing.Point(23, 31);
			this.gvClientes.Margin = new System.Windows.Forms.Padding(4);
			this.gvClientes.Name = "gvClientes";
			this.gvClientes.ReadOnly = true;
			this.gvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvClientes.Size = new System.Drawing.Size(1118, 526);
			this.gvClientes.TabIndex = 12;
			this.gvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvClientes_CellContentClick);
			this.gvClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvClientes_CellContentDoubleClick);
			this.gvClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvClientes_CellMouseClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnRegresar);
			this.groupBox3.Controls.Add(this.btnAgregar);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(795, 23);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(398, 100);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Acciones";
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(251, 27);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 21;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			this.btnRegresar.MouseLeave += new System.EventHandler(this.btnRegresar_MouseLeave);
			this.btnRegresar.MouseHover += new System.EventHandler(this.btnRegresar_MouseHover);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.White;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(50, 27);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(121, 44);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
			this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtBuscadorCliente);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(26, 23);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(744, 100);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ingese el nombre del cliente a buscar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Cliente";
			// 
			// txtBuscadorCliente
			// 
			this.txtBuscadorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscadorCliente.Location = new System.Drawing.Point(23, 54);
			this.txtBuscadorCliente.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscadorCliente.Name = "txtBuscadorCliente";
			this.txtBuscadorCliente.Size = new System.Drawing.Size(424, 26);
			this.txtBuscadorCliente.TabIndex = 2;
			this.txtBuscadorCliente.TextChanged += new System.EventHandler(this.txtBuscadorCliente_TextChanged);
			this.txtBuscadorCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscadorCliente_KeyPress);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tbNombre);
			this.groupBox4.Controls.Add(this.tbId);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(26, 719);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(840, 71);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Cliente seleccionado";
			// 
			// tbNombre
			// 
			this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNombre.Location = new System.Drawing.Point(256, 26);
			this.tbNombre.Multiline = true;
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.ReadOnly = true;
			this.tbNombre.Size = new System.Drawing.Size(510, 33);
			this.tbNombre.TabIndex = 1;
			// 
			// tbId
			// 
			this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbId.Location = new System.Drawing.Point(16, 26);
			this.tbId.Multiline = true;
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(205, 33);
			this.tbId.TabIndex = 0;
			// 
			// btnReserva
			// 
			this.btnReserva.BackColor = System.Drawing.Color.White;
			this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReserva.Location = new System.Drawing.Point(913, 740);
			this.btnReserva.Margin = new System.Windows.Forms.Padding(4);
			this.btnReserva.Name = "btnReserva";
			this.btnReserva.Size = new System.Drawing.Size(254, 44);
			this.btnReserva.TabIndex = 22;
			this.btnReserva.Text = "Hacer reservacion";
			this.btnReserva.UseVisualStyleBackColor = false;
			this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
			// 
			// ElegirCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1206, 808);
			this.ControlBox = false;
			this.Controls.Add(this.btnReserva);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ElegirCliente";
			this.Text = "Elegir Cliente";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ElegirCliente_Load);
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuscadorCliente;
		public System.Windows.Forms.DataGridView gvClientes;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Button btnReserva;
	}
}