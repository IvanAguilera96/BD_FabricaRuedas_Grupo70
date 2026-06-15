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
            // ResumenVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResumenVenta);
            this.Name = "ResumenVenta";
            this.Text = "ResumenVenta";
            this.Load += new System.EventHandler(this.ResumenVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResumenVenta;
    }
}