using System;
// Struct e Array;
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
        Console.WriteLine("\n\tMarca:  {0}\n\tModelo: {1}\n\tAno:    {2}\n\tCor:    {3}", this.Marca, this.Modelo, this.Cor, this.Ano);
        Console.WriteLine("\t______________________________________________________________\t");
    }
}
class Aula45
{
    static void Main()
    {
        Carro[] CarroArray = new Carro[3];

        CarroArray[0] = new Carro("Nissan", "FairLady Z", "Preto", 2019);
        CarroArray[1] = new Carro("Ford", "Mustang", "Branco", 2015);
        CarroArray[2] = new Carro("Honda", "Civic Type R", "Vermelho", 2017);

        // Chamando metodo Info();

        for (int i = 0; i < 3; i++)
        {
            CarroArray[i].Info();
        }
        Console.ReadKey();
    }
}