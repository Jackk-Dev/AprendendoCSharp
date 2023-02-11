using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 4 - Conversões E Outros Tipos");

        double salario; // valores quebrados com . ,
        salario = 3000.15;

        Console.WriteLine(salario);


        int salarioInteiro; // valores médios
        salarioInteiro = (int)salario;


        Console.WriteLine(salarioInteiro);



        long x; // valores grandes 
        x = 200000000000000;


        Console.WriteLine(x);


        short y;  // valores pequenos
        y = 15000;


        Console.WriteLine(y);

        float altura = 1.62f; // Igual o Double porem menos utilizado
        //outros modos que podemos criar a variaval = tipo nome = valor

        Console.WriteLine(altura);



        Console.WriteLine("Tecle ENTER para encerrar o programa...");
        Console.ReadLine();


    }
}