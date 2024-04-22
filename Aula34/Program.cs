using System;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;

class Veiculo
{
    public int Rodas;
    public int VelMax;
    private bool Ligado;
    public void Ligar()
    {
        Ligado = true;
    }
    public void Desligado()
    {
        Ligado = false;
    }
    public bool GetLigado()
    {
        if(Ligado) { return true; }
        else { return false; }
    }
}
class Carro : Veiculo // Classe Derivada;
{
    public string nome;
    public string cor;
    public Carro(string nome1, string cor1) // Construtor;
    {
        Desligado(); // Chama o construtor Desligado() pois a variavel Ligado esta marcada como privador.
        Rodas = 4;
        VelMax = 144;
        this.nome = nome1;
        this.cor = cor1;
    }

}
class Aula34
{
    static void Main()
    {
        Carro c1 = new Carro("Celta","Vermelho");
        //
        Console.WriteLine("N/Rodas:.... {0}",c1.Rodas);
        Console.WriteLine("Val. Maxima: {0} Km/h", c1.VelMax);
        Console.WriteLine("Modelo:..... {0}", c1.nome);
        Console.WriteLine("Cor:........ {0}", c1.cor);
        Console.WriteLine("Lig/Des......{0}", c1.GetLigado());
        Console.ReadKey();

    }
}
