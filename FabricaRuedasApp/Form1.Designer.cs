namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnStockCritico = new System.Windows.Forms.Button();
            this.btnResumenVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmpleado.Location = new System.Drawing.Point(34, 176);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(200, 160);
            this.btnEmpleado.TabIndex = 1;
            this.btnEmpleado.Text = "Menú de Empleados";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnStockCritico
            // 
            this.btnStockCritico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnStockCritico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockCritico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockCritico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockCritico.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStockCritico.Location = new System.Drawing.Point(566, 176);
            this.btnStockCritico.Name = "btnStockCritico";
            this.btnStockCritico.Size = new System.Drawing.Size(200, 160);
            this.btnStockCritico.TabIndex = 2;
            this.btnStockCritico.Text = "Menú de Productos";
            this.btnStockCritico.UseVisualStyleBackColor = false;
            this.btnStockCritico.Click += new System.EventHandler(this.btnStockCritico_Click);
            // 
            // btnResumenVenta
            // 
            this.btnResumenVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnResumenVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResumenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumenVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumenVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnResumenVenta.Location = new System.Drawing.Point(300, 176);
            this.btnResumenVenta.Name = "btnResumenVenta";
            this.btnResumenVenta.Size = new System.Drawing.Size(200, 160);
            this.btnResumenVenta.TabIndex = 3;
            this.btnResumenVenta.Text = "Menú de Ventas";
            this.btnResumenVenta.UseVisualStyleBackColor = false;
            this.btnResumenVenta.Click += new System.EventHandler(this.btnResumenVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(162, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SISTEMA DE GESTIÓN - FÁBRICA DE RUEDAS ALPHA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResumenVenta);
            this.Controls.Add(this.btnStockCritico);
            this.Controls.Add(this.btnEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consola de operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnStockCritico;
        private System.Windows.Forms.Button btnResumenVenta;
        private System.Windows.Forms.Label label1;
    }
}

