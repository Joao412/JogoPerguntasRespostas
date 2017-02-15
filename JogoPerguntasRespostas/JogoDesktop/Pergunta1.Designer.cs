namespace JogoDesktop
{
    partial class Pergunta1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta1));
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.rdbResposta2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.btnProxima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(75, 19);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(470, 25);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "Quais desses atores interpretaram o coringa da foto?";
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.BackColor = System.Drawing.Color.LightGray;
            this.rdbResposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResposta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbResposta1.Location = new System.Drawing.Point(60, 99);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(133, 21);
            this.rdbResposta1.TabIndex = 1;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "Anthony Hopkins";
            this.rdbResposta1.UseVisualStyleBackColor = false;
            // 
            // rdbResposta2
            // 
            this.rdbResposta2.AutoSize = true;
            this.rdbResposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResposta2.Location = new System.Drawing.Point(60, 151);
            this.rdbResposta2.Name = "rdbResposta2";
            this.rdbResposta2.Size = new System.Drawing.Size(121, 21);
            this.rdbResposta2.TabIndex = 2;
            this.rdbResposta2.TabStop = true;
            this.rdbResposta2.Text = "Jack Nicholson";
            this.rdbResposta2.UseVisualStyleBackColor = true;
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResposta3.Location = new System.Drawing.Point(60, 202);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(117, 21);
            this.rdbResposta3.TabIndex = 3;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "Cesar Romero";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResposta4.Location = new System.Drawing.Point(60, 254);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(113, 21);
            this.rdbResposta4.TabIndex = 4;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "Heath Ledger";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(443, 326);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(143, 45);
            this.btnProxima.TabIndex = 5;
            this.btnProxima.Text = "Próxima pergunta";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 383);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbResposta2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.RadioButton rdbResposta2;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.Button btnProxima;
    }
}