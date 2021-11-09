namespace Sistema_Reservaciones
{
	partial class depositos
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dtpFinal = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dgSalidas = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpInical = new System.Windows.Forms.DateTimePicker();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dgEntradas = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtFin = new System.Windows.Forms.DateTimePicker();
			this.dtInicio = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgSalidas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpFinal
			// 
			this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinal.Location = new System.Drawing.Point(306, -100);
			this.dtpFinal.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFinal.Name = "dtpFinal";
			this.dtpFinal.Size = new System.Drawing.Size(265, 26);
			this.dtpFinal.TabIndex = 33;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(36, 105);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(167, 20);
			this.label14.TabIndex = 40;
			this.label14.Text = "Entrada de depositos";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(776, 105);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(164, 20);
			this.label12.TabIndex = 39;
			this.label12.Text = "Salidas de depositos";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// dgSalidas
			// 
			this.dgSalidas.AllowUserToAddRows = false;
			this.dgSalidas.AllowUserToDeleteRows = false;
			this.dgSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgSalidas.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgSalidas.Location = new System.Drawing.Point(757, 128);
			this.dgSalidas.Name = "dgSalidas";
			this.dgSalidas.ReadOnly = true;
			this.dgSalidas.RowTemplate.Height = 24;
			this.dgSalidas.Size = new System.Drawing.Size(678, 582);
			this.dgSalidas.TabIndex = 37;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(302, -119);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 35;
			this.label2.Text = "Fecha Final";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-130, -119);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 34;
			this.label1.Text = "Fecha Inicial";
			// 
			// dtpInical
			// 
			this.dtpInical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInical.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInical.Location = new System.Drawing.Point(-126, -100);
			this.dtpInical.Margin = new System.Windows.Forms.Padding(4);
			this.dtpInical.Name = "dtpInical";
			this.dtpInical.Size = new System.Drawing.Size(265, 26);
			this.dtpInical.TabIndex = 32;
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(938, 19);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 36;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// dgEntradas
			// 
			this.dgEntradas.AllowUserToAddRows = false;
			this.dgEntradas.AllowUserToDeleteRows = false;
			this.dgEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgEntradas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgEntradas.Location = new System.Drawing.Point(24, 128);
			this.dgEntradas.Name = "dgEntradas";
			this.dgEntradas.ReadOnly = true;
			this.dgEntradas.RowTemplate.Height = 24;
			this.dgEntradas.Size = new System.Drawing.Size(714, 582);
			this.dgEntradas.TabIndex = 38;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(496, 19);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 20);
			this.label3.TabIndex = 44;
			this.label3.Text = "Fecha Final";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 19);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 20);
			this.label4.TabIndex = 43;
			this.label4.Text = "Fecha Inicial";
			// 
			// dtFin
			// 
			this.dtFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFin.Location = new System.Drawing.Point(500, 43);
			this.dtFin.Margin = new System.Windows.Forms.Padding(4);
			this.dtFin.Name = "dtFin";
			this.dtFin.Size = new System.Drawing.Size(265, 26);
			this.dtFin.TabIndex = 42;
			this.dtFin.ValueChanged += new System.EventHandler(this.dtFin_ValueChanged);
			// 
			// dtInicio
			// 
			this.dtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtInicio.Location = new System.Drawing.Point(68, 43);
			this.dtInicio.Margin = new System.Windows.Forms.Padding(4);
			this.dtInicio.Name = "dtInicio";
			this.dtInicio.Size = new System.Drawing.Size(265, 26);
			this.dtInicio.TabIndex = 41;
			this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
			// 
			// depositos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1447, 753);
			this.ControlBox = false;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtFin);
			this.Controls.Add(this.dtInicio);
			this.Controls.Add(this.dtpFinal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dgSalidas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpInical);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dgEntradas);
			this.Name = "depositos";
			this.Text = "depositos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.depositos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgSalidas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpFinal;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dgSalidas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpInical;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.DataGridView dgEntradas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtFin;
		private System.Windows.Forms.DateTimePicker dtInicio;
	}
}