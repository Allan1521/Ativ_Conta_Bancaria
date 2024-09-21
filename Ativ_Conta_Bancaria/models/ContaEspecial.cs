
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allan.Ativ_Conta_Bancaria.Models;

internal class ContaEspecial
{
    public string TitularDaConta { get; set; }      
    public string NumerodaConta { get; set; }
    public double Limite { get; set; }

    public ContaEspecial(string titularDaConta, string numerodaConta, double limite)
    {
        this.TitularDaConta = titularDaConta;
        this.NumerodaConta = numerodaConta;
        this.Limite = limite;
    }
}
