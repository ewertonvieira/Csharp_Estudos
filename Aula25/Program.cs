using System;

namespace Aula25
{
    internal class Aula25
    {
        static void Main(string[] args)
        {
            int vdobrado=int.Parse(Console.ReadLine());
            dobrar(ref vdobrado);
            Console.WriteLine(vdobrado); Console.Read();
        }
        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}
