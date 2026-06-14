namespace Presentacion
{
    partial class StockRuedaForm
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
            this.dgvRuedaStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuedaStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRuedaStock
            // 
            this.dgvRuedaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuedaStock.Location = new System.Drawing.Point(80, 102);
            this.dgvRuedaStock.Name = "dgvRuedaStock";
            this.dgvRuedaStock.Size = new System.Drawing.Size(634, 150);
            this.dgvRuedaStock.TabIndex = 0;
            // 
            // StockRuedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRuedaStock);
            this.Name = "StockRuedaForm";
            this.Text = "StockRuedaForm";
            this.Load += new System.EventHandler(this.StockRuedaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuedaStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRuedaStock;
    }
}