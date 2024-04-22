using System;
public class Aula19
{
    static void Main()
    {
        int[] num = new int[10];
        for (int i = 0; i < num.Length;i++)
        {
            num[i] = i;
            Console.WriteLine("A posicao {1} recebeu o valor {0}",i ,num[i]);
        }
        Console.Read();
    }
}