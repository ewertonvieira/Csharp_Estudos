using System;
// Struct;
struct Carro
{
    public string Marca;
    public string Modelo;
    public string Cor;
    public int Ano;
    public Carro(string Marcac, String Modeloc, String Corc, int Anoc) // Construtor;
    {
        Marca = Marcac;
        Modelo = Modeloc;
        Cor = Corc;
        Ano = Anoc; 
    }
    public void Info() // Metodo;
    {
        Console.Write("\n\t______________________________________________________________\t");
        Console.WriteLine("\n\tMarca:  {0}\n\tModelo: {1}\n\tAno:    {2}\n\tCor:    {3}", this.Marca, this.Modelo, this.Ano, this.Cor);
        Console.WriteLine("\t______________________________________________________________\t");
    }
}
class Aula44
{
    static void Main()
    {
        // Instanciado objetos;
        Carro c1 = new Carro("Chevrolet", "Opala", "Vermelho", 1972);
        Carro c2 = new Carro("Chevrolet","Chevette", "Branco", 1974);
        Carro c3 = new Carro("Nissan", "FairLady Z", "Preto", 2019);
        // Chamando metodo Info();
        c1.Info();
        c2.Info();
        c3.Info();
        Console.ReadKey();
    }
}