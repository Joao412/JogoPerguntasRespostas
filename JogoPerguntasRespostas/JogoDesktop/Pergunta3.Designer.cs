namespace JogoDesktop
{
    partial class Pergunta3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta3));
            this.btnProxima = new System.Windows.Forms.Button();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbResposta2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(443, 326);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(143, 45);
            this.btnProxima.TabIndex = 16;
            this.btnProxima.Text = "Próxima pergunta";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Location = new System.Drawing.Point(80, 265);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(279, 17);
            this.rdbResposta4.TabIndex = 15;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "O existir invalida qualquer argumento sobre a Verdade";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Location = new System.Drawing.Point(80, 207);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(129, 17);
            this.rdbResposta3.TabIndex = 14;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "A Verdade é subjetiva";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            // 
            // rdbResposta2
            // 
            this.rdbResposta2.AutoSize = true;
            this.rdbResposta2.Location = new System.Drawing.Point(80, 152);
            this.rdbResposta2.Name = "rdbResposta2";
            this.rdbResposta2.Size = new System.Drawing.Size(261, 17);
            this.rdbResposta2.TabIndex = 13;
            this.rdbResposta2.TabStop = true;
            this.rdbResposta2.Text = "A Verdade é irreal assim como a própria existência";
            this.rdbResposta2.UseVisualStyleBackColor = true;
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbResposta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbResposta1.Location = new System.Drawing.Point(80, 99);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(160, 17);
            this.rdbResposta1.TabIndex = 12;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "A Verdade é imutável e Real";
            this.rdbResposta1.UseVisualStyleBackColor = false;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.Color.Red;
            this.lblPergunta.Location = new System.Drawing.Point(42, 24);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(529, 17);
            this.lblPergunta.TabIndex = 11;
            this.lblPergunta.Text = "Qual é a fundamentalização da Verdade para a filosofia Pós-Socrática?";
            // 
            // Pergunta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(598, 383);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbResposta2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Pergunta3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbResposta2;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.Label lblPergunta;
    }
}