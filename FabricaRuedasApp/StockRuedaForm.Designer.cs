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
            this.btnVolverStock = new System.Windows.Forms.Button();
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
            // btnVolverStock
            // 
            this.btnVolverStock.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverStock.Location = new System.Drawing.Point(27, 21);
            this.btnVolverStock.Name = "btnVolverStock";
            this.btnVolverStock.Size = new System.Drawing.Size(75, 23);
            this.btnVolverStock.TabIndex = 1;
            this.btnVolverStock.Text = "Volver";
            this.btnVolverStock.UseVisualStyleBackColor = true;
            this.btnVolverStock.Click += new System.EventHandler(this.btnVolverStock_Click);
            // 
            // StockRuedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverStock);
            this.Controls.Add(this.dgvRuedaStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StockRuedaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel de productos";
            this.Load += new System.EventHandler(this.StockRuedaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuedaStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRuedaStock;
        private System.Windows.Forms.Button btnVolverStock;
    }
}