using System;

class Veiculos
{
    public int VelAtual;
    private int VelMaxima; //Private restrige o acesso somente a classe;
    protected bool Ligado; // Permite o acesso da class base e das derivadas;
    
    public Veiculos(int VelMax1) // Construtor interno a classe;
    {
        VelAtual = 0;
        this.VelMaxima = VelMax1; // This pq é private;
        Ligado = false;
    }
    public bool getligado() // Metodo retorna Ligado;
    {
        return Ligado;
    }
    public int getVelMax() // Metodo retorna VelMax;
    {
        return VelMaxima;
    }
} 
class Carro : Veiculos // Classe derivada de Veiculo
{
    public string Nome;
    public Carro(string nome, int VelMax):base(VelMax)
    {
        this.Nome = nome;
        Ligado = true;
    }

}
class Aula36
{
    static void Main(string[] args)
    {
        Carro c1 = new Carro("Panigalli",190); // Nome, VelMax;
        Console.WriteLine("Nome:.............{0}\nVel. Maxima:......{1} km/h\nStatus:...........{2} ",c1.Nome,c1.getVelMax(),c1.getligado());
        Console.ReadKey();
    }
}