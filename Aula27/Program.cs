using System;
    class Aula27
{
    static void Main()
    {
        soma(2,2,2,2,2,2);
    }
    static void soma(params int[] numero)
    {
        int resto = 0;
        if (numero.Length<1)
        {
            Console.WriteLine("Nao existem numeros suficientes para somar...");
        }else if(numero.Length<2) {
            Console.WriteLine("Nao existem numeros suficientes para somar...");
        }else
        {
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("De entradas de numero: ");
                resto += numero[i];
            }
            Console.WriteLine(resto);
            Console.ReadKey();
        }
    }
}
