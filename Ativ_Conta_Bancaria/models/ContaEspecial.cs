
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allan.Ativ_Conta_Bancaria.Models;

internal class ContaEspecial
{
    public string TitularDaConta { get; set; }
    public string NumerodaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public ContaEspecial(string titularDaConta, string numerodaConta, double saldo,
    double limite)
    {
        this.TitularDaConta = titularDaConta;
        this.NumerodaConta = numerodaConta;
        this.Limite = limite;
        this.Saldo = saldo;
    }
    public void Sacar(double valor)
    {
        if (valor <= this.Saldo + this.Limite)
        {
            if (valor > this.Saldo)
            {
                double valorUsandoLimite = valor - this.Saldo;
                this.Saldo = 0;
                this.Limite -= valorUsandoLimite;
                Console.WriteLine($"Saque de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}, o limite é de : {this.Limite}");
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}, O Limite disponível é : R$ {this.Limite}");
            }
        }
        else
        {       
                Console.WriteLine("Saque não permitido. O valor inserido excede o saldo e o limite.");
        }
    }
    public void deposito(double valor) //método depositar
    {
        if (valor >0)
        {
            this.Saldo += valor;
            Console.WriteLine($" Depósito de R${valor} realizado com Sucesso. Saldo atual é: R${this.Saldo}");
        }
        else
        {
            Console.WriteLine(" Saldo insuficiente para realizar depósito.");
        }
    }
    //Retonar o método de exibir os dados Conta Especial
    public string ExibirDadosConta()
        {

            return
                $"Titular: {TitularDaConta}," +
                $" Número da Conta: {NumerodaConta}," +
                $" Saldo: R$ {Saldo}," +
                $" Limite Disponivel: R$ {Limite}";

        }
    
}


 