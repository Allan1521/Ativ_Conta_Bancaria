// See https://aka.ms/new-console-template for more information

using Allan.Ativ_Conta_Bancaria.Models;
using System.Reflection.Metadata;

class Program
{
    private static string titularDaConta;
    private static string numerodaConta;
    private static double limite;
    public static double Saldo;

    static void Main()
    {
        ContaEspecial Especial = new ContaEspecial(titularDaConta,numerodaConta, Saldo, limite);
        // Coletando dados para a Conta Especial
        Console.WriteLine("\n Conta Especial:");
        Console.Write("Titular: ");
        string esTitular = Console.ReadLine();
        Console.Write("Número da Conta: ");
        string esNumeroConta = Console.ReadLine();
        Console.Write("Saldo: R$ ");
        double esSaldo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Limite: R$ ");
        double esLimite = Convert.ToDouble(Console.ReadLine());
        //chamando o objecto da Conta Especial
        ContaEspecial especial = new ContaEspecial(esTitular, esNumeroConta, esSaldo, esLimite);
        //Mostrando os dados
        Console.WriteLine("\n Dados da Conta Especial:");
        Console.WriteLine($"Titular: {especial.TitularDaConta}," +
            $" Número: {especial.NumerodaConta}, " +
            $"Saldo: {especial.Saldo}, " +
            $"Limite Disponivel: {especial.Limite}");
        // Instanciando ContaPoupanca
        //ContaPoupanca poupanca = new ContaPoupanca();

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
        Console.WriteLine($"Nome do Titular: {poupanca.TitularDaConta}, " +
            $"Número: {poupanca.NumerodaConta}," +
            $"Saldo: R$ {poupanca.Saldo}, " +
            $"Data de Aniversário: {poupanca.DataAniversarioDaConta}");


    }

}
