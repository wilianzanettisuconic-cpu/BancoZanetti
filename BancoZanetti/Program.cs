using System;

public class Program
{
    private static decimal valorAtual = 100m;
    public static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Banco Zanetti!");

        var (usuario, senha) = LoginSenha();

        if (usuario == "abcd" && senha == "1234")
        {
            Menu();
        }
        else
        {
            Console.WriteLine("Usuario ou senha incorretos!");
        }
    }

    private static (string usuario, string senha) LoginSenha()
    {
        Console.WriteLine("Usuario:");
        string usuario = Console.ReadLine();

        Console.WriteLine("Senha:");
        string senha = Console.ReadLine();

        return (usuario, senha);
    }

    private static void Menu()
    {
       
        Console.WriteLine(" 1 - saldo");
        Console.WriteLine(" 2 - saque");
        Console.WriteLine(" 3 - deposito");
        Console.WriteLine(" 4 - sair");
        Console.WriteLine("Escolha uma opção:");
        decimal opcao = decimal.Parse(Console.ReadLine());

        decimal valorInicial = 100;



        if (opcao == 1)
        {
            Console.WriteLine("Saldo:" + valorInicial);
            Menu(); 
        }
        else if (opcao == 2)
        {
            Console.WriteLine("Digite o valor do saque:");
            decimal valorSaque = decimal.Parse (Console.ReadLine());
            var novosaldo = valorInicial - valorSaque;
            
            Console.WriteLine("Saque realizado com sucesso!");
            Console.WriteLine($"Saldo atualizado:{novosaldo}");
            Menu(); 
        }
        else if (opcao == 3)
        {
            Console.WriteLine("Digite o valor do deposito:");
            decimal valorDeposito = decimal.Parse(Console.ReadLine());
            var novosaldo = valorInicial + valorDeposito;
            Console.WriteLine("Depósito realizado com sucesso!");
            Console.WriteLine("Saldo atualizado:" + novosaldo);
            Menu(); 

        }
        else if (opcao == 4)
        {
            Console.WriteLine("Saindo...");
            LoginSenha();
        }
        else
        {
            Console.WriteLine("Opção inválida!");
            Menu(); 
        }

    }

  
}
