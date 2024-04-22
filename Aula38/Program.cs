using System;

// Metodo Virtual;
class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da Classe Base...");
    }
    public virtual void Info() // Declaracao como Metodo virtual;
    {
        Console.WriteLine("\n ..............Base.......");
    }
}
class Derivada : Base
{
    public Derivada()
    {
        Console.WriteLine("Construtor da Classe Derivada...");
    }
    public override void Info() //Override
    {
        Console.WriteLine("\n ......Derivada....Base.......");
    }
}
class Derivada1 : Derivada
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da Classe Derivada1...");
    }
    public override void Info() // Override
    {
        Console.WriteLine("\n .....Overtide derivada1.....");
    }
}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da Classe Derivada2...");
    }
    public override void Info() // Override;
    {
        Console.WriteLine("\n ......Override derivada2.......");
    }
}
class Aula39
{
    static void Main()
    {
        Derivada2 Deri2 = new Derivada2();
        Derivada1 Deri1 = new Derivada1();
        Derivada Deri=new Derivada();
        Deri.Info();
        Deri1.Info();
        Deri2.Info(); 
        Console.ReadKey();
    }
}