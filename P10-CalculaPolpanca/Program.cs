using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // Rendimento de 0.5% (0.005) ao mês 

        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);

        int mes = 1;

         while (mes <=12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No Mês " + mes + " você tem: R$" + investimento);

            //mes = mes +1;
            mes += 1;  
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

