using System;

public class inimigo
{
    static public bool alerta; //Static Mantem o valor
    public string nome;

    public inimigo(string n)
    {
        alerta = true; // Inicialize o campo alerta da classe
        nome = n; // Inicialize o campo nome da classe
    }

    public void Imprimir()
    {
        Console.Write("\n________________________________\n");
        Console.WriteLine("Nome: {0}, Alerta: {1}", nome, alerta);
        Console.Write("\n________________________________\n");
    }

    static void Main()
    {
        inimigo inimigo1 = new inimigo("Valter Bolacha");
        inimigo inimigo2 = new inimigo("Andre Balada");
        inimigo inimigo3 = new inimigo("Big House");
        inimigo1.Imprimir();
        inimigo2.Imprimir();
        inimigo3.Imprimir();
        Console.ReadKey();
    }
}
