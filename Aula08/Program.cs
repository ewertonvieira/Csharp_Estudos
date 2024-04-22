using System;
using System.ComponentModel;

class aula08
{
    static void Main(string[] args)
    {
        double nota1, nota2, media;
        string nomealuno;
        Console.WriteLine("digite primeira nota: ");
        nota1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("digite segunda nota: ");
        nota2=Double.Parse(Console.ReadLine());
        Console.WriteLine("Digite nome do aluno: ");
        nomealuno = Console.ReadLine();
        media = (nota1 + nota2) / 2;
        Console.WriteLine("\nA media do aluno :"+nomealuno +" foi "+ media);
        Console.Read();
    }
}