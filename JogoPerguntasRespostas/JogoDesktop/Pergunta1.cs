using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public int id_Jogador_banco;
        public Pergunta1(int id_Jogador)
        {
            InitializeComponent();
            id_Jogador_banco = id_Jogador;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbResposta1.Checked == true)
            {
                MessageBox.Show("Você acertou!!!");
            }
            else
            {
                MessageBox.Show("Você errou.");
            }


            using (SqlConnection conexao = new SqlConnection("Server=AME0556315W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
            {

                using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta, resposta_correta, id_Jogador) values(@PERGUNTA, @RESPOSTA1, @ID_JOGADOR)", conexao))
                {
                    comando.Parameters.AddWithValue("PERGUNTA", lblPergunta.Text);
                    comando.Parameters.AddWithValue("RESPOSTA1", rdbResposta1.Text);
                    comando.Parameters.AddWithValue("ID_JOGADOR", id_Jogador_banco);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}