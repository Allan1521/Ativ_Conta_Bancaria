using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allan.Ativ_Conta_Bancaria.Models
{
    internal class ContaPoupanca
    {

        public string TitularDaConta { get; set; }
        public string NumerodaConta { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAniversarioDaConta { get; set; }

        public ContaPoupanca()
        {
            
        }
    }
}
