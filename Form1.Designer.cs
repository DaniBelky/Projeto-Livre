namespace projetoLivre
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVelha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCobrinha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(-5, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portifólio de Projetos - 1ºSemestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(-1, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogo da Velha";
            // 
            // btnVelha
            // 
            this.btnVelha.Location = new System.Drawing.Point(2, 76);
            this.btnVelha.Name = "btnVelha";
            this.btnVelha.Size = new System.Drawing.Size(75, 23);
            this.btnVelha.TabIndex = 2;
            this.btnVelha.Text = "Jogar";
            this.btnVelha.UseVisualStyleBackColor = true;
            this.btnVelha.Click += new System.EventHandler(this.btnVelha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-1, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jogo da Cobrinha";
            // 
            // btnCobrinha
            // 
            this.btnCobrinha.Location = new System.Drawing.Point(2, 149);
            this.btnCobrinha.Name = "btnCobrinha";
            this.btnCobrinha.Size = new System.Drawing.Size(75, 23);
            this.btnCobrinha.TabIndex = 4;
            this.btnCobrinha.Text = "Jogar";
            this.btnCobrinha.UseVisualStyleBackColor = true;
            this.btnCobrinha.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(375, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calculadora";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(378, 75);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "Abrir";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(375, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bloco de notas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCobrinha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVelha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVelha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCobrinha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

