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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        //Campo do nome
        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {

            if(txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }

        }

        //Campo do sobrenome
        private void txtNome2_Enter(object sender, EventArgs e)
        {
            txtNome2.Text = "";
        }

        private void txtNome2_Leave(object sender, EventArgs e)
        {

            if (txtNome2.Text == "")
            {
                txtNome2.Text = "Digite seu sobrenome";
            }

        }


        //Campo do e-mail

        private void txtNome3_Enter(object sender, EventArgs e)
        {
            txtNome3.Text = "";
        }

        private void txtNome3_Leave(object sender, EventArgs e)
        {

            if (txtNome3.Text == "")
            {
                txtNome3.Text = "Digite seu sobrenome";
            }

        }


        private void frmInicial_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                MessageBox.Show("Você deve informar seu nome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }

            if (txtNome2.Text == "Digite seu sobrenome")
            {
                MessageBox.Show("Você deve informar seu sobrenome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }


            if (txtNome3.Text == "Digite seu E-mail")
            {
                MessageBox.Show("Você deve informar seu E-mail", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }

            else {

                //início do código para inserir o jogador na tabela
                //using System.Data.SqlClient;

                using (SqlConnection conexao = new SqlConnection("Server=AME0556315W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {

                   using(SqlCommand comando = new SqlCommand("insert into tb_jogador(nome) OUTPUT INSERTED.ID values(@NOME)",conexao))
                    {
                        comando.Parameters.AddWithValue("NOME", txtNome.Text);
                        conexao.Open();


                        int id_Jogador = (int)comando.ExecuteScalar();

                        if (id_Jogador > 0)
                        {

                            MessageBox.Show("O id inserido foi: " + id_Jogador);

                            MessageBox.Show("Olá " + txtNome.Text.ToUpper() + ". Você está pronto para continuar!!!", "PLAYYYY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                            // player.SoundLocation = "c:\\vm\\teste\\som.wav";
                            // player.Play();


                            TelaDeInstrucoes t1 = new TelaDeInstrucoes(txtNome.Text);
                            t1.ShowDialog();

                            Pergunta1 p1 = new Pergunta1(id_Jogador);
                            p1.ShowDialog();

                            Pergunta2 p2 = new Pergunta2(id_Jogador);
                            p2.ShowDialog();

                            Pergunta3 p3 = new Pergunta3(id_Jogador);
                            p3.ShowDialog();

                            Pergunta4 p4 = new Pergunta4(id_Jogador);
                            p4.ShowDialog();




                            //Pega a quantidade de acertos

                            comando.CommandText = "select COUNT(pergunta) from tb_Perguntas where id_Jogador =" + id_Jogador;
                            SqlDataReader dr_acertos = comando.ExecuteReader();
                            dr_acertos.Read();
                            MessageBox.Show("Sua quantidade de acertos é: " + dr_acertos.GetInt32(0));
                            dr_acertos.Close();

                           
                        }

                        else
                        {
                            MessageBox.Show("DEU RUIMMMM!!!! Algo aconteceu durante o insert");
                        }
                    }
                }
                //fim do código para inserir o jogador na tabela
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
