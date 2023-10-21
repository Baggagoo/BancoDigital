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
    public partial class TelaBanco : Form
    {
        TelaPoupanca telaPoupanca;
        TelaEspecial telaEspecial;
        Form1 form1;

        internal TelaBanco(ContaBancaria contaBancaria, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1; 
            telaPoupanca = new TelaPoupanca(contaBancaria, this);
            telaEspecial = new TelaEspecial(contaBancaria, this);
        }

        private void pnTelas_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPoupanca_Click(object sender, EventArgs e)
        {
            
            imgLogo.Hide();
            telaPoupanca.FormBorderStyle = FormBorderStyle.None;
            telaPoupanca.TopLevel = false;
            pnTelas.Controls.Add(telaPoupanca);
            telaEspecial.Hide();
            telaPoupanca.Show();
        }

        private void btnContaEspecial_Click(object sender, EventArgs e)
        {
            imgLogo.Hide();
            telaEspecial.FormBorderStyle = FormBorderStyle.None;
            telaEspecial.TopLevel = false;
            pnTelas.Controls.Add(telaEspecial);
            telaPoupanca.Hide();
            telaEspecial.Show();
        }

        private void TelaBanco_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            
            form1.Show();
            
        }
    }
}
