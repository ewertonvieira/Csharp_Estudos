using System;
public class Aula16
{
    static void Main()
    {
        int[,] numero = new int[3, 5];//[Linhas,Colunas]
        int[,] numero2x2 = new int[2, 2] { { 1, 1 } , { 2, 2 } }; //L/C
        /*
         * Matriz

         */
        numero[0, 0] = 11;
        numero[0, 1] = 12;
        numero[0, 2] = 13;
        numero[0, 3] = 14;
        numero[0, 4] = 15;

        //
        numero[1, 0] = 21;
        numero[1, 1] = 22;
        numero[1, 2] = 23;
        numero[1, 3] = 24;
        numero[1, 4] = 25;
        //
        numero[2, 0] = 31;
        numero[2, 1] = 32;
        numero[2, 2] = 33;
        numero[2, 3] = 34;
        numero[2, 4] = 35;
        //
        Console.WriteLine(numero[2,2]);
        Console.Read();
    }
}