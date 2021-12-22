namespace Sistema_Reservaciones
{
	partial class abonos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abonos));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFinal = new System.Windows.Forms.DateTimePicker();
			this.dtpInical = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.dgabonos = new System.Windows.Forms.DataGridView();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCliente = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgabonos)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbCliente);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFinal);
			this.groupBox1.Controls.Add(this.dtpInical);
			this.groupBox1.Location = new System.Drawing.Point(50, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1122, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(472, 42);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Fecha Final";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Fecha Inicial";
			// 
			// dtpFinal
			// 
			this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinal.Location = new System.Drawing.Point(592, 42);
			this.dtpFinal.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFinal.Name = "dtpFinal";
			this.dtpFinal.Size = new System.Drawing.Size(265, 26);
			this.dtpFinal.TabIndex = 6;
			this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
			// 
			// dtpInical
			// 
			this.dtpInical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInical.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInical.Location = new System.Drawing.Point(131, 42);
			this.dtpInical.Margin = new System.Windows.Forms.Padding(4);
			this.dtpInical.Name = "dtpInical";
			this.dtpInical.Size = new System.Drawing.Size(265, 26);
			this.dtpInical.TabIndex = 5;
			this.dtpInical.ValueChanged += new System.EventHandler(this.dtpInical_ValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(72, 207);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(200, 20);
			this.label14.TabIndex = 33;
			this.label14.Text = "Entrada de reservaciones";
			this.label14.Click += new System.EventHandler(this.label14_Click);
			// 
			// dgabonos
			// 
			this.dgabonos.AllowUserToAddRows = false;
			this.dgabonos.AllowUserToDeleteRows = false;
			this.dgabonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgabonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgabonos.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgabonos.Location = new System.Drawing.Point(60, 230);
			this.dgabonos.Name = "dgabonos";
			this.dgabonos.ReadOnly = true;
			this.dgabonos.RowTemplate.Height = 24;
			this.dgabonos.Size = new System.Drawing.Size(1070, 488);
			this.dgabonos.TabIndex = 32;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(990, 54);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 34;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 100);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Cliente";
			// 
			// tbCliente
			// 
			this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCliente.Location = new System.Drawing.Point(106, 100);
			this.tbCliente.Margin = new System.Windows.Forms.Padding(4);
			this.tbCliente.Name = "tbCliente";
			this.tbCliente.Size = new System.Drawing.Size(429, 26);
			this.tbCliente.TabIndex = 9;
			this.tbCliente.TextChanged += new System.EventHandler(this.tbCliente_TextChanged);
			// 
			// abonos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1233, 730);
			this.ControlBox = false;
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dgabonos);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "abonos";
			this.Text = "Abonos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.abonos_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgabonos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpFinal;
		private System.Windows.Forms.DateTimePicker dtpInical;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView dgabonos;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCliente;
	}
}