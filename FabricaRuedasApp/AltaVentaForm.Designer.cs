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
            this.gbAltaVenta = new System.Windows.Forms.GroupBox();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvDetalleTemporal = new System.Windows.Forms.DataGridView();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.gbAltaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTemporal)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(122, 54);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 0;
            // 
            // cbRueda
            // 
            this.cbRueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRueda.FormattingEnabled = true;
            this.cbRueda.Location = new System.Drawing.Point(122, 101);
            this.cbRueda.Name = "cbRueda";
            this.cbRueda.Size = new System.Drawing.Size(121, 21);
            this.cbRueda.TabIndex = 1;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(122, 147);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
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
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(36, 236);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(90, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar Venta";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbAltaVenta
            // 
            this.gbAltaVenta.Controls.Add(this.btnAgregarItem);
            this.gbAltaVenta.Controls.Add(this.btnCancelar);
            this.gbAltaVenta.Controls.Add(this.lblCliente);
            this.gbAltaVenta.Controls.Add(this.btnConfirmar);
            this.gbAltaVenta.Controls.Add(this.cbCliente);
            this.gbAltaVenta.Controls.Add(this.lblCantidad);
            this.gbAltaVenta.Controls.Add(this.cbRueda);
            this.gbAltaVenta.Controls.Add(this.lblRueda);
            this.gbAltaVenta.Controls.Add(this.numCantidad);
            this.gbAltaVenta.ForeColor = System.Drawing.Color.White;
            this.gbAltaVenta.Location = new System.Drawing.Point(88, 66);
            this.gbAltaVenta.Name = "gbAltaVenta";
            this.gbAltaVenta.Size = new System.Drawing.Size(281, 297);
            this.gbAltaVenta.TabIndex = 7;
            this.gbAltaVenta.TabStop = false;
            this.gbAltaVenta.Text = "Alta de Venta";
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarItem.Location = new System.Drawing.Point(84, 193);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(114, 23);
            this.btnAgregarItem.TabIndex = 8;
            this.btnAgregarItem.Text = "Agregar Producto";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(150, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvDetalleTemporal
            // 
            this.dgvDetalleTemporal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleTemporal.Location = new System.Drawing.Point(391, 132);
            this.dgvDetalleTemporal.Name = "dgvDetalleTemporal";
            this.dgvDetalleTemporal.Size = new System.Drawing.Size(528, 150);
            this.dgvDetalleTemporal.TabIndex = 9;
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(391, 288);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(65, 23);
            this.btnEliminarDetalle.TabIndex = 10;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // AltaVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.dgvDetalleTemporal);
            this.Controls.Add(this.gbAltaVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AltaVentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistrarVenta";
            this.Load += new System.EventHandler(this.AltaVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.gbAltaVenta.ResumeLayout(false);
            this.gbAltaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleTemporal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbRueda;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblRueda;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbAltaVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.DataGridView dgvDetalleTemporal;
        private System.Windows.Forms.Button btnEliminarDetalle;
    }
}