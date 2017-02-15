namespace JogoDesktop
{
    partial class TelaDeInstrucoes
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
            this.NomeDoJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeDoJogador
            // 
            this.NomeDoJogador.AutoSize = true;
            this.NomeDoJogador.Location = new System.Drawing.Point(142, 23);
            this.NomeDoJogador.Name = "NomeDoJogador";
            this.NomeDoJogador.Size = new System.Drawing.Size(35, 13);
            this.NomeDoJogador.TabIndex = 1;
            this.NomeDoJogador.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "O jogo será um quiz de cinema onde cada pergunta valerá pontos.\r\nNo final do jogo" +
    " você receberá a sua pontuação.\r\n\r\nBoa diversão!!!\r\n";
            // 
            // botaoOk
            // 
            this.botaoOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOk.Location = new System.Drawing.Point(64, 383);
            this.botaoOk.Name = "botaoOk";
            this.botaoOk.Size = new System.Drawing.Size(211, 43);
            this.botaoOk.TabIndex = 3;
            this.botaoOk.Text = "Ok, vamos lá!";
            this.botaoOk.UseVisualStyleBackColor = true;
            this.botaoOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaDeInstrucoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 438);
            this.Controls.Add(this.botaoOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomeDoJogador);
            this.Name = "TelaDeInstrucoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de instruções";
            this.Load += new System.EventHandler(this.TelaDeInstrucoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeDoJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoOk;
    }
}