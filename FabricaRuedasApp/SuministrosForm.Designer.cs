namespace Presentacion
{
    partial class SuministrosForm
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
            this.panelGrillaSuministros = new System.Windows.Forms.Panel();
            this.dgvSuministros = new System.Windows.Forms.DataGridView();
            this.btnAgregarSuministro = new System.Windows.Forms.Button();
            this.lblSuministros = new System.Windows.Forms.Label();
            this.btnVolverSuministros = new System.Windows.Forms.Button();
            this.panelGrillaSuministros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuministros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrillaSuministros
            // 
            this.panelGrillaSuministros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.panelGrillaSuministros.Controls.Add(this.dgvSuministros);
            this.panelGrillaSuministros.Location = new System.Drawing.Point(106, 140);
            this.panelGrillaSuministros.Name = "panelGrillaSuministros";
            this.panelGrillaSuministros.Size = new System.Drawing.Size(602, 194);
            this.panelGrillaSuministros.TabIndex = 12;
            // 
            // dgvSuministros
            // 
            this.dgvSuministros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuministros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.dgvSuministros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuministros.Location = new System.Drawing.Point(12, 10);
            this.dgvSuministros.Name = "dgvSuministros";
            this.dgvSuministros.Size = new System.Drawing.Size(582, 175);
            this.dgvSuministros.TabIndex = 0;
            // 
            // btnAgregarSuministro
            // 
            this.btnAgregarSuministro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSuministro.Location = new System.Drawing.Point(106, 340);
            this.btnAgregarSuministro.Name = "btnAgregarSuministro";
            this.btnAgregarSuministro.Size = new System.Drawing.Size(163, 23);
            this.btnAgregarSuministro.TabIndex = 11;
            this.btnAgregarSuministro.Text = "Ingresar suministros";
            this.btnAgregarSuministro.UseVisualStyleBackColor = true;
            this.btnAgregarSuministro.Click += new System.EventHandler(this.btnAgregarSuministro_Click);
            // 
            // lblSuministros
            // 
            this.lblSuministros.AutoSize = true;
            this.lblSuministros.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuministros.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSuministros.Location = new System.Drawing.Point(244, 83);
            this.lblSuministros.Name = "lblSuministros";
            this.lblSuministros.Size = new System.Drawing.Size(266, 30);
            this.lblSuministros.TabIndex = 10;
            this.lblSuministros.Text = "Inventario de Suministros";
            // 
            // btnVolverSuministros
            // 
            this.btnVolverSuministros.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverSuministros.Location = new System.Drawing.Point(27, 21);
            this.btnVolverSuministros.Name = "btnVolverSuministros";
            this.btnVolverSuministros.Size = new System.Drawing.Size(75, 23);
            this.btnVolverSuministros.TabIndex = 9;
            this.btnVolverSuministros.Text = "Volver";
            this.btnVolverSuministros.UseVisualStyleBackColor = true;
            this.btnVolverSuministros.Click += new System.EventHandler(this.btnVolverSuministros_Click);
            // 
            // SuministrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGrillaSuministros);
            this.Controls.Add(this.btnAgregarSuministro);
            this.Controls.Add(this.lblSuministros);
            this.Controls.Add(this.btnVolverSuministros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SuministrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel de Suministros";
            this.Load += new System.EventHandler(this.SuministrosForm_Load);
            this.Click += new System.EventHandler(this.btnAgregarSuministro_Click);
            this.panelGrillaSuministros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuministros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrillaSuministros;
        private System.Windows.Forms.DataGridView dgvSuministros;
        private System.Windows.Forms.Button btnAgregarSuministro;
        private System.Windows.Forms.Label lblSuministros;
        private System.Windows.Forms.Button btnVolverSuministros;
    }
}