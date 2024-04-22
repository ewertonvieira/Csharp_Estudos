using System;

// Metodos e variaveis statics; Permite que chame os metodos de qualquer lugar sem instanciar objeto;

class Matematica
{
    public static double pi = 3.14;

    public static double Dobro(double d)
    {
        return d * 2;
    }

}
class Aula49
{
    static void Main()
    {
        double InfoPI = Matematica.pi;
        Console.WriteLine(Matematica.Dobro(InfoPI));
        Console.ReadKey();
    }
}