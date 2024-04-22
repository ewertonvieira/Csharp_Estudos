using System;
using System.Collections.Generic;
using System.Threading;

class Aula57
{
    static void Main()
    {

        List<string> Carro = new List<string>();
        Carro.Add("FairLady Z");
        Carro.Add("Supra");
        Carro.Add("Rover");
        Carro.Add("Porche");
        Carro.Add("La Ferrari");

        string[] CarroCopy = new string[10]; // Tambem poderia ser Carro.Count, que restorna o inteiro do tamanho da lista;

        //Carro.Clear();

        // Metodo Insert; Isere MacLaren na prosicao 2;

        Carro.Insert(2, "McLaren");

        //Contains verfica se ha um item na lista;
        Console.WriteLine("==============================");
        Console.WriteLine("Pesquisa item na lista..");
        if (Carro.Contains("Rover"))
        {
            Console.WriteLine("Item esta na lista !");
        }
        else
        {
            Console.WriteLine("Item nao esta na lista!!");
        }
        Console.WriteLine("==============================");
        Console.WriteLine("Imprime o conteudo da lista Carro..\n");
        foreach (var item in Carro) // Percorre a lista "Carro" add para item;
        {
            Console.WriteLine("\tCarro: {0}\r", item);
        }
        Console.WriteLine("Aperte qualquer tecla...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("==============================");

        Carro.CopyTo(CarroCopy, 2);


        Console.WriteLine("\t\rArray com valores copiados de Carro(list)");
        for (int i = 0; i < CarroCopy.Length; i++)
        {
            Console.WriteLine("\tPos: {0}, Valor: {1} ",i,CarroCopy[i]);
        }
        // Lipar tela
        Console.WriteLine("Aperte qualquer tecla...");
        Console.ReadKey();
        Console.Clear();
        // Procurar por indexOf
        Console.WriteLine("Pesquisa IndexOf");
        //

        string ValorProcurado = "La Ferrari";
        Console.WriteLine("==============================");

        int Indice = Carro.IndexOf(ValorProcurado);

        if (Indice != -1) {
          Console.WriteLine("Esta na lista !\n\tItem: {0}",ValorProcurado);

        }
        else
        {
            Console.WriteLine("Nao esta na lista!\n\t Item: {0}", ValorProcurado);
        }
        
        Console.Read();
    }
}