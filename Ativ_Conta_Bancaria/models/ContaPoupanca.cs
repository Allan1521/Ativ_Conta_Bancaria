using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allan.Ativ_Conta_Bancaria.Models
{
    public  class ContaPoupanca :Conta
    {
        public DateTime DataAniversarioDaConta = DateTime.Now;

        public ContaPoupanca( string TitularPoupanca, string NumeroContaPoupanca, double SaldoPoupanca) 
        {
            this.TitularDaConta = TitularPoupanca;
            this.NumeroDaConta=NumeroContaPoupanca;
            this.Saldo=SaldoPoupanca;
        }     
          //Retonar o método de exibir os dados Conta Poupança
        public override string ExibirDadosConta()
        {
            return
                $"Titular: {this.TitularDaConta}," +
                $" Número da Conta: {this.NumeroDaConta}, " +
                $" Saldo: R$ {this.Saldo}, " +
                $" Data de Aniversário: {this.DataAniversarioDaConta}";
        }

    }
}
    

