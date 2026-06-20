namespace Presentacion
{
    partial class ResumenVentaForm
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
            this.dgvResumenVenta = new System.Windows.Forms.DataGridView();
            this.btnVolverVentas = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.panelGrillaVentas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenVenta)).BeginInit();
            this.panelGrillaVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResumenVenta
            // 
            this.dgvResumenVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.dgvResumenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenVenta.Location = new System.Drawing.Point(12, 10);
            this.dgvResumenVenta.Name = "dgvResumenVenta";
            this.dgvResumenVenta.Size = new System.Drawing.Size(582, 175);
            this.dgvResumenVenta.TabIndex = 0;
            // 
            // btnVolverVentas
            // 
            this.btnVolverVentas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverVentas.Location = new System.Drawing.Point(27, 21);
            this.btnVolverVentas.Name = "btnVolverVentas";
            this.btnVolverVentas.Size = new System.Drawing.Size(75, 23);
            this.btnVolverVentas.TabIndex = 2;
            this.btnVolverVentas.Text = "Volver";
            this.btnVolverVentas.UseVisualStyleBackColor = true;
            this.btnVolverVentas.Click += new System.EventHandler(this.btnVolverVentas_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVentas.Location = new System.Drawing.Point(244, 83);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(295, 30);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Resumen de Ventas histórico";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.Location = new System.Drawing.Point(106, 340);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(145, 23);
            this.btnAgregarVenta.TabIndex = 5;
            this.btnAgregarVenta.Text = "Registrar nueva venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // panelGrillaVentas
            // 
            this.panelGrillaVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.panelGrillaVentas.Controls.Add(this.dgvResumenVenta);
            this.panelGrillaVentas.Location = new System.Drawing.Point(106, 140);
            this.panelGrillaVentas.Name = "panelGrillaVentas";
            this.panelGrillaVentas.Size = new System.Drawing.Size(602, 194);
            this.panelGrillaVentas.TabIndex = 7;
            // 
            // ResumenVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGrillaVentas);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.btnVolverVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResumenVentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel de ventas";
            this.Load += new System.EventHandler(this.ResumenVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenVenta)).EndInit();
            this.panelGrillaVentas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResumenVenta;
        private System.Windows.Forms.Button btnVolverVentas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Panel panelGrillaVentas;
    }
}