using System;
class aula06
{
    double valorproduto =5.6;double valorvenda = 0 ;double lucro = 0.1;
    string produto = "pastel";
    static void Main(string[] args)
    {
        double valorproduto = 5.6, valorvenda, lucro = 0.1;
        string produto="pastel";
        valorvenda = valorproduto + (valorproduto * lucro);
        Console.Write("\nProduto______________{0,11}\t", produto);
        Console.Write("\nVal.Compra____________{0,10:c}\t", valorproduto);
        Console.Write("\nLucro________________{0,11:p}\t", lucro);
        Console.Write("\nVal.Venda_____________{0,10:c}\t", valorvenda);
        Console.Read();
    }
}

