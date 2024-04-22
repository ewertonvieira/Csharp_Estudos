// Acessores Get/Set
using System;


class Carro
{
    private int VelMax;
    public int vm
    {
        get { return VelMax; }

        set
        {
            if (value <= 0)
            {

                VelMax = 0;
            }

            else if (value > 300)
            {

                VelMax = 300;
            }
            else
            {
                VelMax -= value;
            }

        }
    }
    public Carro()
    {
        this.VelMax = 120;
    }
}
class Aula41
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.vm = 20;
        Console.WriteLine("Valocidade: {0}",carro.vm);
        Console.ReadKey();
    }
}
