using System;
using System.Reflection.Emit;

class aula16
{
    static void Main(string[] args)
    {
        Label: // comando Goto, Label marca o incio. 
        char escolha;
        Console.WriteLine("Viagem de BH a Vitoria/ES");
        Console.WriteLine("Meio de transporte: [a]Aviao |[c]Carro |[o]Onibus|");
        escolha = char.Parse(Console.ReadLine());
        Console.WriteLine("Tempo de viagem é: ");
        switch (escolha)
        {
            case 'a':
                Console.WriteLine("50 minutos");
                break;
            case 'c':
                Console.WriteLine("10 horas");
                break;
            case 'o':
                Console.WriteLine("15 horas");
                break;
            default: Console.WriteLine("Opcao invalida!"); break;
        }
        Console.WriteLine("Fazer procedimento novamente?! [S]");
        escolha=char.Parse(Console.ReadLine());
        if(escolha=='s'){
            goto Label;
        }
        else
        {
            Console.Clear();
        }

    }
}
