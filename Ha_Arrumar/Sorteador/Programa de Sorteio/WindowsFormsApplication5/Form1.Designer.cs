namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.lab_NomeSortiado = new System.Windows.Forms.Label();
            this.btn_Sorteio = new System.Windows.Forms.Button();
            this.btn_Reinicia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_NomeSortiado
            // 
            this.lab_NomeSortiado.AutoSize = true;
            this.lab_NomeSortiado.Location = new System.Drawing.Point(40, 27);
            this.lab_NomeSortiado.Name = "lab_NomeSortiado";
            this.lab_NomeSortiado.Size = new System.Drawing.Size(114, 13);
            this.lab_NomeSortiado.TabIndex = 0;
            this.lab_NomeSortiado.Text = "(Aqui aparece o nome)";
            // 
            // btn_Sorteio
            // 
            this.btn_Sorteio.Location = new System.Drawing.Point(244, 19);
            this.btn_Sorteio.Name = "btn_Sorteio";
            this.btn_Sorteio.Size = new System.Drawing.Size(88, 29);
            this.btn_Sorteio.TabIndex = 1;
            this.btn_Sorteio.Text = "Sortear";
            this.btn_Sorteio.UseVisualStyleBackColor = true;
            this.btn_Sorteio.Click += new System.EventHandler(this.btn_Sorteio_Click);
            // 
            // btn_Reinicia
            // 
            this.btn_Reinicia.Location = new System.Drawing.Point(244, 54);
            this.btn_Reinicia.Name = "btn_Reinicia";
            this.btn_Reinicia.Size = new System.Drawing.Size(88, 37);
            this.btn_Reinicia.TabIndex = 2;
            this.btn_Reinicia.Text = "Reiniciar";
            this.btn_Reinicia.UseVisualStyleBackColor = true;
            this.btn_Reinicia.Click += new System.EventHandler(this.btn_Reinicia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 98);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reinicia);
            this.Controls.Add(this.btn_Sorteio);
            this.Controls.Add(this.lab_NomeSortiado);
            this.Name = "Sorteio";
            this.Text = "Sorteio de apadrinhamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_NomeSortiado;
        private System.Windows.Forms.Button btn_Sorteio;
        private System.Windows.Forms.Button btn_Reinicia;
        private System.Windows.Forms.Label label1;
    }
}

