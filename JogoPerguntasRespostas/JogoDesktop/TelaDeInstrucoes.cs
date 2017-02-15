using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class TelaDeInstrucoes : Form
    {
        string nome;      

        public TelaDeInstrucoes(string nomeJogador)
        {

             
            InitializeComponent();
            nome = nomeJogador;
            NomeDoJogador.Text = "Bem vindo " + nome;
        

        }

    

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaDeInstrucoes_Load(object sender, EventArgs e)
        {

        }
    }
}
