namespace Presentacion
{
    partial class EmpleadosForm
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnVolverEmpleados = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.panelGrillaEmpleados = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.panelGrillaEmpleados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 10);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(582, 175);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // btnVolverEmpleados
            // 
            this.btnVolverEmpleados.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverEmpleados.Location = new System.Drawing.Point(27, 21);
            this.btnVolverEmpleados.Name = "btnVolverEmpleados";
            this.btnVolverEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnVolverEmpleados.TabIndex = 2;
            this.btnVolverEmpleados.Text = "Volver";
            this.btnVolverEmpleados.UseVisualStyleBackColor = true;
            this.btnVolverEmpleados.Click += new System.EventHandler(this.btnVolverEmpleados_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmpleados.Location = new System.Drawing.Point(244, 83);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(342, 30);
            this.lblEmpleados.TabIndex = 3;
            this.lblEmpleados.Text = "Planilla de empleados registrados";
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(106, 340);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(163, 23);
            this.btnAgregarEmpleado.TabIndex = 4;
            this.btnAgregarEmpleado.Text = "Registrar nuevo empleado";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // panelGrillaEmpleados
            // 
            this.panelGrillaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.panelGrillaEmpleados.Controls.Add(this.dgvEmpleados);
            this.panelGrillaEmpleados.Location = new System.Drawing.Point(106, 140);
            this.panelGrillaEmpleados.Name = "panelGrillaEmpleados";
            this.panelGrillaEmpleados.Size = new System.Drawing.Size(602, 194);
            this.panelGrillaEmpleados.TabIndex = 8;
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGrillaEmpleados);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.btnVolverEmpleados);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmpleadosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Panel de empleados";
            this.Load += new System.EventHandler(this.EmpleadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.panelGrillaEmpleados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnVolverEmpleados;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Panel panelGrillaEmpleados;
    }
}