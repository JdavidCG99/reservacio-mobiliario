namespace Sistema_Reservaciones
{
    partial class verReservaciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verReservaciones));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.tbFolio = new System.Windows.Forms.TextBox();
			this.lblFolio = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.tbBuscarCleinte = new System.Windows.Forms.TextBox();
			this.gvReservaciones = new System.Windows.Forms.DataGridView();
			this.gvProductos = new System.Windows.Forms.DataGridView();
			this.btnTicket = new System.Windows.Forms.Button();
			this.btnAgregarProductos = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbDeposito = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbRestante = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbFlete = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbMulta = new System.Windows.Forms.TextBox();
			this.tbAnticipo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbAbono = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnLiquidar = new System.Windows.Forms.Button();
			this.btnAbonar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnFechas = new System.Windows.Forms.Button();
			this.dtFechaRegreso = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtFechaEntrega = new System.Windows.Forms.DateTimePicker();
			this.lblFechaSalida = new System.Windows.Forms.Label();
			this.btnActu = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tbTotalDeuda = new System.Windows.Forms.TextBox();
			this.btnTotalReserva = new System.Windows.Forms.Button();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvReservaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.tbFolio);
			this.groupBox1.Controls.Add(this.lblFolio);
			this.groupBox1.Controls.Add(this.lblCliente);
			this.groupBox1.Controls.Add(this.tbBuscarCleinte);
			this.groupBox1.Location = new System.Drawing.Point(13, 4);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(728, 73);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
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
			this.tbFolio.TextChanged += new System.EventHandler(this.tbFolio_TextChanged);
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
			this.tbBuscarCleinte.Size = new System.Drawing.Size(237, 27);
			this.tbBuscarCleinte.TabIndex = 9;
			this.tbBuscarCleinte.TextChanged += new System.EventHandler(this.tbBuscarCleinte_TextChanged);
			this.tbBuscarCleinte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarCleinte_KeyPress);
			// 
			// gvReservaciones
			// 
			this.gvReservaciones.AllowUserToAddRows = false;
			this.gvReservaciones.AllowUserToDeleteRows = false;
			this.gvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gvReservaciones.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.gvReservaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.gvReservaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvReservaciones.GridColor = System.Drawing.Color.RoyalBlue;
			this.gvReservaciones.Location = new System.Drawing.Point(13, 85);
			this.gvReservaciones.Margin = new System.Windows.Forms.Padding(4);
			this.gvReservaciones.Name = "gvReservaciones";
			this.gvReservaciones.ReadOnly = true;
			this.gvReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvReservaciones.Size = new System.Drawing.Size(1182, 378);
			this.gvReservaciones.TabIndex = 1;
			this.gvReservaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvReservaciones_CellDoubleClick);
			// 
			// gvProductos
			// 
			this.gvProductos.AllowUserToAddRows = false;
			this.gvProductos.AllowUserToDeleteRows = false;
			this.gvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.gvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.gvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvProductos.GridColor = System.Drawing.Color.RoyalBlue;
			this.gvProductos.Location = new System.Drawing.Point(13, 491);
			this.gvProductos.Margin = new System.Windows.Forms.Padding(4);
			this.gvProductos.Name = "gvProductos";
			this.gvProductos.ReadOnly = true;
			this.gvProductos.Size = new System.Drawing.Size(738, 265);
			this.gvProductos.TabIndex = 2;
			// 
			// btnTicket
			// 
			this.btnTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTicket.Location = new System.Drawing.Point(410, 780);
			this.btnTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTicket.Name = "btnTicket";
			this.btnTicket.Size = new System.Drawing.Size(219, 36);
			this.btnTicket.TabIndex = 3;
			this.btnTicket.Text = "Reimprimir comprobante.";
			this.btnTicket.UseVisualStyleBackColor = false;
			this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
			this.btnTicket.MouseLeave += new System.EventHandler(this.btnTicket_MouseLeave);
			this.btnTicket.MouseHover += new System.EventHandler(this.btnTicket_MouseHover);
			// 
			// btnAgregarProductos
			// 
			this.btnAgregarProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAgregarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProductos.Location = new System.Drawing.Point(764, 491);
			this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAgregarProductos.Name = "btnAgregarProductos";
			this.btnAgregarProductos.Size = new System.Drawing.Size(192, 31);
			this.btnAgregarProductos.TabIndex = 4;
			this.btnAgregarProductos.Text = "Editar Reservacion.";
			this.btnAgregarProductos.UseVisualStyleBackColor = false;
			this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
			this.btnAgregarProductos.MouseLeave += new System.EventHandler(this.btnAgregarProductos_MouseLeave);
			this.btnAgregarProductos.MouseHover += new System.EventHandler(this.btnAgregarProductos_MouseHover);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(1004, 491);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(201, 31);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Cancelar reservacion.";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
			this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover);
			// 
			// tbId
			// 
			this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbId.Location = new System.Drawing.Point(151, 20);
			this.tbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbId.Multiline = true;
			this.tbId.Name = "tbId";
			this.tbId.ReadOnly = true;
			this.tbId.Size = new System.Drawing.Size(135, 25);
			this.tbId.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Id reservacion:";
			// 
			// tbTotal
			// 
			this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTotal.Location = new System.Drawing.Point(151, 142);
			this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbTotal.Multiline = true;
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.ReadOnly = true;
			this.tbTotal.Size = new System.Drawing.Size(135, 25);
			this.tbTotal.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(83, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "Total:";
			// 
			// tbDeposito
			// 
			this.tbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDeposito.Location = new System.Drawing.Point(151, 62);
			this.tbDeposito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDeposito.Multiline = true;
			this.tbDeposito.Name = "tbDeposito";
			this.tbDeposito.ReadOnly = true;
			this.tbDeposito.Size = new System.Drawing.Size(135, 25);
			this.tbDeposito.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 17;
			this.label3.Text = "Deposito:";
			// 
			// tbRestante
			// 
			this.tbRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRestante.Location = new System.Drawing.Point(151, 256);
			this.tbRestante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbRestante.Multiline = true;
			this.tbRestante.Name = "tbRestante";
			this.tbRestante.ReadOnly = true;
			this.tbRestante.Size = new System.Drawing.Size(135, 25);
			this.tbRestante.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(53, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 20);
			this.label4.TabIndex = 19;
			this.label4.Text = "Restante:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbFlete);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.tbMulta);
			this.groupBox2.Controls.Add(this.tbAnticipo);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.tbAbono);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.btnLiquidar);
			this.groupBox2.Controls.Add(this.btnAbonar);
			this.groupBox2.Controls.Add(this.tbRestante);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.tbDeposito);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.tbId);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tbTotal);
			this.groupBox2.Location = new System.Drawing.Point(776, 526);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(448, 351);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Reservacion seleccionada";
			// 
			// tbFlete
			// 
			this.tbFlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFlete.Location = new System.Drawing.Point(151, 105);
			this.tbFlete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbFlete.Multiline = true;
			this.tbFlete.Name = "tbFlete";
			this.tbFlete.ReadOnly = true;
			this.tbFlete.Size = new System.Drawing.Size(135, 25);
			this.tbFlete.TabIndex = 31;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(83, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 20);
			this.label9.TabIndex = 32;
			this.label9.Text = "Flete:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(312, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 20);
			this.label7.TabIndex = 30;
			this.label7.Text = "Agregar multa:";
			// 
			// tbMulta
			// 
			this.tbMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbMulta.Location = new System.Drawing.Point(307, 62);
			this.tbMulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbMulta.Multiline = true;
			this.tbMulta.Name = "tbMulta";
			this.tbMulta.Size = new System.Drawing.Size(135, 25);
			this.tbMulta.TabIndex = 29;
			this.tbMulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.tbMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMulta_KeyPress);
			// 
			// tbAnticipo
			// 
			this.tbAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnticipo.Location = new System.Drawing.Point(151, 182);
			this.tbAnticipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbAnticipo.Multiline = true;
			this.tbAnticipo.Name = "tbAnticipo";
			this.tbAnticipo.ReadOnly = true;
			this.tbAnticipo.Size = new System.Drawing.Size(135, 25);
			this.tbAnticipo.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(60, 185);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 20);
			this.label6.TabIndex = 28;
			this.label6.Text = "Anticipo:";
			// 
			// tbAbono
			// 
			this.tbAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAbono.Location = new System.Drawing.Point(151, 219);
			this.tbAbono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbAbono.Multiline = true;
			this.tbAbono.Name = "tbAbono";
			this.tbAbono.Size = new System.Drawing.Size(135, 25);
			this.tbAbono.TabIndex = 25;
			this.tbAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAbono_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(67, 222);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 20);
			this.label8.TabIndex = 26;
			this.label8.Text = "Abonar:";
			// 
			// btnLiquidar
			// 
			this.btnLiquidar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLiquidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLiquidar.Location = new System.Drawing.Point(162, 300);
			this.btnLiquidar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLiquidar.Name = "btnLiquidar";
			this.btnLiquidar.Size = new System.Drawing.Size(124, 34);
			this.btnLiquidar.TabIndex = 24;
			this.btnLiquidar.Text = "Liquidar";
			this.btnLiquidar.UseVisualStyleBackColor = false;
			this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
			this.btnLiquidar.MouseLeave += new System.EventHandler(this.btnLiquidar_MouseLeave);
			this.btnLiquidar.MouseHover += new System.EventHandler(this.btnLiquidar_MouseHover);
			// 
			// btnAbonar
			// 
			this.btnAbonar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbonar.Location = new System.Drawing.Point(318, 214);
			this.btnAbonar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAbonar.Name = "btnAbonar";
			this.btnAbonar.Size = new System.Drawing.Size(124, 34);
			this.btnAbonar.TabIndex = 23;
			this.btnAbonar.Text = "Abonar";
			this.btnAbonar.UseVisualStyleBackColor = false;
			this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
			this.btnAbonar.MouseLeave += new System.EventHandler(this.btnAbonar_MouseLeave);
			this.btnAbonar.MouseHover += new System.EventHandler(this.btnAbonar_MouseHover);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(988, 19);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 23;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			this.btnRegresar.MouseLeave += new System.EventHandler(this.btnRegresar_MouseLeave);
			this.btnRegresar.MouseHover += new System.EventHandler(this.btnRegresar_MouseHover);
			// 
			// btnFechas
			// 
			this.btnFechas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechas.Location = new System.Drawing.Point(82, 785);
			this.btnFechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnFechas.Name = "btnFechas";
			this.btnFechas.Size = new System.Drawing.Size(192, 31);
			this.btnFechas.TabIndex = 24;
			this.btnFechas.Text = "Cambiar fechas.";
			this.btnFechas.UseVisualStyleBackColor = false;
			this.btnFechas.Click += new System.EventHandler(this.btnFechas_Click);
			// 
			// dtFechaRegreso
			// 
			this.dtFechaRegreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaRegreso.Enabled = false;
			this.dtFechaRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFechaRegreso.Location = new System.Drawing.Point(194, 875);
			this.dtFechaRegreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtFechaRegreso.Name = "dtFechaRegreso";
			this.dtFechaRegreso.Size = new System.Drawing.Size(157, 27);
			this.dtFechaRegreso.TabIndex = 28;
			this.dtFechaRegreso.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Enabled = false;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(28, 882);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 20);
			this.label5.TabIndex = 27;
			this.label5.Text = "Fecha de regreso:";
			// 
			// dtFechaEntrega
			// 
			this.dtFechaEntrega.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaEntrega.Enabled = false;
			this.dtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFechaEntrega.Location = new System.Drawing.Point(194, 837);
			this.dtFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtFechaEntrega.Name = "dtFechaEntrega";
			this.dtFechaEntrega.Size = new System.Drawing.Size(157, 27);
			this.dtFechaEntrega.TabIndex = 26;
			this.dtFechaEntrega.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
			// 
			// lblFechaSalida
			// 
			this.lblFechaSalida.AutoSize = true;
			this.lblFechaSalida.Enabled = false;
			this.lblFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaSalida.Location = new System.Drawing.Point(31, 838);
			this.lblFechaSalida.Name = "lblFechaSalida";
			this.lblFechaSalida.Size = new System.Drawing.Size(144, 20);
			this.lblFechaSalida.TabIndex = 25;
			this.lblFechaSalida.Text = "Fecha de entrega:";
			// 
			// btnActu
			// 
			this.btnActu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnActu.Enabled = false;
			this.btnActu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActu.Location = new System.Drawing.Point(82, 917);
			this.btnActu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnActu.Name = "btnActu";
			this.btnActu.Size = new System.Drawing.Size(192, 31);
			this.btnActu.TabIndex = 29;
			this.btnActu.Text = "Actualizar";
			this.btnActu.UseVisualStyleBackColor = false;
			this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tbTotalDeuda);
			this.groupBox3.Controls.Add(this.btnTotalReserva);
			this.groupBox3.Controls.Add(this.radioButton2);
			this.groupBox3.Controls.Add(this.radioButton1);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Location = new System.Drawing.Point(1220, 85);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 310);
			this.groupBox3.TabIndex = 30;
			this.groupBox3.TabStop = false;
			// 
			// tbTotalDeuda
			// 
			this.tbTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTotalDeuda.Location = new System.Drawing.Point(81, 199);
			this.tbTotalDeuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbTotalDeuda.Multiline = true;
			this.tbTotalDeuda.Name = "tbTotalDeuda";
			this.tbTotalDeuda.ReadOnly = true;
			this.tbTotalDeuda.Size = new System.Drawing.Size(135, 25);
			this.tbTotalDeuda.TabIndex = 33;
			// 
			// btnTotalReserva
			// 
			this.btnTotalReserva.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTotalReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTotalReserva.Location = new System.Drawing.Point(81, 122);
			this.btnTotalReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTotalReserva.Name = "btnTotalReserva";
			this.btnTotalReserva.Size = new System.Drawing.Size(135, 34);
			this.btnTotalReserva.TabIndex = 33;
			this.btnTotalReserva.Text = "Total:";
			this.btnTotalReserva.UseVisualStyleBackColor = false;
			this.btnTotalReserva.Click += new System.EventHandler(this.btnTotalReserva_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(158, 63);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(47, 21);
			this.radioButton2.TabIndex = 35;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "No";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(69, 63);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(41, 21);
			this.radioButton1.TabIndex = 34;
			this.radioButton1.Text = "Si";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 18);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(226, 20);
			this.label10.TabIndex = 33;
			this.label10.Text = "Ver solo pendientes de pago:";
			// 
			// verReservaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1537, 968);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnActu);
			this.Controls.Add(this.dtFechaRegreso);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtFechaEntrega);
			this.Controls.Add(this.lblFechaSalida);
			this.Controls.Add(this.btnFechas);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregarProductos);
			this.Controls.Add(this.btnTicket);
			this.Controls.Add(this.gvProductos);
			this.Controls.Add(this.gvReservaciones);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "verReservaciones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Reservaciones";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.verReservaciones_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvReservaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFolio;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tbBuscarCleinte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gvReservaciones;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRestante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.TextBox tbAbono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAnticipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMulta;
        private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnFechas;
		private System.Windows.Forms.DateTimePicker dtFechaRegreso;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtFechaEntrega;
		private System.Windows.Forms.Label lblFechaSalida;
		private System.Windows.Forms.Button btnActu;
		private System.Windows.Forms.TextBox tbFlete;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox tbTotalDeuda;
		private System.Windows.Forms.Button btnTotalReserva;
	}
}