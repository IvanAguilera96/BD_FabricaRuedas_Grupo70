namespace Presentacion
{
    partial class AltaSuministroForm
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
            this.gbIngresoSuministro = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbRueda = new System.Windows.Forms.ComboBox();
            this.lblRueda = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.gbIngresoSuministro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIngresoSuministro
            // 
            this.gbIngresoSuministro.Controls.Add(this.lblCliente);
            this.gbIngresoSuministro.Controls.Add(this.btnConfirmar);
            this.gbIngresoSuministro.Controls.Add(this.cbCliente);
            this.gbIngresoSuministro.Controls.Add(this.lblCantidad);
            this.gbIngresoSuministro.Controls.Add(this.cbRueda);
            this.gbIngresoSuministro.Controls.Add(this.lblRueda);
            this.gbIngresoSuministro.Controls.Add(this.numCantidad);
            this.gbIngresoSuministro.ForeColor = System.Drawing.Color.White;
            this.gbIngresoSuministro.Location = new System.Drawing.Point(103, 59);
            this.gbIngresoSuministro.Name = "gbIngresoSuministro";
            this.gbIngresoSuministro.Size = new System.Drawing.Size(281, 297);
            this.gbIngresoSuministro.TabIndex = 8;
            this.gbIngresoSuministro.TabStop = false;
            this.gbIngresoSuministro.Text = "Ingreso de suministros";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.Transparent;
            this.lblCliente.Location = new System.Drawing.Point(49, 62);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(52, 228);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(176, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar Venta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(122, 54);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Location = new System.Drawing.Point(49, 154);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cbRueda
            // 
            this.cbRueda.FormattingEnabled = true;
            this.cbRueda.Location = new System.Drawing.Point(122, 101);
            this.cbRueda.Name = "cbRueda";
            this.cbRueda.Size = new System.Drawing.Size(121, 21);
            this.cbRueda.TabIndex = 1;
            // 
            // lblRueda
            // 
            this.lblRueda.AutoSize = true;
            this.lblRueda.ForeColor = System.Drawing.Color.Transparent;
            this.lblRueda.Location = new System.Drawing.Point(49, 109);
            this.lblRueda.Name = "lblRueda";
            this.lblRueda.Size = new System.Drawing.Size(39, 13);
            this.lblRueda.TabIndex = 4;
            this.lblRueda.Text = "Rueda";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(122, 147);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            // 
            // AltaSuministroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.gbIngresoSuministro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AltaSuministroForm";
            this.Text = "Ingresar suministros";
            this.gbIngresoSuministro.ResumeLayout(false);
            this.gbIngresoSuministro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresoSuministro;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbRueda;
        private System.Windows.Forms.Label lblRueda;
        private System.Windows.Forms.NumericUpDown numCantidad;
    }
}