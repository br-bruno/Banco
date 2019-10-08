using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta = new Conta();
            conta.Numero = 2346;
            Cliente cliente = new Cliente("Bruno");
            conta.Titular = cliente;
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            Funcionario funcionario = new Funcionario();
            Empresa empresa = new Empresa();

        }

        private void TextoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void BotaoTranferir_Click(object sender, EventArgs e)
        {
           /* string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Transferir(valorOperacao,con);*/


        }
    }
}
