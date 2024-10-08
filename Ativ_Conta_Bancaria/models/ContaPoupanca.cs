using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Allan.Ativ_Conta_Bancaria.Models
{
    internal class ContaPoupanca
    {

        public string TitularDaConta { get; set; }
        public string NumerodaConta { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAniversarioDaConta = DateTime.Now;
        
       
        public ContaPoupanca() { }
        
        // Método Sacar
        public void Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}");
            }
            else
            {
                Console.WriteLine("Saque não permitido. valor inserido execede o Saldo");
            }
        }
        public void deposito(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
                Console.WriteLine($" Depósito de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}");
            }
            else
            {
                Console.WriteLine(" Saldo insuficiente");
            }
        }
        public ContaPoupanca(string TitularPoupanca, string NumeroContaPoupanca, double SaldoPoupanca)
        {
            this.TitularDaConta = TitularPoupanca;
            this.NumerodaConta = NumeroContaPoupanca;
            this.Saldo = SaldoPoupanca;

        }

        //Retonar o método de exibir os dados Conta Poupança
        public string ExibirDadosConta()
        {
            return
                $"Titular: {TitularDaConta}," +
                $" Número da Conta: {NumerodaConta}, " +
                $" Saldo: R$ {Saldo}, " +
                $" Data de Aniversário: {DataAniversarioDaConta}";
        }
        //Sobre carga de Métodos

        //Promover para 
        
        public bool Transferir(ContaPoupanca pConta, double pValor)
        {
            this.Sacar(pValor);
            pConta.deposito(pValor);
            return true;
        }
        public bool Transferir(ContaEspecial pConta, double pValor)
        {
            try
            {
                this.Sacar(pValor);//estes métodos devem lançar exception em caso de erro
                pConta.deposito(pValor);//estes métodos devem lançar exception em caso de erro
            }
            catch (Exception)
            {
                return false;
            }
            return true;
            
        }
           
    }
}
    

