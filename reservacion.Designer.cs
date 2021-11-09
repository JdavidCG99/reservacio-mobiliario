namespace Sistema_Reservaciones
{
    partial class reservacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservacion));
			this.lblFolio = new System.Windows.Forms.Label();
			this.tbFolio = new System.Windows.Forms.TextBox();
			this.btnEditFolio = new System.Windows.Forms.Button();
			this.lblFechaSalida = new System.Windows.Forms.Label();
			this.dtFechaEntrega = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbCliente = new System.Windows.Forms.TextBox();
			this.dtFechaRegreso = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.lblPorcentaje = new System.Windows.Forms.Label();
			this.rbNoBonificaion = new System.Windows.Forms.RadioButton();
			this.rbBonificacion = new System.Windows.Forms.RadioButton();
			this.lblBonificacion = new System.Windows.Forms.Label();
			this.tbFlete = new System.Windows.Forms.TextBox();
			this.lblFlete = new System.Windows.Forms.Label();
			this.tbCelular = new System.Windows.Forms.TextBox();
			this.tbNombreCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNombreDescuento = new System.Windows.Forms.Label();
			this.cbUbicacion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbiva = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.gvPedido = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.cbCategorias = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBuscadorProducto = new System.Windows.Forms.TextBox();
			this.gvProductos = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tbRestante = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbDeposito = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbAnticipo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbDescuento = new System.Windows.Forms.TextBox();
			this.lblDescuento = new System.Windows.Forms.Label();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.tbSubTotal = new System.Windows.Forms.TextBox();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.tbDescripcion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnReservar = new System.Windows.Forms.Button();
			this.btnVerificar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rbNo = new System.Windows.Forms.RadioButton();
			this.rbivasi = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.btnImp = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPedido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFolio
			// 
			this.lblFolio.AutoSize = true;
			this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFolio.Location = new System.Drawing.Point(5, 21);
			this.lblFolio.Name = "lblFolio";
			this.lblFolio.Size = new System.Drawing.Size(112, 20);
			this.lblFolio.TabIndex = 0;
			this.lblFolio.Text = "Num. de folio:";
			// 
			// tbFolio
			// 
			this.tbFolio.Enabled = false;
			this.tbFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFolio.Location = new System.Drawing.Point(133, 21);
			this.tbFolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbFolio.Multiline = true;
			this.tbFolio.Name = "tbFolio";
			this.tbFolio.Size = new System.Drawing.Size(135, 25);
			this.tbFolio.TabIndex = 1;
			this.tbFolio.TextChanged += new System.EventHandler(this.tbFolio_TextChanged);
			this.tbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFolio_KeyPress);
			// 
			// btnEditFolio
			// 
			this.btnEditFolio.Location = new System.Drawing.Point(289, 21);
			this.btnEditFolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEditFolio.Name = "btnEditFolio";
			this.btnEditFolio.Size = new System.Drawing.Size(75, 23);
			this.btnEditFolio.TabIndex = 2;
			this.btnEditFolio.Text = "Editar";
			this.btnEditFolio.UseVisualStyleBackColor = true;
			this.btnEditFolio.Click += new System.EventHandler(this.btnEditFolio_Click);
			// 
			// lblFechaSalida
			// 
			this.lblFechaSalida.AutoSize = true;
			this.lblFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFechaSalida.Location = new System.Drawing.Point(8, 66);
			this.lblFechaSalida.Name = "lblFechaSalida";
			this.lblFechaSalida.Size = new System.Drawing.Size(144, 20);
			this.lblFechaSalida.TabIndex = 3;
			this.lblFechaSalida.Text = "Fecha de entrega:";
			// 
			// dtFechaEntrega
			// 
			this.dtFechaEntrega.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFechaEntrega.Location = new System.Drawing.Point(171, 65);
			this.dtFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtFechaEntrega.Name = "dtFechaEntrega";
			this.dtFechaEntrega.Size = new System.Drawing.Size(157, 27);
			this.dtFechaEntrega.TabIndex = 4;
			this.dtFechaEntrega.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
			this.dtFechaEntrega.ValueChanged += new System.EventHandler(this.dtFechaEntrega_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbCliente);
			this.groupBox1.Controls.Add(this.dtFechaRegreso);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.lblPorcentaje);
			this.groupBox1.Controls.Add(this.rbNoBonificaion);
			this.groupBox1.Controls.Add(this.rbBonificacion);
			this.groupBox1.Controls.Add(this.lblBonificacion);
			this.groupBox1.Controls.Add(this.tbFlete);
			this.groupBox1.Controls.Add(this.lblFlete);
			this.groupBox1.Controls.Add(this.tbCelular);
			this.groupBox1.Controls.Add(this.tbNombreCliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lblNombreDescuento);
			this.groupBox1.Controls.Add(this.cbUbicacion);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dtFechaEntrega);
			this.groupBox1.Controls.Add(this.lblFechaSalida);
			this.groupBox1.Controls.Add(this.btnEditFolio);
			this.groupBox1.Controls.Add(this.tbFolio);
			this.groupBox1.Controls.Add(this.lblFolio);
			this.groupBox1.Location = new System.Drawing.Point(13, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(1159, 135);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// tbCliente
			// 
			this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCliente.Location = new System.Drawing.Point(487, 21);
			this.tbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCliente.Multiline = true;
			this.tbCliente.Name = "tbCliente";
			this.tbCliente.Size = new System.Drawing.Size(291, 29);
			this.tbCliente.TabIndex = 19;
			// 
			// dtFechaRegreso
			// 
			this.dtFechaRegreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFechaRegreso.Location = new System.Drawing.Point(171, 103);
			this.dtFechaRegreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtFechaRegreso.Name = "dtFechaRegreso";
			this.dtFechaRegreso.Size = new System.Drawing.Size(157, 27);
			this.dtFechaRegreso.TabIndex = 18;
			this.dtFechaRegreso.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
			this.dtFechaRegreso.ValueChanged += new System.EventHandler(this.dtFechaRegreso_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(5, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 20);
			this.label7.TabIndex = 17;
			this.label7.Text = "Fecha de regreso:";
			// 
			// lblPorcentaje
			// 
			this.lblPorcentaje.AutoSize = true;
			this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPorcentaje.Location = new System.Drawing.Point(960, 20);
			this.lblPorcentaje.Name = "lblPorcentaje";
			this.lblPorcentaje.Size = new System.Drawing.Size(28, 20);
			this.lblPorcentaje.TabIndex = 16;
			this.lblPorcentaje.Text = "%.";
			this.lblPorcentaje.Visible = false;
			// 
			// rbNoBonificaion
			// 
			this.rbNoBonificaion.AutoSize = true;
			this.rbNoBonificaion.Checked = true;
			this.rbNoBonificaion.Location = new System.Drawing.Point(1056, 91);
			this.rbNoBonificaion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbNoBonificaion.Name = "rbNoBonificaion";
			this.rbNoBonificaion.Size = new System.Drawing.Size(47, 21);
			this.rbNoBonificaion.TabIndex = 15;
			this.rbNoBonificaion.TabStop = true;
			this.rbNoBonificaion.Text = "No";
			this.rbNoBonificaion.UseVisualStyleBackColor = true;
			this.rbNoBonificaion.Visible = false;
			this.rbNoBonificaion.CheckedChanged += new System.EventHandler(this.rbNoBonificaion_CheckedChanged);
			// 
			// rbBonificacion
			// 
			this.rbBonificacion.AutoSize = true;
			this.rbBonificacion.Location = new System.Drawing.Point(978, 91);
			this.rbBonificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbBonificacion.Name = "rbBonificacion";
			this.rbBonificacion.Size = new System.Drawing.Size(41, 21);
			this.rbBonificacion.TabIndex = 14;
			this.rbBonificacion.Text = "Si";
			this.rbBonificacion.UseVisualStyleBackColor = true;
			this.rbBonificacion.Visible = false;
			this.rbBonificacion.CheckedChanged += new System.EventHandler(this.rbBonificacion_CheckedChanged);
			// 
			// lblBonificacion
			// 
			this.lblBonificacion.AutoSize = true;
			this.lblBonificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBonificacion.Location = new System.Drawing.Point(976, 58);
			this.lblBonificacion.Name = "lblBonificacion";
			this.lblBonificacion.Size = new System.Drawing.Size(121, 17);
			this.lblBonificacion.TabIndex = 13;
			this.lblBonificacion.Text = "Aplicar descuento";
			this.lblBonificacion.Visible = false;
			// 
			// tbFlete
			// 
			this.tbFlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFlete.Location = new System.Drawing.Point(812, 59);
			this.tbFlete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbFlete.Multiline = true;
			this.tbFlete.Name = "tbFlete";
			this.tbFlete.Size = new System.Drawing.Size(135, 25);
			this.tbFlete.TabIndex = 12;
			this.tbFlete.Text = "0";
			this.tbFlete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFlete_KeyPress);
			// 
			// lblFlete
			// 
			this.lblFlete.AutoSize = true;
			this.lblFlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFlete.Location = new System.Drawing.Point(745, 59);
			this.lblFlete.Name = "lblFlete";
			this.lblFlete.Size = new System.Drawing.Size(51, 20);
			this.lblFlete.TabIndex = 11;
			this.lblFlete.Text = "Flete:";
			// 
			// tbCelular
			// 
			this.tbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCelular.Location = new System.Drawing.Point(487, 98);
			this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCelular.Multiline = true;
			this.tbCelular.Name = "tbCelular";
			this.tbCelular.Size = new System.Drawing.Size(226, 29);
			this.tbCelular.TabIndex = 17;
			this.tbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCelular_KeyPress);
			// 
			// tbNombreCliente
			// 
			this.tbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNombreCliente.Location = new System.Drawing.Point(901, 15);
			this.tbNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbNombreCliente.Multiline = true;
			this.tbNombreCliente.Name = "tbNombreCliente";
			this.tbNombreCliente.Size = new System.Drawing.Size(249, 29);
			this.tbNombreCliente.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(389, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "Celular:";
			// 
			// lblNombreDescuento
			// 
			this.lblNombreDescuento.AutoSize = true;
			this.lblNombreDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreDescuento.Location = new System.Drawing.Point(796, 18);
			this.lblNombreDescuento.Name = "lblNombreDescuento";
			this.lblNombreDescuento.Size = new System.Drawing.Size(73, 20);
			this.lblNombreDescuento.TabIndex = 9;
			this.lblNombreDescuento.Text = "Nombre:";
			// 
			// cbUbicacion
			// 
			this.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUbicacion.FormattingEnabled = true;
			this.cbUbicacion.Location = new System.Drawing.Point(487, 64);
			this.cbUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbUbicacion.Name = "cbUbicacion";
			this.cbUbicacion.Size = new System.Drawing.Size(226, 28);
			this.cbUbicacion.TabIndex = 8;
			this.cbUbicacion.SelectedIndexChanged += new System.EventHandler(this.cbUbicacion_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(389, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Ubicacion:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(389, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cliente:";
			// 
			// tbiva
			// 
			this.tbiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbiva.Location = new System.Drawing.Point(63, 90);
			this.tbiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbiva.Multiline = true;
			this.tbiva.Name = "tbiva";
			this.tbiva.ReadOnly = true;
			this.tbiva.Size = new System.Drawing.Size(135, 25);
			this.tbiva.TabIndex = 23;
			this.tbiva.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(1186, 105);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 20);
			this.label12.TabIndex = 22;
			this.label12.Text = "IVA:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnQuitar);
			this.groupBox2.Controls.Add(this.btnActualizar);
			this.groupBox2.Controls.Add(this.gvPedido);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.cbCategorias);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtBuscadorProducto);
			this.groupBox2.Controls.Add(this.gvProductos);
			this.groupBox2.Location = new System.Drawing.Point(13, 168);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(1497, 390);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitar.Location = new System.Drawing.Point(1073, 337);
			this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(169, 34);
			this.btnQuitar.TabIndex = 21;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			this.btnQuitar.MouseLeave += new System.EventHandler(this.btnQuitar_MouseLeave);
			this.btnQuitar.MouseHover += new System.EventHandler(this.btnQuitar_MouseHover);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnActualizar.Enabled = false;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(1269, 337);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(168, 37);
			this.btnActualizar.TabIndex = 20;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnCotizar_Click);
			// 
			// gvPedido
			// 
			this.gvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvPedido.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.gvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
			this.gvPedido.GridColor = System.Drawing.Color.CornflowerBlue;
			this.gvPedido.Location = new System.Drawing.Point(720, 77);
			this.gvPedido.Margin = new System.Windows.Forms.Padding(4);
			this.gvPedido.Name = "gvPedido";
			this.gvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvPedido.Size = new System.Drawing.Size(757, 254);
			this.gvPedido.TabIndex = 9;
			this.gvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPedido_CellContentClick);
			this.gvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPedido_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 48;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.Width = 87;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.Width = 111;
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.Width = 77;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Width = 93;
			// 
			// Subtotal
			// 
			this.Subtotal.HeaderText = "Subtotal";
			this.Subtotal.Name = "Subtotal";
			this.Subtotal.Width = 89;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(268, 14);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Tipo de Producto";
			// 
			// cbCategorias
			// 
			this.cbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCategorias.FormattingEnabled = true;
			this.cbCategorias.Location = new System.Drawing.Point(272, 37);
			this.cbCategorias.Margin = new System.Windows.Forms.Padding(4);
			this.cbCategorias.Name = "cbCategorias";
			this.cbCategorias.Size = new System.Drawing.Size(185, 28);
			this.cbCategorias.TabIndex = 7;
			this.cbCategorias.Text = "Categorias";
			this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 12);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Producto";
			// 
			// txtBuscadorProducto
			// 
			this.txtBuscadorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscadorProducto.Location = new System.Drawing.Point(15, 36);
			this.txtBuscadorProducto.Margin = new System.Windows.Forms.Padding(4);
			this.txtBuscadorProducto.Name = "txtBuscadorProducto";
			this.txtBuscadorProducto.Size = new System.Drawing.Size(237, 27);
			this.txtBuscadorProducto.TabIndex = 5;
			this.txtBuscadorProducto.TextChanged += new System.EventHandler(this.txtBuscadorProducto_TextChanged);
			// 
			// gvProductos
			// 
			this.gvProductos.AllowUserToAddRows = false;
			this.gvProductos.AllowUserToDeleteRows = false;
			this.gvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gvProductos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
			this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvProductos.GridColor = System.Drawing.Color.CornflowerBlue;
			this.gvProductos.Location = new System.Drawing.Point(4, 79);
			this.gvProductos.Margin = new System.Windows.Forms.Padding(4);
			this.gvProductos.Name = "gvProductos";
			this.gvProductos.ReadOnly = true;
			this.gvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvProductos.Size = new System.Drawing.Size(708, 252);
			this.gvProductos.TabIndex = 1;
			this.gvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductos_CellDoubleClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tbRestante);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.tbDeposito);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.tbAnticipo);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.tbDescuento);
			this.groupBox3.Controls.Add(this.lblDescuento);
			this.groupBox3.Controls.Add(this.tbTotal);
			this.groupBox3.Controls.Add(this.lblTotal);
			this.groupBox3.Controls.Add(this.tbSubTotal);
			this.groupBox3.Controls.Add(this.lblSubtotal);
			this.groupBox3.Controls.Add(this.tbDescripcion);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new System.Drawing.Point(13, 580);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(1023, 160);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			// 
			// tbRestante
			// 
			this.tbRestante.Enabled = false;
			this.tbRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRestante.Location = new System.Drawing.Point(875, 114);
			this.tbRestante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbRestante.Multiline = true;
			this.tbRestante.Name = "tbRestante";
			this.tbRestante.ReadOnly = true;
			this.tbRestante.Size = new System.Drawing.Size(135, 25);
			this.tbRestante.TabIndex = 29;
			this.tbRestante.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(775, 121);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 20);
			this.label10.TabIndex = 28;
			this.label10.Text = "Restante:";
			// 
			// tbDeposito
			// 
			this.tbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDeposito.Location = new System.Drawing.Point(611, 114);
			this.tbDeposito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDeposito.Multiline = true;
			this.tbDeposito.Name = "tbDeposito";
			this.tbDeposito.Size = new System.Drawing.Size(135, 25);
			this.tbDeposito.TabIndex = 27;
			this.tbDeposito.Text = "0";
			this.tbDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(511, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 20);
			this.label9.TabIndex = 26;
			this.label9.Text = "Deposito:";
			// 
			// tbAnticipo
			// 
			this.tbAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnticipo.Location = new System.Drawing.Point(875, 74);
			this.tbAnticipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbAnticipo.Multiline = true;
			this.tbAnticipo.Name = "tbAnticipo";
			this.tbAnticipo.Size = new System.Drawing.Size(135, 25);
			this.tbAnticipo.TabIndex = 25;
			this.tbAnticipo.Text = "0";
			this.tbAnticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(781, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "Anticipo:";
			// 
			// tbDescuento
			// 
			this.tbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescuento.Location = new System.Drawing.Point(611, 74);
			this.tbDescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDescuento.Multiline = true;
			this.tbDescuento.Name = "tbDescuento";
			this.tbDescuento.Size = new System.Drawing.Size(135, 25);
			this.tbDescuento.TabIndex = 23;
			this.tbDescuento.Text = "0";
			this.tbDescuento.TextChanged += new System.EventHandler(this.tbDescuento_TextChanged);
			this.tbDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescuento_KeyPress);
			// 
			// lblDescuento
			// 
			this.lblDescuento.AutoSize = true;
			this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescuento.Location = new System.Drawing.Point(496, 78);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.Size = new System.Drawing.Size(95, 20);
			this.lblDescuento.TabIndex = 22;
			this.lblDescuento.Text = "Descuento:";
			// 
			// tbTotal
			// 
			this.tbTotal.Enabled = false;
			this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTotal.Location = new System.Drawing.Point(875, 31);
			this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbTotal.Multiline = true;
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.ReadOnly = true;
			this.tbTotal.Size = new System.Drawing.Size(135, 25);
			this.tbTotal.TabIndex = 21;
			this.tbTotal.Text = "0";
			this.tbTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotal_KeyPress);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(809, 34);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(51, 20);
			this.lblTotal.TabIndex = 20;
			this.lblTotal.Text = "Total:";
			// 
			// tbSubTotal
			// 
			this.tbSubTotal.Enabled = false;
			this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSubTotal.Location = new System.Drawing.Point(611, 30);
			this.tbSubTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbSubTotal.Multiline = true;
			this.tbSubTotal.Name = "tbSubTotal";
			this.tbSubTotal.ReadOnly = true;
			this.tbSubTotal.Size = new System.Drawing.Size(135, 25);
			this.tbSubTotal.TabIndex = 17;
			this.tbSubTotal.Text = "0";
			this.tbSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSubTotal_KeyPress);
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtotal.Location = new System.Drawing.Point(511, 33);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(80, 20);
			this.lblSubtotal.TabIndex = 16;
			this.lblSubtotal.Text = "SubTotal:";
			// 
			// tbDescripcion
			// 
			this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescripcion.Location = new System.Drawing.Point(13, 57);
			this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDescripcion.Multiline = true;
			this.tbDescripcion.Name = "tbDescripcion";
			this.tbDescripcion.Size = new System.Drawing.Size(444, 70);
			this.tbDescripcion.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(253, 20);
			this.label4.TabIndex = 18;
			this.label4.Text = "Descripcion de lugar de entrega:";
			// 
			// btnReservar
			// 
			this.btnReservar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnReservar.Enabled = false;
			this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReservar.Location = new System.Drawing.Point(1080, 682);
			this.btnReservar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReservar.Name = "btnReservar";
			this.btnReservar.Size = new System.Drawing.Size(137, 52);
			this.btnReservar.TabIndex = 10;
			this.btnReservar.Text = "Reservar";
			this.btnReservar.UseVisualStyleBackColor = false;
			this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
			this.btnReservar.MouseLeave += new System.EventHandler(this.btnReservar_MouseLeave);
			this.btnReservar.MouseHover += new System.EventHandler(this.btnReservar_MouseHover);
			// 
			// btnVerificar
			// 
			this.btnVerificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificar.Location = new System.Drawing.Point(1080, 610);
			this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(137, 52);
			this.btnVerificar.TabIndex = 11;
			this.btnVerificar.Text = "Cotizar";
			this.btnVerificar.UseVisualStyleBackColor = false;
			this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
			this.btnVerificar.MouseLeave += new System.EventHandler(this.btnVerificar_MouseLeave);
			this.btnVerificar.MouseHover += new System.EventHandler(this.btnVerificar_MouseHover);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(1403, 60);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 22;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			this.btnRegresar.MouseLeave += new System.EventHandler(this.btnRegresar_MouseLeave);
			this.btnRegresar.MouseHover += new System.EventHandler(this.btnRegresar_MouseHover);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tbiva);
			this.groupBox4.Controls.Add(this.rbNo);
			this.groupBox4.Controls.Add(this.rbivasi);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Location = new System.Drawing.Point(1178, 11);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(218, 134);
			this.groupBox4.TabIndex = 24;
			this.groupBox4.TabStop = false;
			// 
			// rbNo
			// 
			this.rbNo.AutoSize = true;
			this.rbNo.Checked = true;
			this.rbNo.Location = new System.Drawing.Point(132, 53);
			this.rbNo.Name = "rbNo";
			this.rbNo.Size = new System.Drawing.Size(47, 21);
			this.rbNo.TabIndex = 2;
			this.rbNo.TabStop = true;
			this.rbNo.Text = "No";
			this.rbNo.UseVisualStyleBackColor = true;
			this.rbNo.CheckedChanged += new System.EventHandler(this.rbivano_CheckedChanged);
			this.rbNo.Click += new System.EventHandler(this.rbNo_Click);
			// 
			// rbivasi
			// 
			this.rbivasi.AutoSize = true;
			this.rbivasi.Location = new System.Drawing.Point(63, 53);
			this.rbivasi.Name = "rbivasi";
			this.rbivasi.Size = new System.Drawing.Size(41, 21);
			this.rbivasi.TabIndex = 1;
			this.rbivasi.Text = "Si";
			this.rbivasi.UseVisualStyleBackColor = true;
			this.rbivasi.CheckedChanged += new System.EventHandler(this.rbivasi_CheckedChanged);
			this.rbivasi.Click += new System.EventHandler(this.rbivasi_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(77, 25);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 17);
			this.label11.TabIndex = 0;
			this.label11.Text = "Aplicar iva";
			// 
			// btnImp
			// 
			this.btnImp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnImp.Enabled = false;
			this.btnImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImp.Location = new System.Drawing.Point(1353, 669);
			this.btnImp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnImp.Name = "btnImp";
			this.btnImp.Size = new System.Drawing.Size(137, 52);
			this.btnImp.TabIndex = 25;
			this.btnImp.Text = "Imprimir vista previa";
			this.btnImp.UseVisualStyleBackColor = false;
			this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
			// 
			// reservacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1526, 753);
			this.ControlBox = false;
			this.Controls.Add(this.btnImp);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnVerificar);
			this.Controls.Add(this.btnReservar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "reservacion";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Reservacion";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.reservacion_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvPedido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox tbFolio;
        private System.Windows.Forms.Button btnEditFolio;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.DateTimePicker dtFechaEntrega;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbUbicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblNombreDescuento;
        private System.Windows.Forms.TextBox tbFlete;
        private System.Windows.Forms.Label lblFlete;
        private System.Windows.Forms.RadioButton rbNoBonificaion;
        private System.Windows.Forms.RadioButton rbBonificacion;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscadorProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.DataGridView gvPedido;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.DateTimePicker dtFechaRegreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox tbAnticipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDeposito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRestante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView gvProductos;
		private System.Windows.Forms.TextBox tbiva;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.RadioButton rbivasi;
		private System.Windows.Forms.RadioButton rbNo;
		private System.Windows.Forms.Button btnImp;
		private System.Windows.Forms.TextBox tbCliente;
	}
}