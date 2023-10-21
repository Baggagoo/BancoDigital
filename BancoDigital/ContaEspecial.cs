using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital
{
    internal class ContaEspecial : ContaBancaria
    {
        double sacar;
        public ContaEspecial(string nome, string senha) : base(nome, senha)
        {

        }


    }
}
