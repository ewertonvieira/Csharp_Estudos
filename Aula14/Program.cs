using System;

class aula14
{
    static void Main(string[] args)
    {
        Console.WriteLine("________________________________________\t");
        Console.WriteLine("____________CALCULO DE MEDIA____________\t");
        Console.WriteLine("________________________________________\t");
        Console.WriteLine("________________________________________\t");


        double nota = 0, nota2 = 0, nota3 = 0, nota4 = 0;
        string consequencia;
        Console.WriteLine("Digite a primeira nota: ");
        nota = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a terceira nota: ");
        nota3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quarta nota: ");
        nota4 = float.Parse(Console.ReadLine());
        if (((nota + nota2 + nota3 + nota4) / 4) >= 7.0) //media maior ou igual a 7
        {
            if (((nota + nota2 + nota3 + nota4) / 4)>=9) //media maior ou igual a 8
            {
                consequencia = "Aprovado com honrarias";
            }else{                                       //se a media for menor que 9
              consequencia = "APROVADO";
            }            
        }
        else // se a media nao for maior ou igual a 7
        {
            if (((nota + nota2 + nota3 + nota4) / 4) >= 5)// se a media for maior ou igual a 5
            {
                consequencia = "Recuperaçao";
            }
            else       //se a media for menor que 5
            {
                consequencia = "Reprovado";
            }
        }
        Console.Write(" {0} ",consequencia);
        Console.Read();
    }
}

