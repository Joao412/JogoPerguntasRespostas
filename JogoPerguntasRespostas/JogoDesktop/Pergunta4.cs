using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta4 : Form
    {
        public int id_Jogador_banco;

        public Pergunta4(int id_Jogador)
        {
            InitializeComponent();
            id_Jogador_banco = id_Jogador;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (rdbResposta3.Checked == true)
            {
                MessageBox.Show("Você acertou!!!");
            }
            else
            {
                MessageBox.Show("Você errou.");
            }

            using (SqlConnection conexao = new SqlConnection("Server=AME0556315W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
            {

                using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta, resposta_correta, id_Jogador) values(@PERGUNTA, @RESPOSTA2, @ID_JOGADOR)", conexao))
                {
                    comando.Parameters.AddWithValue("PERGUNTA", lblPergunta.Text);
                    comando.Parameters.AddWithValue("RESPOSTA2", rdbResposta2.Text);
                    comando.Parameters.AddWithValue("ID_JOGADOR", id_Jogador_banco);
                    conexao.Open();

                    if (comando.ExecuteNonQuery() == 1)

                        MessageBox.Show("Salvo!");

                    this.Close();
                }

            }

        }
    }
}