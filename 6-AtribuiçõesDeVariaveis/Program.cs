using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 6 - Atribuições e Variaveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        //C# é bem linear, sendo assim ele não volta pra atribuir o novo valor de idade para a idadeAna


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

