using System;
using System.Collections.Generic;

class Aula56
{
    static void Main()
    {
        string item2 = "Onibus";


        LinkedList<string> transporte = new LinkedList<string>();

        transporte.AddFirst("Carro");
        transporte.AddFirst("Aviao");
        transporte.AddLast("Trem");
        transporte.AddFirst("Onibus");

        LinkedListNode<string> no;
        no = transporte.FindLast("Trem");
        transporte.AddAfter(no, "Patinete");

        //transporte.Clear(); apaga a lista inteira;

        if (  transporte.Find(item2) == null)
        {
            Console.WriteLine("Item {0} nao encontrado !", item2);
        }
        else
        {
            Console.WriteLine("Item {0} encontrado !", item2);
        }

        // Remover;

        transporte.Remove("Carro");
        transporte.RemoveLast(); // Remove o ultimo, transporte.RemoveFist(); remove o primeiro;

        Console.WriteLine("\t_-_-_-_-_-_-_-_-_-_-_-_");
        foreach (var item in transporte)
        {
            Console.WriteLine("\tTransporte: {0}",item);
        }
        Console.WriteLine("\t_-_-_-_-_-_-_-_-_-_-_-_");
        Console.ReadKey();
    }
}