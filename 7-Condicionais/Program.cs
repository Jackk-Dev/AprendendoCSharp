using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais!");

        int idadeJoao = 16;
        int quantidadePessoas = 0;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!!");
        }
        else
        {
            if (quantidadePessoas > 0)
            {
                Console.WriteLine("Ele esta acompanhado, pode entrar!!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar :( ");
            }

        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

