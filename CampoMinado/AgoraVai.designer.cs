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
            this.botoes = new System.Windows.Forms.GroupBox();
            botaoJogar = new System.Windows.Forms.Button();
            this.botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoJogar
            // 
            botaoJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            botaoJogar.Location = new System.Drawing.Point(133, 348);
            botaoJogar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            botaoJogar.Name = "botaoJogar";
            botaoJogar.Size = new System.Drawing.Size(180, 49);
            botaoJogar.TabIndex = 1;
            botaoJogar.Text = "Jogar";
            botaoJogar.UseVisualStyleBackColor = true;
            botaoJogar.Click += new System.EventHandler(this.JogarClick);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(31, 167);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(310, 46);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Batalha Minada";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // botaoSair
            // 
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.Location = new System.Drawing.Point(133, 405);
            this.botaoSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(180, 49);
            this.botaoSair.TabIndex = 2;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.SairClick);
            // 
            // botoes
            // 
            this.botoes.BackColor = System.Drawing.SystemColors.Control;
            this.botoes.Controls.Add(this.labelMenu);
            this.botoes.Controls.Add(this.botaoSair);
            this.botoes.Controls.Add(botaoJogar);
            this.botoes.Location = new System.Drawing.Point(89, 16);
            this.botoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botoes.Name = "botoes";
            this.botoes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botoes.Size = new System.Drawing.Size(460, 683);
            this.botoes.TabIndex = 4;
            this.botoes.TabStop = false;
            // 
            // AgoraVai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(610, 717);
            this.Controls.Add(this.botoes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgoraVai";
            this.Text = "Batalha Minada";
            this.botoes.ResumeLayout(false);
            this.botoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.GroupBox botoes;
    }
}

