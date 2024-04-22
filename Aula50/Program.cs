using System;

// Delegates; 

delegate double Operacao(double numero1, double numero2);
class Matematica
{
    public static double Soma(double numero1, double numero2)
    {
        return numero1 + numero2;
    }
    public static double Dobrar(double numero1)
    {
        return numero1 * 2;
    }
    public static double Multiplicacao(double numero1, double numero2)
    {
        return numero1 * numero2;
    }
}

class Aula50
{
    static void Main()
    {
        double resto;
        Operacao operacao = new Operacao(Matematica.Soma);
        resto = operacao(12.1,23.2);
        Console.WriteLine("A soma: {0} ",resto);
        //
        operacao = new Operacao(Matematica.Multiplicacao);
        resto = operacao(21.2,1.2);
        Console.WriteLine("A multiplicacao: {0} ",resto);
        // 
        Console.Read();
    }
}