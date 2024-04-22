// CLASSE SELADA
using System;

sealed class Veiculo // seadled defino como class do tipo selada;
{
    string Carr;
}
class Carro : Veiculo // Classes seladas nao podem ser herdadas.
{
     Carr="Corsa";
}
class Aual40
{
    static void Main()
    {
        Carro car = new Carro();
        Console.WriteLine(car); 
    }
}