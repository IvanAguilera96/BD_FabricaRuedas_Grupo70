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
            this.lblStock = new System.Windows.Forms.Label();
            this.btnFiltroCritico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuedaStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRuedaStock
            // 
            this.dgvRuedaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuedaStock.Location = new System.Drawing.Point(106, 202);
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
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStock.Location = new System.Drawing.Point(101, 99);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(203, 30);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock de productos";
            // 
            // btnFiltroCritico
            // 
            this.btnFiltroCritico.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCritico.Location = new System.Drawing.Point(106, 173);
            this.btnFiltroCritico.Name = "btnFiltroCritico";
            this.btnFiltroCritico.Size = new System.Drawing.Size(137, 23);
            this.btnFiltroCritico.TabIndex = 5;
            this.btnFiltroCritico.Text = "Ver stock crítico";
            this.btnFiltroCritico.UseVisualStyleBackColor = true;
            this.btnFiltroCritico.Click += new System.EventHandler(this.btnFiltroCritico_Click);
            // 
            // StockRuedaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiltroCritico);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnVolverStock);
            this.Controls.Add(this.dgvRuedaStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StockRuedaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control de Inventario";
            this.Load += new System.EventHandler(this.StockRuedaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuedaStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRuedaStock;
        private System.Windows.Forms.Button btnVolverStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnFiltroCritico;
    }
}