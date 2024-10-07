
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
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public ContaEspecial(string titularDaConta, string numerodaConta, double saldodaConta, double limite)
    {
        this.TitularDaConta = titularDaConta;
        this.NumerodaConta = numerodaConta;
        this.Saldo = saldodaConta;
        this.Limite = limite;
    }
    public void Sacar(double valor)
    {
        if (valor <= this.Saldo + this.Limite)
        {
            this.Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor} realizado com Sucesso. Saldo atual é : R${this.Saldo}");
        }
        else
        {
            Console.WriteLine($"Saque não permitido. o Valor inserido excede o saldo  e o limite.");
        }

    } //Retiornar o método de exibir os dados Conta Especial
    public string ExibirDadosConta()
    {
        return
            $" Titutar: {TitularDaConta}," +
            $" Número da Conta: {NumerodaConta}," +
            $" Saldo: R$ {Saldo}," +
            $" Limite Disponível: R$ {Limite}";
    }
}
        


