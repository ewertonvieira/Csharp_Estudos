using System;

// Ordem de execucai Base para Derivada
class Base
{
    public Base() 
    {
        Console.WriteLine("Construtor da Classe Base...");
    }
}
class Derivada:Base
{
    public Derivada()
    {
        Console.WriteLine("Construtor da Classe Derivada...");
    }
}
class Derivada1:Derivada
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da Classe Derivada1...");
    }
}
class Derivada2:Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da Classe Derivada2...");
    }
}
class Aula37
{
    static void Main()
    {
        Derivada2 Deri=new Derivada2(); 
        Console.WriteLine(Deri);
        Console.ReadKey();
    }
}