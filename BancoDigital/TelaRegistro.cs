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
    public partial class TelaRegistro : Form
    {
        public Form1 form1;
        
        public TelaRegistro(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.FormClosing += new FormClosingEventHandler(TelaRegistro_FormClosing);
        }

        private void TelaRegistro_Load(object sender, EventArgs e)
        {
            
        }
        private void TelaRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.form1.Show();
        }
        

        
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtUser.Text;
            string senha = txtPass.Text;
            double saldo = double.Parse(txtSaldo.Text);

            ContaBancaria conta = new ContaBancaria(nome, senha);

            
            conta.Saldo = saldo;



            this.form1.contasBancarias.Add(conta);

            MessageBox.Show("Cliente cadastrado com sucesso!");

            this.Close();
        }
    }
}
