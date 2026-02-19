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
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine(" 1 - saldo");
            Console.WriteLine(" 2 - saque");
            Console.WriteLine(" 3 - deposito");
            Console.WriteLine(" 4 - sair");
            Console.Write("Escolha uma opção: ");

            var input = Console.ReadLine();
            if (!int.TryParse(input, out int opcao))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Saldo: " + valorAtual);
                    break;
                case 2:
                    Console.Write("Digite o valor do saque: ");
                    var saqueInput = Console.ReadLine();
                    if (!decimal.TryParse(saqueInput, out decimal valorSaque) || valorSaque <= 0)
                    {
                        Console.WriteLine("Valor inválido.");
                        break;
                    }
                    if (valorSaque > valorAtual)
                    {
                        Console.WriteLine("Saldo insuficiente.");
                        break;
                    }
                    valorAtual -= valorSaque;
                    Console.WriteLine("Saque realizado com sucesso!");
                    Console.WriteLine($"Saldo atualizado: {valorAtual}");
                    break;
                case 3:
                    Console.Write("Digite o valor do deposito: ");
                    var depositInput = Console.ReadLine();
                    if (!decimal.TryParse(depositInput, out decimal valorDeposito) || valorDeposito <= 0)
                    {
                        Console.WriteLine("Valor inválido.");
                        break;
                    }
                    valorAtual += valorDeposito;
                    Console.WriteLine("Depósito realizado com sucesso!");
                    Console.WriteLine($"Saldo atualizado: {valorAtual}");
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

    }

  
}
