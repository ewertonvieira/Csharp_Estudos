using System;
// Recursividade

class Calc
{
    public int Soma(params int[] n) 
    {
        int soma = 0;
        for (int i = 0; i < n.Length; i++)
        {
            soma += n[i];
        }
        return soma;
    }

    public double Soma(params double[] n)
    {
        double soma = 0;
        for (int i = 0; i < n.Length; i++)
        {
            soma += n[i];
        }
        return soma;
    }
    public int fat(int n)
    {
        int res = 0;
        if (n<=1)
        {
            res = 1;
        }
        else
        {
            res = n * fat(n-1);
        }
        return res;
    }
}

class Aula47
{
    static void Main()
    {
        Calc calc = new Calc(); // Crie uma instância de Calc
        var res = calc.Soma(1,12); // Chame o método na instância
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
