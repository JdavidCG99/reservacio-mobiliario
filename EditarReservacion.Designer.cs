namespace Sistema_Reservaciones
{
    partial class EditarReservacion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarReservacion));
			this.btnVerificar = new System.Windows.Forms.Button();
			this.btnReservar = new System.Windows.Forms.Button();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gvNewProducts = new System.Windows.Forms.DataGridView();
			this.Idp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Preciop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.gvPedido = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.cbCategorias = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBuscadorProducto = new System.Windows.Forms.TextBox();
			this.gvProductos = new System.Windows.Forms.DataGridView();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tbiva = new System.Windows.Forms.TextBox();
			this.rbNo = new System.Windows.Forms.RadioButton();
			this.rbivasi = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.lblFolio = new System.Windows.Forms.Label();
			this.tbFolio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbUbicacion = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbFleteCosto = new System.Windows.Forms.TextBox();
			this.rnNoflete = new System.Windows.Forms.RadioButton();
			this.rbFlete = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.cbCliente = new System.Windows.Forms.TextBox();
			this.tbCelular = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvNewProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvPedido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnVerificar
			// 
			this.btnVerificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnVerificar.Enabled = false;
			this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerificar.Location = new System.Drawing.Point(1025, 601);
			this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(137, 52);
			this.btnVerificar.TabIndex = 16;
			this.btnVerificar.Text = "Cotizar";
			this.btnVerificar.UseVisualStyleBackColor = false;
			this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
			this.btnVerificar.MouseLeave += new System.EventHandler(this.btnVerificar_MouseLeave);
			this.btnVerificar.MouseHover += new System.EventHandler(this.btnVerificar_MouseHover);
			// 
			// btnReservar
			// 
			this.btnReservar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReservar.Location = new System.Drawing.Point(1140, 17);
			this.btnReservar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReservar.Name = "btnReservar";
			this.btnReservar.Size = new System.Drawing.Size(137, 52);
			this.btnReservar.TabIndex = 15;
			this.btnReservar.Text = "Actualizar";
			this.btnReservar.UseVisualStyleBackColor = false;
			this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
			this.btnReservar.MouseLeave += new System.EventHandler(this.btnReservar_MouseLeave);
			this.btnReservar.MouseHover += new System.EventHandler(this.btnReservar_MouseHover);
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
			this.groupBox3.Location = new System.Drawing.Point(12, 544);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(979, 146);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			// 
			// tbRestante
			// 
			this.tbRestante.Enabled = false;
			this.tbRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbRestante.Location = new System.Drawing.Point(837, 114);
			this.tbRestante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbRestante.Multiline = true;
			this.tbRestante.Name = "tbRestante";
			this.tbRestante.ReadOnly = true;
			this.tbRestante.Size = new System.Drawing.Size(135, 25);
			this.tbRestante.TabIndex = 29;
			this.tbRestante.Text = "0";
			this.tbRestante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRestante_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(737, 121);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 20);
			this.label10.TabIndex = 28;
			this.label10.Text = "Restante:";
			// 
			// tbDeposito
			// 
			this.tbDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDeposito.Location = new System.Drawing.Point(583, 116);
			this.tbDeposito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDeposito.Multiline = true;
			this.tbDeposito.Name = "tbDeposito";
			this.tbDeposito.Size = new System.Drawing.Size(135, 25);
			this.tbDeposito.TabIndex = 27;
			this.tbDeposito.Text = "0";
			this.tbDeposito.TextChanged += new System.EventHandler(this.tbDeposito_TextChanged);
			this.tbDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeposito_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(483, 119);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 20);
			this.label9.TabIndex = 26;
			this.label9.Text = "Deposito:";
			// 
			// tbAnticipo
			// 
			this.tbAnticipo.Enabled = false;
			this.tbAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAnticipo.Location = new System.Drawing.Point(837, 74);
			this.tbAnticipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbAnticipo.Multiline = true;
			this.tbAnticipo.Name = "tbAnticipo";
			this.tbAnticipo.ReadOnly = true;
			this.tbAnticipo.Size = new System.Drawing.Size(135, 25);
			this.tbAnticipo.TabIndex = 25;
			this.tbAnticipo.Text = "0";
			this.tbAnticipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAnticipo_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(737, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "Anticipo";
			// 
			// tbDescuento
			// 
			this.tbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescuento.Location = new System.Drawing.Point(583, 75);
			this.tbDescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDescuento.Multiline = true;
			this.tbDescuento.Name = "tbDescuento";
			this.tbDescuento.Size = new System.Drawing.Size(135, 25);
			this.tbDescuento.TabIndex = 23;
			this.tbDescuento.Text = "0";
			this.tbDescuento.TextChanged += new System.EventHandler(this.tbDescuento_TextChanged);
			this.tbDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescuento_KeyPress_1);
			// 
			// lblDescuento
			// 
			this.lblDescuento.AutoSize = true;
			this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescuento.Location = new System.Drawing.Point(468, 79);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.Size = new System.Drawing.Size(95, 20);
			this.lblDescuento.TabIndex = 22;
			this.lblDescuento.Text = "Descuento:";
			// 
			// tbTotal
			// 
			this.tbTotal.Enabled = false;
			this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTotal.Location = new System.Drawing.Point(837, 31);
			this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbTotal.Multiline = true;
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.ReadOnly = true;
			this.tbTotal.Size = new System.Drawing.Size(135, 25);
			this.tbTotal.TabIndex = 21;
			this.tbTotal.Text = "0";
			this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
			this.tbTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotal_KeyPress_1);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(772, 34);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(51, 20);
			this.lblTotal.TabIndex = 20;
			this.lblTotal.Text = "Total:";
			// 
			// tbSubTotal
			// 
			this.tbSubTotal.Enabled = false;
			this.tbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSubTotal.Location = new System.Drawing.Point(583, 31);
			this.tbSubTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbSubTotal.Multiline = true;
			this.tbSubTotal.Name = "tbSubTotal";
			this.tbSubTotal.ReadOnly = true;
			this.tbSubTotal.Size = new System.Drawing.Size(135, 25);
			this.tbSubTotal.TabIndex = 17;
			this.tbSubTotal.Text = "0";
			this.tbSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSubTotal_KeyPress_1);
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtotal.Location = new System.Drawing.Point(483, 34);
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
			this.tbDescripcion.Size = new System.Drawing.Size(433, 70);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.gvNewProducts);
			this.groupBox2.Controls.Add(this.btnQuitar);
			this.groupBox2.Controls.Add(this.btnActualizar);
			this.groupBox2.Controls.Add(this.gvPedido);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.cbCategorias);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtBuscadorProducto);
			this.groupBox2.Controls.Add(this.gvProductos);
			this.groupBox2.Location = new System.Drawing.Point(12, 150);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(1509, 390);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			// 
			// gvNewProducts
			// 
			this.gvNewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gvNewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvNewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvNewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idp,
            this.Nombrep,
            this.Descripcion,
            this.Preciop,
            this.Cantidad,
            this.SubTotal});
			this.gvNewProducts.Location = new System.Drawing.Point(948, 79);
			this.gvNewProducts.Margin = new System.Windows.Forms.Padding(4);
			this.gvNewProducts.Name = "gvNewProducts";
			this.gvNewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvNewProducts.Size = new System.Drawing.Size(554, 252);
			this.gvNewProducts.TabIndex = 21;
			this.gvNewProducts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNewProducts_CellContentDoubleClick);
			this.gvNewProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNewProducts_CellEndEdit);
			this.gvNewProducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNewProducts_CellValueChanged);
			this.gvNewProducts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvNewProducts_RowsAdded);
			// 
			// Idp
			// 
			this.Idp.HeaderText = "Id";
			this.Idp.Name = "Idp";
			this.Idp.ReadOnly = true;
			this.Idp.Width = 48;
			// 
			// Nombrep
			// 
			this.Nombrep.HeaderText = "Nombre";
			this.Nombrep.Name = "Nombrep";
			this.Nombrep.ReadOnly = true;
			this.Nombrep.Width = 87;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Width = 111;
			// 
			// Preciop
			// 
			this.Preciop.HeaderText = "Precio";
			this.Preciop.Name = "Preciop";
			this.Preciop.ReadOnly = true;
			this.Preciop.Width = 77;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Width = 93;
			// 
			// SubTotal
			// 
			this.SubTotal.HeaderText = "SubTotal";
			this.SubTotal.Name = "SubTotal";
			this.SubTotal.ReadOnly = true;
			this.SubTotal.Width = 94;
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitar.Location = new System.Drawing.Point(1304, 32);
			this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(136, 34);
			this.btnQuitar.TabIndex = 22;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
			this.btnQuitar.MouseLeave += new System.EventHandler(this.btnQuitar_MouseLeave_1);
			this.btnQuitar.MouseHover += new System.EventHandler(this.btnQuitar_MouseHover);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnActualizar.Enabled = false;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(1190, 337);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(168, 37);
			this.btnActualizar.TabIndex = 20;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// gvPedido
			// 
			this.gvPedido.AllowUserToAddRows = false;
			this.gvPedido.AllowUserToDeleteRows = false;
			this.gvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.gvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.gvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvPedido.Location = new System.Drawing.Point(497, 79);
			this.gvPedido.Margin = new System.Windows.Forms.Padding(4);
			this.gvPedido.Name = "gvPedido";
			this.gvPedido.ReadOnly = true;
			this.gvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvPedido.Size = new System.Drawing.Size(443, 252);
			this.gvPedido.TabIndex = 9;
			this.gvPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPedido_CellDoubleClick);
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
			this.gvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvProductos.Location = new System.Drawing.Point(4, 79);
			this.gvProductos.Margin = new System.Windows.Forms.Padding(4);
			this.gvProductos.Name = "gvProductos";
			this.gvProductos.ReadOnly = true;
			this.gvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvProductos.Size = new System.Drawing.Size(485, 252);
			this.gvProductos.TabIndex = 1;
			this.gvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProductos_CellDoubleClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(1316, 19);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(121, 44);
			this.btnRegresar.TabIndex = 24;
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
			this.groupBox4.Location = new System.Drawing.Point(898, 17);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(218, 125);
			this.groupBox4.TabIndex = 25;
			this.groupBox4.TabStop = false;
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
			this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
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
			this.tbFolio.ReadOnly = true;
			this.tbFolio.Size = new System.Drawing.Size(135, 25);
			this.tbFolio.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Cliente:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(384, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Ubicacion:";
			// 
			// cbUbicacion
			// 
			this.cbUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUbicacion.FormattingEnabled = true;
			this.cbUbicacion.Location = new System.Drawing.Point(483, 18);
			this.cbUbicacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbUbicacion.Name = "cbUbicacion";
			this.cbUbicacion.Size = new System.Drawing.Size(198, 28);
			this.cbUbicacion.TabIndex = 8;
			this.cbUbicacion.SelectedIndexChanged += new System.EventHandler(this.cbUbicacion_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbFleteCosto);
			this.groupBox1.Controls.Add(this.rnNoflete);
			this.groupBox1.Controls.Add(this.rbFlete);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.cbCliente);
			this.groupBox1.Controls.Add(this.tbCelular);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbUbicacion);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tbFolio);
			this.groupBox1.Controls.Add(this.lblFolio);
			this.groupBox1.Location = new System.Drawing.Point(12, 11);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(862, 135);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			// 
			// tbFleteCosto
			// 
			this.tbFleteCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbFleteCosto.Location = new System.Drawing.Point(705, 18);
			this.tbFleteCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbFleteCosto.Multiline = true;
			this.tbFleteCosto.Name = "tbFleteCosto";
			this.tbFleteCosto.ReadOnly = true;
			this.tbFleteCosto.Size = new System.Drawing.Size(135, 25);
			this.tbFleteCosto.TabIndex = 27;
			this.tbFleteCosto.Text = "0";
			// 
			// rnNoflete
			// 
			this.rnNoflete.AutoSize = true;
			this.rnNoflete.Checked = true;
			this.rnNoflete.Location = new System.Drawing.Point(788, 73);
			this.rnNoflete.Name = "rnNoflete";
			this.rnNoflete.Size = new System.Drawing.Size(47, 21);
			this.rnNoflete.TabIndex = 26;
			this.rnNoflete.TabStop = true;
			this.rnNoflete.Text = "No";
			this.rnNoflete.UseVisualStyleBackColor = true;
			// 
			// rbFlete
			// 
			this.rbFlete.AutoSize = true;
			this.rbFlete.Location = new System.Drawing.Point(719, 73);
			this.rbFlete.Name = "rbFlete";
			this.rbFlete.Size = new System.Drawing.Size(41, 21);
			this.rbFlete.TabIndex = 25;
			this.rbFlete.Text = "Si";
			this.rbFlete.UseVisualStyleBackColor = true;
			this.rbFlete.Click += new System.EventHandler(this.rbFlete_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(722, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 17);
			this.label7.TabIndex = 24;
			this.label7.Text = "Cambio el flete";
			// 
			// cbCliente
			// 
			this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCliente.Location = new System.Drawing.Point(9, 92);
			this.cbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCliente.Multiline = true;
			this.cbCliente.Name = "cbCliente";
			this.cbCliente.Size = new System.Drawing.Size(370, 29);
			this.cbCliente.TabIndex = 20;
			// 
			// tbCelular
			// 
			this.tbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCelular.Location = new System.Drawing.Point(483, 68);
			this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbCelular.Multiline = true;
			this.tbCelular.Name = "tbCelular";
			this.tbCelular.Size = new System.Drawing.Size(209, 29);
			this.tbCelular.TabIndex = 19;
			this.tbCelular.TextChanged += new System.EventHandler(this.tbCelular_TextChanged);
			this.tbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCelular_KeyPress_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(385, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Celular:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// EditarReservacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1533, 753);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnVerificar);
			this.Controls.Add(this.btnReservar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(50, 50);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.Name = "EditarReservacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Editar Reservacion";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.EditarReservacion_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvNewProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvPedido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvProductos)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbRestante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDeposito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView gvPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscadorProducto;
        private System.Windows.Forms.DataGridView gvProductos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox tbAnticipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gvNewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox tbiva;
		private System.Windows.Forms.RadioButton rbNo;
		private System.Windows.Forms.RadioButton rbivasi;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblFolio;
		private System.Windows.Forms.TextBox tbFolio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbUbicacion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbCelular;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox cbCliente;
		private System.Windows.Forms.TextBox tbFleteCosto;
		private System.Windows.Forms.RadioButton rnNoflete;
		private System.Windows.Forms.RadioButton rbFlete;
		private System.Windows.Forms.Label label7;
	}
}