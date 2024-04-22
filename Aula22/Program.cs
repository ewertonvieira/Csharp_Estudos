using System;
class Aula22
{
    static void Main()
    {
        string[] nome = new string[10];
        int i = 0;
        for (i = 0; i <= nome.Length - 1; i++)
        {
            Console.WriteLine("Digite o nome da posiçao {0} do array; ", i);
            nome[i] = Console.ReadLine();

        }
        Console.Clear();
        Console.WriteLine("==================================");
        foreach(string colecao in nome)
        {
            Console.WriteLine(">>...\t{0}",colecao);
        }
        Console.Read();
    }
}