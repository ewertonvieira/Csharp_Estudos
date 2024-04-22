using System;
// Argumento de entrada;
class Aula51
{
    static void Main(string[] argumentos)
    {
        argumentos = new string[] { "Cavalo", "CFB Cursos", "Ar", "Terra" }; 
        int array = argumentos.Length;
        if (array > 0)
        {
            Console.WriteLine("\tArgumentos possui {0} itens", array);
            Console.WriteLine("\t------------------------------");
            
            for (int i = 0; i < array ; i++) 
            {
                Console.WriteLine("\tPosicao: {0} possui: {1}",i,argumentos[i]);
            }
        }
        else
        {
            Console.WriteLine("Argumentos esta vazio");
        }
        Console.Read();
    }
}