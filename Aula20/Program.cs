using System;
public class Aula20
{       
    static int i=0;
    static void Main()
    {
        
        string[] nome = new string[10];
        

        while ( i < nome.Length)            
        {
            Console.WriteLine("Digite 10 nomes que serao alocados nos espaços {0} um arrey ",i);
            nome[i]=Console.ReadLine();
            i++;
            

        }
        for ( i=0; i < nome.Length;)
            {
                Console.WriteLine("A posicao {0} de i recebeu o nome: '{1}' do Arrey nome", i, nome[i]);
                i++;
            }
        
        Console.Read();
    } 
}
