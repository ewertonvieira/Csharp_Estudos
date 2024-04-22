using System;
class Jogador
{
    public int stamina;
    public bool status;
    public string nome;
    public Jogador(string n) //construtor'; da class Jogador e tem como funcao inciar as variaveis
    {
        stamina=100;
        status=false;
        nome = n;
    }
    ~Jogador(){ // destrutor
        Console.WriteLine("Destrutor agindo...");
        Console.WriteLine("Deletado");
        Console.Read();
    }
}
class Aula29
{
    static void Main()
    {                
        string nome; // a variavel nome nao nada a ver com as do construtor pois pertencem a outros escopo do programa; 
        Console.WriteLine("Digite o nome do jogador: ");
        nome = Console.ReadLine();
    
        Jogador player1 = new Jogador(nome);
        Jogador player2 = new Jogador("Theo Becker");
        Console.WriteLine("\tEstamina: {0} \n\tEstatus: {1}\n\tNome: {2}",player1.stamina,player1.status,player1.nome);
        Console.WriteLine("\tEstamina: {0} \n\tEstatus: {1}\n\tNome: {2}", player2.stamina, player2.status, player2.nome);
        Console.ReadKey();
        Console.Clear();
    }
}