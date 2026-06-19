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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnConfirmarIngreso = new System.Windows.Forms.Button();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRueda = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbIngresoSuministro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIngresoSuministro
            // 
            this.gbIngresoSuministro.Controls.Add(this.btnCancelar);
            this.gbIngresoSuministro.Controls.Add(this.txtDescripcion);
            this.gbIngresoSuministro.Controls.Add(this.lblProveedor);
            this.gbIngresoSuministro.Controls.Add(this.btnConfirmarIngreso);
            this.gbIngresoSuministro.Controls.Add(this.cbProveedor);
            this.gbIngresoSuministro.Controls.Add(this.lblCantidad);
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
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.ForeColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Location = new System.Drawing.Point(49, 57);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "Proveedor";
            // 
            // btnConfirmarIngreso
            // 
            this.btnConfirmarIngreso.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarIngreso.Location = new System.Drawing.Point(52, 228);
            this.btnConfirmarIngreso.Name = "btnConfirmarIngreso";
            this.btnConfirmarIngreso.Size = new System.Drawing.Size(90, 23);
            this.btnConfirmarIngreso.TabIndex = 6;
            this.btnConfirmarIngreso.Text = "Cargar Ingreso";
            this.btnConfirmarIngreso.UseVisualStyleBackColor = true;
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(122, 54);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbProveedor.TabIndex = 0;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Location = new System.Drawing.Point(50, 171);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblRueda
            // 
            this.lblRueda.AutoSize = true;
            this.lblRueda.ForeColor = System.Drawing.Color.Transparent;
            this.lblRueda.Location = new System.Drawing.Point(49, 114);
            this.lblRueda.Name = "lblRueda";
            this.lblRueda.Size = new System.Drawing.Size(41, 13);
            this.lblRueda.TabIndex = 4;
            this.lblRueda.Text = "Insumo";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(123, 164);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 111);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(120, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(165, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Ingreso de Suministros";
            this.Load += new System.EventHandler(this.AltaSuministroForm_Load);
            this.gbIngresoSuministro.ResumeLayout(false);
            this.gbIngresoSuministro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresoSuministro;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnConfirmarIngreso;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRueda;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelar;
    }
}