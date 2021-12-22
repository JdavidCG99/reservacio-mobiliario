namespace Sistema_Reservaciones
{
    partial class ganancia
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ganancia));
			this.chartGanancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dtpInical = new System.Windows.Forms.DateTimePicker();
			this.dtpFinal = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tbSalidas = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbEntrada = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.dgabonos = new System.Windows.Forms.DataGridView();
			this.dggastos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.chartGanancia)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgabonos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dggastos)).BeginInit();
			this.SuspendLayout();
			// 
			// chartGanancia
			// 
			chartArea1.Name = "ChartArea1";
			this.chartGanancia.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartGanancia.Legends.Add(legend1);
			this.chartGanancia.Location = new System.Drawing.Point(23, 81);
			this.chartGanancia.Margin = new System.Windows.Forms.Padding(4);
			this.chartGanancia.Name = "chartGanancia";
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.IsVisibleInLegend = false;
			series1.Legend = "Legend1";
			series1.Name = "Fecha";
			series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			this.chartGanancia.Series.Add(series1);
			this.chartGanancia.Size = new System.Drawing.Size(776, 410);
			this.chartGanancia.TabIndex = 0;
			this.chartGanancia.Text = "chart1";
			// 
			// dtpInical
			// 
			this.dtpInical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInical.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpInical.Location = new System.Drawing.Point(23, 40);
			this.dtpInical.Margin = new System.Windows.Forms.Padding(4);
			this.dtpInical.Name = "dtpInical";
			this.dtpInical.Size = new System.Drawing.Size(265, 26);
			this.dtpInical.TabIndex = 1;
			this.dtpInical.ValueChanged += new System.EventHandler(this.dtpInical_ValueChanged);
			// 
			// dtpFinal
			// 
			this.dtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFinal.Location = new System.Drawing.Point(455, 40);
			this.dtpFinal.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFinal.Name = "dtpFinal";
			this.dtpFinal.Size = new System.Drawing.Size(265, 26);
			this.dtpFinal.TabIndex = 2;
			this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Fecha Inicial";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(451, 21);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fecha Final";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 242);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ganancias";
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(28, 277);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(225, 26);
			this.txtTotal.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtpFinal);
			this.groupBox1.Controls.Add(this.dtpInical);
			this.groupBox1.Controls.Add(this.chartGanancia);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 26);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(971, 508);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Periodo";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tbSalidas);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.tbEntrada);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtTotal);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(1051, 26);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(277, 335);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ganancias";
			// 
			// tbSalidas
			// 
			this.tbSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSalidas.Location = new System.Drawing.Point(28, 181);
			this.tbSalidas.Margin = new System.Windows.Forms.Padding(4);
			this.tbSalidas.Name = "tbSalidas";
			this.tbSalidas.ReadOnly = true;
			this.tbSalidas.Size = new System.Drawing.Size(225, 26);
			this.tbSalidas.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 143);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Salidas de gasto";
			// 
			// tbEntrada
			// 
			this.tbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbEntrada.Location = new System.Drawing.Point(28, 81);
			this.tbEntrada.Margin = new System.Windows.Forms.Padding(4);
			this.tbEntrada.Name = "tbEntrada";
			this.tbEntrada.ReadOnly = true;
			this.tbEntrada.Size = new System.Drawing.Size(225, 26);
			this.tbEntrada.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Entradas de dinero";
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(1207, 490);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 20;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			this.btnRegresar.MouseLeave += new System.EventHandler(this.btnRegresar_MouseLeave);
			this.btnRegresar.MouseHover += new System.EventHandler(this.btnRegresar_MouseHover);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(51, 537);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(141, 20);
			this.label14.TabIndex = 31;
			this.label14.Text = "Entrada de dinero";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(734, 535);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(138, 20);
			this.label12.TabIndex = 30;
			this.label12.Text = "Salidas de dinero";
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
			this.dgabonos.Location = new System.Drawing.Point(39, 560);
			this.dgabonos.Name = "dgabonos";
			this.dgabonos.ReadOnly = true;
			this.dgabonos.RowTemplate.Height = 24;
			this.dgabonos.Size = new System.Drawing.Size(645, 370);
			this.dgabonos.TabIndex = 29;
			this.dgabonos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgabonos_CellContentClick);
			// 
			// dggastos
			// 
			this.dggastos.AllowUserToAddRows = false;
			this.dggastos.AllowUserToDeleteRows = false;
			this.dggastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dggastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dggastos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dggastos.Location = new System.Drawing.Point(709, 558);
			this.dggastos.Name = "dggastos";
			this.dggastos.ReadOnly = true;
			this.dggastos.RowTemplate.Height = 24;
			this.dggastos.Size = new System.Drawing.Size(742, 372);
			this.dggastos.TabIndex = 28;
			// 
			// ganancia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1484, 942);
			this.ControlBox = false;
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dggastos);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.dgabonos);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ganancia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Ganancia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ganancia_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartGanancia)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgabonos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dggastos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanancia;
        private System.Windows.Forms.DateTimePicker dtpInical;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.TextBox tbSalidas;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbEntrada;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dgabonos;
		private System.Windows.Forms.DataGridView dggastos;
	}
}