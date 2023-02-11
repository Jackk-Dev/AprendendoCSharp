using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos"); //aspas duplas para escrever uma frase expressão

        char letra = 'a'; // char é escrito com aspas simples
        Console.WriteLine(letra);

        letra = (char)65; // char convertido para ASCII Table
        Console.WriteLine(letra);

        letra = (char)(86 + 1); // soma com char em formato de ASCII Table
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia! "; // Para frase utilizamos a variavel string
        Console.WriteLine(primeiraFrase + 2023);

        string vazia = ""; // string pode ser vazia, char não pode
        Console.WriteLine(vazia);


        // @ CRIA UMA LISTA
        string cursos = @"Cursos disponiveis: 
- GO 
- C# 
- PYTHON 
- JAVA";


        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

