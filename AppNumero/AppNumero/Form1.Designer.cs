namespace AppNumero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroMenor = new System.Windows.Forms.Label();
            this.lblNumeroMayor = new System.Windows.Forms.Label();
            this.txtNumMenor = new System.Windows.Forms.TextBox();
            this.txtNumMayor = new System.Windows.Forms.TextBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroMenor
            // 
            this.lblNumeroMenor.AutoSize = true;
            this.lblNumeroMenor.Location = new System.Drawing.Point(55, 47);
            this.lblNumeroMenor.Name = "lblNumeroMenor";
            this.lblNumeroMenor.Size = new System.Drawing.Size(80, 13);
            this.lblNumeroMenor.TabIndex = 0;
            this.lblNumeroMenor.Text = "Numero Menor:";
            // 
            // lblNumeroMayor
            // 
            this.lblNumeroMayor.AutoSize = true;
            this.lblNumeroMayor.Location = new System.Drawing.Point(55, 91);
            this.lblNumeroMayor.Name = "lblNumeroMayor";
            this.lblNumeroMayor.Size = new System.Drawing.Size(79, 13);
            this.lblNumeroMayor.TabIndex = 1;
            this.lblNumeroMayor.Text = "Numero Mayor:";
            this.lblNumeroMayor.Click += new System.EventHandler(this.lblNumeroMayor_Click);
            // 
            // txtNumMenor
            // 
            this.txtNumMenor.Location = new System.Drawing.Point(141, 47);
            this.txtNumMenor.Name = "txtNumMenor";
            this.txtNumMenor.Size = new System.Drawing.Size(100, 20);
            this.txtNumMenor.TabIndex = 2;
            // 
            // txtNumMayor
            // 
            this.txtNumMayor.Location = new System.Drawing.Point(141, 84);
            this.txtNumMayor.Name = "txtNumMayor";
            this.txtNumMayor.Size = new System.Drawing.Size(100, 20);
            this.txtNumMayor.TabIndex = 3;
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(44, 130);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(197, 96);
            this.rtbMostrar.TabIndex = 4;
            this.rtbMostrar.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(166, 232);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.txtNumMayor);
            this.Controls.Add(this.txtNumMenor);
            this.Controls.Add(this.lblNumeroMayor);
            this.Controls.Add(this.lblNumeroMenor);
            this.Name = "Form1";
            this.Text = "Programa Rango";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMenor;
        private System.Windows.Forms.Label lblNumeroMayor;
        private System.Windows.Forms.TextBox txtNumMenor;
        private System.Windows.Forms.TextBox txtNumMayor;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

