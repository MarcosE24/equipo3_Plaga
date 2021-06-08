
namespace Juego_de_la_Plaga
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.BtnAutores = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnInstructivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "  LA \r\nPLAGA";
            // 
            // BtnJugar
            // 
            this.BtnJugar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnJugar.Location = new System.Drawing.Point(226, 148);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(190, 30);
            this.BtnJugar.TabIndex = 1;
            this.BtnJugar.Text = "Jugar";
            this.BtnJugar.UseVisualStyleBackColor = true;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);
            // 
            // BtnAutores
            // 
            this.BtnAutores.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAutores.Location = new System.Drawing.Point(226, 274);
            this.BtnAutores.Name = "BtnAutores";
            this.BtnAutores.Size = new System.Drawing.Size(190, 30);
            this.BtnAutores.TabIndex = 3;
            this.BtnAutores.Text = "Nombre de los Autores";
            this.BtnAutores.UseVisualStyleBackColor = true;
            this.BtnAutores.Click += new System.EventHandler(this.BtnAutores_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.Location = new System.Drawing.Point(226, 337);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(190, 30);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnInstructivo
            // 
            this.BtnInstructivo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInstructivo.Location = new System.Drawing.Point(226, 217);
            this.BtnInstructivo.Name = "BtnInstructivo";
            this.BtnInstructivo.Size = new System.Drawing.Size(190, 30);
            this.BtnInstructivo.TabIndex = 5;
            this.BtnInstructivo.Text = "Instructivos de Juego";
            this.BtnInstructivo.UseVisualStyleBackColor = true;
            this.BtnInstructivo.Click += new System.EventHandler(this.BtnInstructivo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.BtnInstructivo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAutores);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.Button BtnAutores;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnInstructivo;
    }
}