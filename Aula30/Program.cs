using System;
class Jogador
{
    public int stamina;
    public bool status;
    public string nome;
    public Jogador()//Construtor
    {
        stamina = 100;
        status = false;
        nome= null;
    }
    public Jogador(int st,  string n) //construtor'; da class Jogador e tem como funcao inciar as variaveis
    {
        stamina = st;
        status = true;
        nome = n;
    }
    public Jogador(string n,int st,bool s)//Mais um construtor, sobrecarga de construtores; 
    {
        nome = n;
        stamina = st;
        status =s;
    }
    public void info()
    {
        Console.WriteLine("\n\nImprimir sobrecarga:\n\n");
        Console.WriteLine("Nome Jogador: {0}",nome);
        Console.WriteLine("stamina jogador: {0}",stamina);
        Console.WriteLine("Status jogador: {0}",status);
        Console.ReadKey();
        Console.Clear();
    }

}
class Aula30
{
    static void Main()
    {
      
        Jogador player1 = new Jogador();
        Jogador player2 = new Jogador(88,"Jose");
        Jogador player3 = new Jogador("Jeguere",0,true);
        player1.info();
        player2.info();
        player3.info();
   
    }
}