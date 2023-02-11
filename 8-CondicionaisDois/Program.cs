using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 7 - Condicionais!");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
       

        if (idadeJoao >= 18 || acompanhado) //Podemos utilizar barra reta vertical para dar a ideia de OU // Podemos utilizar && Para dar a ideia de E 
        {
            Console.WriteLine("Pode entrar!!");
        }
        else
        {
            Console.WriteLine("Infelizmente você não pode entrar :( ");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

