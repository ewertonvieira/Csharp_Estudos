using System;
using System.Collections.Generic;

namespace Aula59
{
    internal class Aula
    {
        static void Main(string[] args)
        {
            // Criando array;
            //string[] VeiculosArray = new string[] {"Lancha", "Carro", "Bicicleta", "Moto", "Cruzeiro do Neymar" };
            // Usando como parametro o array VaiculsoArray;
            Queue <string> Veiculos =  new Queue <string> ();

            Veiculos.Enqueue("Aviao");
            Veiculos.Enqueue("Carro");
            Veiculos.Enqueue("Moto");
            Veiculos.Enqueue("Lancha");


            foreach (string Item in Veiculos)
            {
                Console.WriteLine ("Itens da Queue: {0}",Item);
            }

            Console.ReadKey ();
            Console.Clear();

            // Imprimir em odem descrecente;

            while (Veiculos.Count > 0)
            {
                Console.WriteLine(Veiculos.Dequeue());
            }
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Tamanho da Fila: "+Veiculos.Count);
            Console.Read();
        }
    }
}
