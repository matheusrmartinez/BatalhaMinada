namespace Interface
{
    partial class AgoraVai
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
            System.Windows.Forms.Button botaoJogar;
            this.labelMenu = new System.Windows.Forms.Label();
            this.botaoSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.botoes = new System.Windows.Forms.GroupBox();
            botaoJogar = new System.Windows.Forms.Button();
            this.botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoJogar
            // 
            botaoJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            botaoJogar.Location = new System.Drawing.Point(100, 283);
            botaoJogar.Name = "botaoJogar";
            botaoJogar.Size = new System.Drawing.Size(135, 40);
            botaoJogar.TabIndex = 1;
            botaoJogar.Text = "Jogar";
            botaoJogar.UseVisualStyleBackColor = true;
            botaoJogar.Click += new System.EventHandler(this.JogarClick);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(23, 136);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(303, 46);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Campo Minado";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // botaoSair
            // 
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(100, 375);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(135, 40);
            this.botaoSair.TabIndex = 2;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.SairClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Instruções";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InformacoesClick);
            // 
            // botoes
            // 
            this.botoes.BackColor = System.Drawing.SystemColors.Control;
            this.botoes.Controls.Add(this.labelMenu);
            this.botoes.Controls.Add(this.botaoSair);
            this.botoes.Controls.Add(this.button1);
            this.botoes.Controls.Add(botaoJogar);
            this.botoes.Location = new System.Drawing.Point(67, 13);
            this.botoes.Name = "botoes";
            this.botoes.Size = new System.Drawing.Size(345, 555);
            this.botoes.TabIndex = 4;
            this.botoes.TabStop = false;
            // 
            // AgoraVai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(486, 581);
            this.Controls.Add(this.botoes);
            this.Name = "AgoraVai";
            this.Text = "CampoMinado";
            this.botoes.ResumeLayout(false);
            this.botoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox botoes;
    }
}

