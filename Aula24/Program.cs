using System;

namespace Aula24
{
    class Aula24
    {
        static void Main()
        {
            Console.Write("Digite primeiro valor:\n>");
            long n1 = long.Parse(Console.ReadLine());
            Console.Write("Digite segundo valor:\n>");
            long n2 = long.Parse(Console.ReadLine());
            long r=soma(n1, n2);
            Console.WriteLine("Resultado da entre {0} e {1} soma é {2}",n1,n2, r);
            Console.ReadKey();
        }

        static long soma(long n1, long n2) //tipo long que é o retorno, e os parametros.
        {
            long resultado = n1 + n2;
            return resultado;//retorna o valor da soma, resultado
        }
    }
}
