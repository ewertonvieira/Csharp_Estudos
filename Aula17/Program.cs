using System;
public class aula17
{
    static void Main(string[] args)
    {
        double[] numero = new double[5];
        string[] nome = {"Cachorro","Gato","Leao","Coelho"};//o arrey nome tem o numero de membros declarados, 4
        numero[0]= 345.3f;
        numero[1]= 34.4f;
        numero[2] = 3.3f; 
        Console.WriteLine(nome[2] + " " + numero[2]);
        Console.Read();
    }
}