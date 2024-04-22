using System;
//Sobrecarga de metodos;
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
}

class Aula47
{
    static void Main()
    {
        Calc calc = new Calc(); // Crie uma instância de Calc
        var res = calc.Soma(2, 4, 5); // Chame o método na instância
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
