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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResumenVenta
            // 
            this.dgvResumenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenVenta.Location = new System.Drawing.Point(114, 95);
            this.dgvResumenVenta.Name = "dgvResumenVenta";
            this.dgvResumenVenta.Size = new System.Drawing.Size(538, 150);
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
            // ResumenVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverVentas);
            this.Controls.Add(this.dgvResumenVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResumenVentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel de ventas";
            this.Load += new System.EventHandler(this.ResumenVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResumenVenta;
        private System.Windows.Forms.Button btnVolverVentas;
    }
}