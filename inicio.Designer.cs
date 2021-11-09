namespace Sistema_Reservaciones
{
    partial class inicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.btnInicio = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Purple;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(218, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bienvenidos";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsuario.BackColor = System.Drawing.Color.White;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
			this.txtUsuario.Location = new System.Drawing.Point(164, 139);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(11, 10, 4, 4);
			this.txtUsuario.MaxLength = 25;
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(320, 26);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TabStop = false;
			this.txtUsuario.Text = "Usuario";
			this.txtUsuario.WordWrap = false;
			this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
			this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
			this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
			// 
			// txtContra
			// 
			this.txtContra.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtContra.BackColor = System.Drawing.Color.White;
			this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContra.ForeColor = System.Drawing.Color.Silver;
			this.txtContra.Location = new System.Drawing.Point(164, 190);
			this.txtContra.Margin = new System.Windows.Forms.Padding(4);
			this.txtContra.MaxLength = 25;
			this.txtContra.Name = "txtContra";
			this.txtContra.Size = new System.Drawing.Size(320, 26);
			this.txtContra.TabIndex = 2;
			this.txtContra.TabStop = false;
			this.txtContra.Text = "Contraseña";
			this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
			this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
			this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.White;
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.Location = new System.Drawing.Point(163, 255);
			this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(321, 36);
			this.btnInicio.TabIndex = 3;
			this.btnInicio.TabStop = false;
			this.btnInicio.Text = "INICIAR SESION";
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnInicio);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.txtContra);
			this.groupBox1.Location = new System.Drawing.Point(57, 41);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(651, 387);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(785, 503);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "inicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "";
			this.Text = "Inicio Sesion";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtContra;
    }
}