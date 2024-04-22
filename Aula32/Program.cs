using System;
class Calculos
{
    public int v1;
    public int v2;
    //
    //
    public int Somar()
    {
        return v1 + v2;
    }
    public Calculos(int v1, int v2)
    {
        this.v1 = v2;
        this.v2 = v1;
    }
}
class Aula32
{
    static void Main()
    {
        Calculos Calc= new Calculos(20,10);
        Console.WriteLine(Calc.Somar());
        Console.ReadKey();
    }
}
