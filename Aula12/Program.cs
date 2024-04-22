using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

class aula12
{
    static void Main(string[] args)
    {
        Console.WriteLine("________________________________________\t");
        Console.WriteLine("____________CALCULO DE MEDIA____________\t");
        Console.WriteLine("________________________________________\t");
        Console.WriteLine("________________________________________\t");


        float nota =0, nota2=0 , nota3=0 , nota4 = 0; 
        string consequencia = "!!!!!REPROVADO!!!!!!";
        Console.WriteLine("Digite a primeira nota: ");
        nota=float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine()); 
        Console.WriteLine("Digite a terceira nota: ");
        nota3 = float.Parse(Console.ReadLine()); 
        Console.WriteLine("Digite a quarta nota: ");
        nota4 = float.Parse(Console.ReadLine());
        if (((nota+nota2+nota3+nota4)/4 )>= 7.0)
        {
            consequencia = "APROVADO";
        }
        Console.WriteLine("{0}",consequencia);
        Console.Read();
    }
}
