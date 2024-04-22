using System;
using System.Runtime.Remoting.Services;

public class Jogador
{
    public int stamina = 100;
    public bool status = true;
}
class Aula28
{
    static void Main()
    {
        Jogador player1=new Jogador();
        Jogador player2= new Jogador();
        player2.stamina = 99;  
        Console.WriteLine("A estamina do jogador1 é {0} e o status é {1}",player1.stamina,player1.status);
        Console.WriteLine("A estamina do jogador2 é de {0} e o estatus é {1}",player2.stamina,player2.status);
        Console.ReadKey();
    }
}