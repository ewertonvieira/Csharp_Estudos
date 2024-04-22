// Interfaces;
using System;

public interface Veiculos
{
    void Ligar();
    void Desligar();
    void Info();
}
public interface Combate
{
    void Disparar();
}
class Carro:Veiculos,Combate
{
    bool ligado;
    private int Municao;
    public void setMunicao(int Quantidade)
    {
        this.Municao = Quantidade;
    }
    public Carro()
    {
        setMunicao (100);
    }
    public void Ligar()
    {
        this.ligado = true;
    }
    public void Desligar()
    {
        this.ligado = false;   
    }
    public void Disparar()
    {

    }
    public void Info()
    {

    }
}
class Aula43
{
    static void Main()
    {
    }
}