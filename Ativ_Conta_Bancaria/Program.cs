// See https://aka.ms/new-console-template for more information

using Allan.Ativ_Conta_Bancaria.Models;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
   
    static void Main()
    {
<<<<<<< HEAD
        ContaEspecial Especial = new ContaEspecial("Allan", "0001-01.02.03-1", 100);
=======
         // Coletando dados para a Conta Especial
        Console.WriteLine("\n Conta Especial:");
        Console.Write("Titular: ");
        string titularDaConta = Console.ReadLine();
        Console.Write("Número da Conta: ");
        string numerodaConta = Console.ReadLine();
        Console.Write("Saldo: R$ ");
        double saldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Limite: R$ ");
        double limite = Convert.ToDouble(Console.ReadLine());

        ContaEspecial especial = new ContaEspecial(titularDaConta, numerodaConta, saldo, limite);

        //Mostrando os dados
        Console.WriteLine("\n Dados da Conta Especial:");
        Console.WriteLine(especial.ExibirDadosConta());
            
        // Chamar método sacar
        Console.WriteLine("Sacar o Valor: ");
        double saqueEspecial = Convert.ToDouble(Console.ReadLine()); //usuario digita o valor a sacar
        especial.Sacar(saqueEspecial);

        //Criar o método depositar
        Console.WriteLine("Fazer Depósito");
        double deposito = Convert.ToDouble(Console.ReadLine()); //usuario digita o valor a depositar
        especial.deposito(deposito);
        
        //***********************************************************************************************

        // Coletando dados para a Conta Poupança
        Console.WriteLine("\n Conta Poupança:");
        Console.Write("Titular: ");
        string TitularPoupanca = Console.ReadLine();
        Console.Write("Número da Conta: ");
        string NumeroContaPoupanca = Console.ReadLine();
        Console.Write("Saldo: R$ ");
        double SaldoPoupanca = Convert.ToDouble(Console.ReadLine());
        
        //chamando class objeto
        ContaPoupanca poupanca = new ContaPoupanca(TitularPoupanca, NumeroContaPoupanca, SaldoPoupanca);
        
        //Mostrando os dados
        Console.WriteLine("\n Dados da Conta Poupança:");
        Console.WriteLine(poupanca.ExibirDadosConta());

        //Chamar método Sacar
        Console.WriteLine("Sacar o Valor: ");
        double saquePoupanca = Convert.ToDouble(Console.ReadLine()); //usuario digita o valor a sacar
        poupanca.Sacar(saquePoupanca);

        //Criar o método depositar
        Console.WriteLine("Fazer Depósito");
        double depositoPoup = Convert.ToDouble(Console.ReadLine()); //usuario digita o valor a depositar
        poupanca.deposito(depositoPoup);





>>>>>>> bdd8af2b6257ec8d73e2cb4ef8885d0da7d111da
    }

}
