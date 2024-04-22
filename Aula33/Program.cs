using System;

class jogador
{
    private int energia;
    private string nome;

    public jogador(string nome)
    {
        energia = 98;
        this.nome = nome;
    }

    public int GetEnergia()
    {
        return energia;
    }

    public string GetNome()
    {
        return nome;
    }

    public void setEnergia(int energia1)
    {
        if (energia1 < 0)
        {
            energia1 *= -1; // Multiplica por -1 para torná-lo positivo
            if (energia + energia1 >= 0)
            {
                energia += energia1;
            }
            else
            {
                energia = 0;
            }
        }
        else
        {
            if (energia + energia1 <= 100)
            {
                energia += energia1;
            }
            else
            {
                energia = 100;
            }
        }
    }
}

class Aula33
{
    static void Main()
    {
        jogador jogador1 = new jogador("Galadriel");
        jogador1.setEnergia(10);
        Console.Write("Nome: {0} \nEnergia: {1}", jogador1.GetNome(), jogador1.GetEnergia());
        Console.Read();
    }
}
