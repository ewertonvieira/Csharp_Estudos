using System;
class aula15
{
    static void Main(string[] args)
    {
        int tempo = 0;
        char escolha;       
        Console.WriteLine("Viagem de BH a Vitoria/ES");
        Console.WriteLine("Meio de transporte: [a]Aviao |[c]Carro |[o]Onibus");
        escolha = char.Parse(Console.ReadLine());
        Console.WriteLine("Tempo de viagem é: ");
        switch(escolha){
            case 'a':
                Console.WriteLine("50 minutos");
                Console.Read();
                break;
            case 'c':
                Console.WriteLine("10 horas");
                Console.Read();
                break;
            case 'o':
                Console.WriteLine("15 horas");
                Console.Read();
                break;
            default: Console.WriteLine("Opcao invalida!");break;
        }
        Console.Read();
    }
}
