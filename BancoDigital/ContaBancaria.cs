using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital
{
    internal class ContaBancaria
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; set; }
        public int Num_Conta { get; private set; }
        public string Usuario { get; private set; }

        private static int proximoNumeroConta = 1;

        public ContaBancaria(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
            Num_Conta = GerarNumeroConta();
            Usuario = nome; // Definir o usuário ao criar a conta.
        }

        private int GerarNumeroConta()
        {
            return proximoNumeroConta++;
        }
    }
}
