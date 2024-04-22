using System;
using System.Collections.Generic;

class Aula55
{
    static void Main()
    {
        Dictionary<int, string> Veiculos = new Dictionary<int, string>();

        Veiculos.Add(10, "Carro");
        Veiculos.Add(11, "Navio");
        Veiculos.Add(22, "Tank");
        Veiculos.Add(2, "Helicóptero");

        Console.WriteLine("\t===========================================");
        Console.WriteLine("\tO tamanho em inteiro do Dictionery: {0} ",Veiculos.Count); // Count, retorna um inteiro, como o Lenght.
        Console.WriteLine("\t===========================================");

        // Pesquisa

        Console.WriteLine("\t\nDigite a chave a ser pesquisada: ");
        int chav = int.Parse(Console.ReadLine());
        if (Veiculos.ContainsKey(chav))
        {
            Console.WriteLine("\t===========================================");
            Console.WriteLine("\tA Chave {0} esta na colecao", chav);
            Console.WriteLine("\t===========================================");

        }
        else
        {
            Console.WriteLine("\t===========================================");
            Console.WriteLine("\tA chave nao existe na colecao !");
            Console.WriteLine("\t===========================================");

        }
        // Remove 2 da colecao
        Veiculos.Remove(2);
        // Imprimi os membros

        foreach (var par in Veiculos.Keys)
        {
            Console.WriteLine("\tChaves: {0} \t Valores: {1}",par, Veiculos[par]);
        }
        Console.Read();
    }
}