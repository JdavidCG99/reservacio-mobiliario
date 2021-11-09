namespace Sistema_Reservaciones
{
    partial class catalogoFletes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalogoFletes));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnsalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtBuscador = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gvFlete = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvFlete)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnsalir);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Controls.Add(this.txtBuscador);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(21, 32);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(941, 100);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ingese la localidad a buscar";
			// 
			// btnsalir
			// 
			this.btnsalir.BackColor = System.Drawing.Color.White;
			this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsalir.Location = new System.Drawing.Point(757, 36);
			this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(120, 43);
			this.btnsalir.TabIndex = 5;
			this.btnsalir.Text = "Regresar";
			this.btnsalir.UseVisualStyleBackColor = false;
			this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
			this.btnsalir.MouseLeave += new System.EventHandler(this.btnsalir_MouseLeave);
			this.btnsalir.MouseHover += new System.EventHandler(this.btnsalir_MouseHover);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Localidad";
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.White;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(615, 36);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(120, 43);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
			this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover);
			// 
			// txtBuscador
			// 
			this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscador.Location = new System.Drawing.Point(27, 54);
			this.txtBuscador.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscador.Name = "txtBuscador";
			this.txtBuscador.Size = new System.Drawing.Size(351, 26);
			this.txtBuscador.TabIndex = 2;
			this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
			this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.gvFlete);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(21, 156);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(957, 516);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Localidades Activas";
			// 
			// gvFlete
			// 
			this.gvFlete.AllowUserToAddRows = false;
			this.gvFlete.AllowUserToDeleteRows = false;
			this.gvFlete.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvFlete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvFlete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gvFlete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvFlete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvFlete.Location = new System.Drawing.Point(56, 36);
			this.gvFlete.Margin = new System.Windows.Forms.Padding(4);
			this.gvFlete.Name = "gvFlete";
			this.gvFlete.ReadOnly = true;
			this.gvFlete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvFlete.Size = new System.Drawing.Size(821, 439);
			this.gvFlete.TabIndex = 13;
			this.gvFlete.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFlete_CellContentDoubleClick);
			// 
			// catalogoFletes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1106, 745);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "catalogoFletes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Flietes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvFlete)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.DataGridView gvFlete;
    }
}