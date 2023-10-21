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
    public partial class Form1 : Form
    {
        public string nomeUsuario;
        
        public Form1()
        {
            InitializeComponent();

        }

        internal List<ContaBancaria> contasBancarias = new List<ContaBancaria>();

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TelaRegistro telaRegistro = new TelaRegistro(this);

            telaRegistro.Show();

            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TelaBanco telaBanco = null; // Criar uma instância de TelaBanco.

            foreach (ContaBancaria conta in contasBancarias)
            {
                if (txtLogin.Text.Equals(conta.Nome) && txtPassword.Text.Equals(conta.Senha))
                {
                    telaBanco = new TelaBanco(conta, this); // Passar a conta e a instância de Form1 para TelaBanco.
                    break;
                }
            }

            if (telaBanco != null)
            {
                telaBanco.Show();
                this.Hide();
                txtLogin.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado ou senha incorreta.");
                txtLogin.Clear();
                txtPassword.Clear();
            }
        }
    }
}

