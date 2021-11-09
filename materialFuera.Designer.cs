namespace Sistema_Reservaciones
{
	partial class materialFuera
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(materialFuera));
			this.gvProdcutos = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			groupBox2 = new System.Windows.Forms.GroupBox();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvProdcutos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			groupBox2.CausesValidation = false;
			groupBox2.Controls.Add(this.gvProdcutos);
			groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			groupBox2.Location = new System.Drawing.Point(27, 132);
			groupBox2.Margin = new System.Windows.Forms.Padding(4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(4);
			groupBox2.Size = new System.Drawing.Size(1182, 601);
			groupBox2.TabIndex = 11;
			groupBox2.TabStop = false;
			groupBox2.Text = "Productos";
			groupBox2.UseCompatibleTextRendering = true;
			// 
			// gvProdcutos
			// 
			this.gvProdcutos.AllowUserToAddRows = false;
			this.gvProdcutos.AllowUserToDeleteRows = false;
			this.gvProdcutos.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvProdcutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvProdcutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gvProdcutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvProdcutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvProdcutos.Location = new System.Drawing.Point(23, 31);
			this.gvProdcutos.Margin = new System.Windows.Forms.Padding(4);
			this.gvProdcutos.Name = "gvProdcutos";
			this.gvProdcutos.ReadOnly = true;
			this.gvProdcutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvProdcutos.Size = new System.Drawing.Size(1151, 562);
			this.gvProdcutos.TabIndex = 12;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dtFecha);
			this.groupBox3.Controls.Add(this.btnRegresar);
			this.groupBox3.Controls.Add(this.btnActualizar);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(27, 13);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(1042, 92);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Acciones";
			// 
			// dtFecha
			// 
			this.dtFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFecha.Location = new System.Drawing.Point(61, 34);
			this.dtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(157, 27);
			this.dtFecha.TabIndex = 22;
			this.dtFecha.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(887, 27);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 21;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.White;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(271, 27);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(183, 44);
			this.btnActualizar.TabIndex = 3;
			this.btnActualizar.Text = "Cambiar fecha";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// materialFuera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1241, 750);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Name = "materialFuera";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Productos fuera";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.materialFuera_Load);
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvProdcutos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView gvProdcutos;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.DateTimePicker dtFecha;
	}
}