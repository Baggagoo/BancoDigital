using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDigital
{
    public partial class TelaPoupanca : Form
    {
        ContaBancaria contaBancaria;
        TelaBanco telaBanco;

        internal TelaPoupanca(ContaBancaria conta, TelaBanco tela)
        {
            InitializeComponent();
            contaBancaria = conta;
            telaBanco = tela;
            
            inserirDados();

            lblValorDeposito.Visible = false;
            txtDeposito.Visible = false;
            txtSaldoAtual.Visible = false;
            btnDeposito.Visible = false;
            lblSaldoAtual.Visible = false;
            lbLRS.Visible = false;
            lblrsRendimento.Visible = false;
            lblrsRendimento.Visible = false;
            txtRendimento.Visible = false;

        }

        private void label1_Visible(object sender, EventArgs e)
        {
            
        }

        private void rbDepositar_CheckedChanged(object sender, EventArgs e)
        {
            lblValorDeposito.Visible = true;
            txtDeposito.Visible = true;
            btnDeposito.Visible = true;
            txtSaldoAtual.Visible = false;
            lblSaldoAtual.Visible = false;
            lbLRS.Visible = false;
            lblrsRendimento.Visible = false;
            lblRendimento.Visible = false;
            txtRendimento.Visible = false;

            if (rbDepositar.Checked == false)
            {
                lblValorDeposito.Visible = false;
                txtDeposito.Visible = false;
                btnDeposito.Visible = false;
                txtSaldoAtual.Visible = false;
                lblSaldoAtual.Visible = false;
                lbLRS.Visible = false;
                lblRendimento.Visible = false;
                lblrsRendimento.Visible = false;
                txtRendimento.Visible = false;

                

            }           
        }

        private void rbSaldo_CheckedChanged(object sender, EventArgs e)
        {
            lblValorDeposito.Visible = false;
            txtDeposito.Visible = false;
            btnDeposito.Visible = false;
            txtSaldoAtual.Visible = true;
            lblSaldoAtual.Visible = true;
            lbLRS.Visible = true;
            lblrsRendimento.Visible = true;
            lblRendimento.Visible = true;
            txtRendimento.Visible = true;            

            
            txtSaldoAtual.Text = contaBancaria.Saldo.ToString("f2");
        }

        public void inserirDados()
        {
            string nome = contaBancaria.Nome; 
            lblNomePoupanca.Text = nome;
            int numeroConta = contaBancaria.Num_Conta;
            lblNumeroPoupanca.Text = Convert.ToString(numeroConta);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtDeposito_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnDeposito_Click(object sender, EventArgs e)
        {           
                double deposito = double.Parse(txtDeposito.Text);

                if (deposito > 0)
                {
                    contaBancaria.Saldo += deposito;
                    MessageBox.Show("Deposito realizado com sucesso");
                }

                else
                {
                    MessageBox.Show("Error: valor impossivel de ser Depositado");
                }

                txtDeposito.Clear();
                rbDepositar.Checked = false;
                rbSaldo.Checked = false;
        }

        private void TelaPoupanca_Load(object sender, EventArgs e)
        {
            double rendimento = CalcularRendimento();
            txtRendimento.Text = rendimento.ToString("f2");
            contaBancaria.Saldo += rendimento;
        }

        private void txtSaldoAtual_TextChanged(object sender, EventArgs e)
        {

        }

        
        
        public  double CalcularRendimento()
        {
            DateTime dataAtual = DateTime.Now;
            double rendimento;


            if (dataAtual.Day == 21)
            {
                rendimento = contaBancaria.Saldo * 0.10; // Alterei o cálculo para 10% (1.10) em vez de 110% (1.10)
            }
            else
            {
                rendimento = contaBancaria.Saldo;
            }

            return rendimento;
        }
    }
}
