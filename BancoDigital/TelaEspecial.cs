using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDigital
{
    public partial class TelaEspecial : Form
    {
        ContaBancaria contaBancaria;
        TelaBanco telaBanco;

        internal TelaEspecial(ContaBancaria conta, TelaBanco tela)
        {
            InitializeComponent();
            contaBancaria = conta;
            telaBanco = tela;
            inserirDadosSaque();

            lbLRSEspecial.Visible = false;
            lblSaldoAtualEspecial.Visible = false;
            txtSaldoAtualEspecial.Visible=false;
            lblValorSaque.Visible = false;
            txtSaque.Visible = false;
            btnSacar.Visible = false;
        }

        public void inserirDadosSaque()
        {
            string nome = contaBancaria.Nome;
            int numeroConta = contaBancaria.Num_Conta;

            lblNomeEspecial.Text = nome;
            lblNumeroEspecial.Text = Convert.ToString(numeroConta);
        }

        private void rbSacar_CheckedChanged(object sender, EventArgs e)
        {
            lbLRSEspecial.Visible = false;
            lblSaldoAtualEspecial.Visible = false;
            txtSaldoAtualEspecial.Visible = false;
            lblValorSaque.Visible = true;
            txtSaque.Visible = true;
            btnSacar.Visible = true;

            if (rbSacar.Checked == false)
            {
                lbLRSEspecial.Visible = false;
                lblSaldoAtualEspecial.Visible = false;
                txtSaldoAtualEspecial.Visible = false;
                lblValorSaque.Visible = false;
                txtSaque.Visible = false;
                btnSacar.Visible = false;
            }

        }

        private void rbSaldoEspecial_CheckedChanged(object sender, EventArgs e)
        {
            lbLRSEspecial.Visible = true;
            lblSaldoAtualEspecial.Visible = true;
            txtSaldoAtualEspecial.Visible = true;
            lblValorSaque.Visible = false;
            txtSaque.Visible = false;
            btnSacar.Visible = false;

            txtSaldoAtualEspecial.Text = Convert.ToString(contaBancaria.Saldo);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            double saque = double.Parse(txtSaque.Text);

            
                if (saque == 1000 + contaBancaria.Saldo)
                {
                    contaBancaria.Saldo -= saque;
                MessageBox.Show("Saque realizado com sucesso");

                }
                else if (saque < 1000 + contaBancaria.Saldo)
                {
                    contaBancaria.Saldo -= saque;
                    MessageBox.Show("Saque realizado com sucesso");
                }
                else if (saque > 1000 + contaBancaria.Saldo)
                {
                    MessageBox.Show("Valor para saque indísponivel");
                }
          

            txtSaque.Clear();
            rbSacar.Checked = false;
            rbSaldoEspecial.Checked = false;
        }
    }
}
