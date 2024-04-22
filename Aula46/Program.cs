using System;

class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Beltrano");
        Galinha g2 = new Galinha("Fulano");
        Galinha g3 = new Galinha("Ciclano");

        g1.Botar();
        g1.Botar();
        g1.Botar();
        g2.Botar();
        g3.Botar();
        g3.Botar();

        Console.WriteLine($"Foram gerados {Galinha.qtdOvos} ovos");                    // Mostrar a quantidade total de ovos
        Console.ReadKey();
    }
}

class Galinha
{
    private string _nomeGalinha;
    private int _numOvo;
    static public int qtdOvos;                    // propriedade estática ara contagem de ovos total

    public Galinha(string nomeGalinha)
    {
        _nomeGalinha = nomeGalinha;
        _numOvo = 0;
    }

    public Ovo Botar()
    {
        _numOvo++;
        qtdOvos++;                    // Incremento da quantidade
        return new Ovo(_numOvo, _nomeGalinha);
    }
}

class Ovo
{
    private int _numOvo;
    private string _minhaGalinha;

    public Ovo(int numOvo, string minhaGalinha)
    {
        _numOvo = numOvo;
        _minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}", _numOvo, _minhaGalinha);
    }
}
