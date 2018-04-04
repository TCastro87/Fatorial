using System;

namespace Fatorial
{
    class Fatorial
    {
        //Fatorial de N com resultado.
        static void Main(string[] args)
        {

            Console.WriteLine("Qual numero deseja saber o fatorial? ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}
