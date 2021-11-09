namespace Sistema_Reservaciones
{
    partial class imprimir
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imprimir));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbPdf = new System.Windows.Forms.RadioButton();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.rbNota = new System.Windows.Forms.RadioButton();
			this.rbTicket = new System.Windows.Forms.RadioButton();
			this.ImprimirTickets = new System.Drawing.Printing.PrintDocument();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbPdf);
			this.groupBox1.Controls.Add(this.btnImprimir);
			this.groupBox1.Controls.Add(this.rbNota);
			this.groupBox1.Controls.Add(this.rbTicket);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(49, 46);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(644, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Estilos de factura";
			// 
			// rbPdf
			// 
			this.rbPdf.AutoSize = true;
			this.rbPdf.Location = new System.Drawing.Point(467, 43);
			this.rbPdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbPdf.Name = "rbPdf";
			this.rbPdf.Size = new System.Drawing.Size(130, 24);
			this.rbPdf.TabIndex = 3;
			this.rbPdf.Text = "Guardar PDF";
			this.rbPdf.UseVisualStyleBackColor = true;
			// 
			// btnImprimir
			// 
			this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnImprimir.Location = new System.Drawing.Point(261, 102);
			this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(148, 46);
			this.btnImprimir.TabIndex = 2;
			this.btnImprimir.Text = "Imprimir";
			this.btnImprimir.UseVisualStyleBackColor = false;
			this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
			this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
			this.btnImprimir.MouseHover += new System.EventHandler(this.btnImprimir_MouseHover);
			// 
			// rbNota
			// 
			this.rbNota.AutoSize = true;
			this.rbNota.Location = new System.Drawing.Point(68, 43);
			this.rbNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbNota.Name = "rbNota";
			this.rbNota.Size = new System.Drawing.Size(124, 24);
			this.rbNota.TabIndex = 1;
			this.rbNota.Text = "Nota en hoja";
			this.rbNota.UseVisualStyleBackColor = true;
			// 
			// rbTicket
			// 
			this.rbTicket.AutoSize = true;
			this.rbTicket.Checked = true;
			this.rbTicket.Location = new System.Drawing.Point(261, 43);
			this.rbTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbTicket.Name = "rbTicket";
			this.rbTicket.Size = new System.Drawing.Size(143, 24);
			this.rbTicket.TabIndex = 0;
			this.rbTicket.TabStop = true;
			this.rbTicket.Text = "Ticket pequeño";
			this.rbTicket.UseVisualStyleBackColor = true;
			this.rbTicket.CheckedChanged += new System.EventHandler(this.rbTicket_CheckedChanged);
			// 
			// ImprimirTickets
			// 
			this.ImprimirTickets.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirTickets_PrintPage);
			// 
			// imprimir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(735, 267);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(150, 50);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "imprimir";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Imprimir";
			this.Load += new System.EventHandler(this.imprimir_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNota;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument ImprimirTickets;
        private System.Windows.Forms.RadioButton rbPdf;
    }
}