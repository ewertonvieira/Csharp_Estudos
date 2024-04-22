using System;

class Aula26
{
    static void Main()
    {
        int dividend, quocient, diviso, rest;
        Console.Write("Digite o dividendo:\n>");
        dividend = int.Parse(Console.ReadLine());
        Console.Write("Digite o divisor:\n>");
        diviso = int.Parse(Console.ReadLine());
        quocient = dividir(dividend, diviso, out rest);//Out retorna um segundo valor, ja que return so retorna um.
        Console.WriteLine("{0}/{1}: quociente={2} e o resto {3}", dividend, diviso, quocient, rest);
        Console.Read();

    }
    static int dividir(int dividendo, int divisor, out int resto) //out nos argumentos
    {
        int quociente; 
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}

