using System;
using System.Linq.Expressions;

// Try Catch Finally; Disparo de exeption;
namespace Calc
{
    class Area
    {
        public static float Quad(float Base, float Altura)
        {

            if (Base == 0 || Altura == 0)
            {
                throw new Exception("Base ou Altura sao iguais a zero:");
            }

            return Base * Altura;
        }
    }
}
class Aula53
{
    static void Main()
    {
       float area, altura;
        

        try
        {
            area=Calc.Area.Quad(10.1f,12.2f);
            Console.WriteLine(area);
        }
        catch (Exception x)
        {
            Console.WriteLine("Erro:  {0}", x.Message);
            Console.WriteLine("Ex:{0}", x.GetType());
        } finally 
        {
            Console.WriteLine("Fim do processo...");
        }

        Console.Read();
    }
}