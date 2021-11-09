namespace Sistema_Reservaciones
{
	partial class ClientesReservacion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesReservacion));
			this.fechaInicio = new System.Windows.Forms.DateTimePicker();
			this.fechaFin = new System.Windows.Forms.DateTimePicker();
			this.gvMayor = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvMayor)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// fechaInicio
			// 
			this.fechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.fechaInicio.Location = new System.Drawing.Point(68, 87);
			this.fechaInicio.Name = "fechaInicio";
			this.fechaInicio.Size = new System.Drawing.Size(200, 27);
			this.fechaInicio.TabIndex = 1;
			this.fechaInicio.ValueChanged += new System.EventHandler(this.fechaInicio_ValueChanged);
			// 
			// fechaFin
			// 
			this.fechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.fechaFin.Location = new System.Drawing.Point(448, 119);
			this.fechaFin.Name = "fechaFin";
			this.fechaFin.Size = new System.Drawing.Size(200, 27);
			this.fechaFin.TabIndex = 2;
			this.fechaFin.ValueChanged += new System.EventHandler(this.fechaFin_ValueChanged);
			// 
			// gvMayor
			// 
			this.gvMayor.AllowUserToAddRows = false;
			this.gvMayor.AllowUserToDeleteRows = false;
			this.gvMayor.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvMayor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvMayor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gvMayor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvMayor.Location = new System.Drawing.Point(42, 139);
			this.gvMayor.Margin = new System.Windows.Forms.Padding(4);
			this.gvMayor.Name = "gvMayor";
			this.gvMayor.ReadOnly = true;
			this.gvMayor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvMayor.Size = new System.Drawing.Size(831, 452);
			this.gvMayor.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(444, 96);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 14;
			this.label2.Text = "Fecha Final";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 64);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 15;
			this.label1.Text = "Fecha Inicial";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.fechaInicio);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.gvMayor);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(39, 32);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(904, 642);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Periodo";
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(984, 49);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 22;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// ClientesReservacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1162, 753);
			this.ControlBox = false;
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.fechaFin);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Name = "ClientesReservacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Ver clientes que mas consumen";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ClientesReservacion_Load);
			((System.ComponentModel.ISupportInitialize)(this.gvMayor)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker fechaInicio;
		private System.Windows.Forms.DateTimePicker fechaFin;
		public System.Windows.Forms.DataGridView gvMayor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRegresar;
	}
}