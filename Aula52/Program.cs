using System;
using System.Linq.Expressions;

// Try Catch Finally; tratamento de execoes:

class Aula52
{
    static void Main()
    {
        int n1, n2, resto;
        resto = n1 = n2 = 0;

        n1 = 20; n2 = 0;

        try
        {
            resto = n1 / n2;
            Console.WriteLine("O resto da divisao é: {0}",resto);
        }
        catch(Exception x)
        {
            Console.WriteLine("Erro:  {0}",x.Message);
            Console.WriteLine("Ex:{0}", x.GetType());
        }
        
        Console.Read();
    }
}