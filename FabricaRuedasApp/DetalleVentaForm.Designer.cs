namespace Presentacion
{
    partial class DetalleVentaForm
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
            this.panelGrillaVentas = new System.Windows.Forms.Panel();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.lblDetalleVenta = new System.Windows.Forms.Label();
            this.btnVolverDetalle = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.panelGrillaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrillaVentas
            // 
            this.panelGrillaVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.panelGrillaVentas.Controls.Add(this.dgvDetalleVenta);
            this.panelGrillaVentas.Location = new System.Drawing.Point(119, 156);
            this.panelGrillaVentas.Name = "panelGrillaVentas";
            this.panelGrillaVentas.Size = new System.Drawing.Size(602, 194);
            this.panelGrillaVentas.TabIndex = 10;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(12, 10);
            this.dgvDetalleVenta.MultiSelect = false;
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(582, 175);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // lblDetalleVenta
            // 
            this.lblDetalleVenta.AutoSize = true;
            this.lblDetalleVenta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDetalleVenta.Location = new System.Drawing.Point(257, 99);
            this.lblDetalleVenta.Name = "lblDetalleVenta";
            this.lblDetalleVenta.Size = new System.Drawing.Size(238, 30);
            this.lblDetalleVenta.TabIndex = 9;
            this.lblDetalleVenta.Text = "Resumen Detalle Venta";
            // 
            // btnVolverDetalle
            // 
            this.btnVolverDetalle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverDetalle.Location = new System.Drawing.Point(27, 21);
            this.btnVolverDetalle.Name = "btnVolverDetalle";
            this.btnVolverDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnVolverDetalle.TabIndex = 8;
            this.btnVolverDetalle.Text = "Volver";
            this.btnVolverDetalle.UseVisualStyleBackColor = true;
            this.btnVolverDetalle.Click += new System.EventHandler(this.btnVolverDetalle_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDetalle.Location = new System.Drawing.Point(119, 356);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDetalle.TabIndex = 11;
            this.btnEliminarDetalle.Text = "Eliminar";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // DetalleVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarDetalle);
            this.Controls.Add(this.panelGrillaVentas);
            this.Controls.Add(this.lblDetalleVenta);
            this.Controls.Add(this.btnVolverDetalle);
            this.Name = "DetalleVentaForm";
            this.Text = "DetalleVentaForm";
            this.Load += new System.EventHandler(this.DetalleVentaForm_Load);
            this.panelGrillaVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrillaVentas;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label lblDetalleVenta;
        private System.Windows.Forms.Button btnVolverDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
    }
}