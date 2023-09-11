namespace Trabajo_LP1__Abregú_Matías_Nicolás_Nuñez_Deheza_
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.B1 = new System.Windows.Forms.Button();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(15, 57);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(142, 20);
            this.TB1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(15, 105);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(142, 20);
            this.TB2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // DTP
            // 
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(15, 152);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(142, 20);
            this.DTP.TabIndex = 6;
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(15, 187);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 7;
            this.B1.Text = "Guardar";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(205, 40);
            this.TB3.Multiline = true;
            this.TB3.Name = "TB3";
            this.TB3.ReadOnly = true;
            this.TB3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB3.Size = new System.Drawing.Size(205, 195);
            this.TB3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 325);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registro de persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox TB3;
    }
}

