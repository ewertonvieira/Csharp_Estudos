using System;
public class aula10

{ enum numeros{domingo,terca,sexta};
    static void Main()
    {
        numeros dias = (numeros)1; //retorana enumerador
        int num = (int)numeros.domingo;//convertendo enum em int; 
        Console.WriteLine(dias+" "+Convert.ToString(num));
        Console.Read();
    }
}
