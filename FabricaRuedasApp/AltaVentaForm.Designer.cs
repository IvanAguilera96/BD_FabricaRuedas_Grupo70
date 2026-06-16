namespace Presentacion
{
    partial class AltaVentaForm
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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbRueda = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblRueda = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(323, 111);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 0;
            // 
            // cbRueda
            // 
            this.cbRueda.FormattingEnabled = true;
            this.cbRueda.Location = new System.Drawing.Point(323, 166);
            this.cbRueda.Name = "cbRueda";
            this.cbRueda.Size = new System.Drawing.Size(121, 21);
            this.cbRueda.TabIndex = 1;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(323, 223);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.Transparent;
            this.lblCliente.Location = new System.Drawing.Point(209, 119);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblRueda
            // 
            this.lblRueda.AutoSize = true;
            this.lblRueda.ForeColor = System.Drawing.Color.Transparent;
            this.lblRueda.Location = new System.Drawing.Point(209, 169);
            this.lblRueda.Name = "lblRueda";
            this.lblRueda.Size = new System.Drawing.Size(39, 13);
            this.lblRueda.TabIndex = 4;
            this.lblRueda.Text = "Rueda";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Location = new System.Drawing.Point(209, 225);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(237, 294);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(176, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar Venta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // AltaVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblRueda);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cbRueda);
            this.Controls.Add(this.cbCliente);
            this.Name = "AltaVentaForm";
            this.Text = "RegistrarVenta";
            this.Load += new System.EventHandler(this.AltaVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbRueda;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblRueda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnConfirmar;
    }
}