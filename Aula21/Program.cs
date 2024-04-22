using System;

class aula21
{
    static void Main()
    {
        string pass, user;
        string[] username = new string[1];
        string[] usersenha = new string[1];
        char op;
    Label:
        Console.WriteLine("\t<<---------------------------------------->>\t");
        Console.WriteLine("\tInsert new User/Pass[a]\n \tLogin User/Pass[b]\n\t");
        op = Char.Parse(Console.ReadLine());

        switch (op)
        {
            case 'a':
                Console.WriteLine("Digite o nome do usuário...");
                username[0] = Console.ReadLine();
                Console.WriteLine("Digite a senha do usuário...");
                usersenha[0] = Console.ReadLine();
                goto Label;
                

            case 'b':
                
                bool loginSucceeded=false;

                do
                {
                    Console.WriteLine("Processo de login...");
                    Console.WriteLine("User: ");
                    user = Console.ReadLine();
                    Console.WriteLine("Pass: ");
                    pass = Console.ReadLine();

                    if (usersenha[0] == pass && username[0] == user)
                    {
                        loginSucceeded = true;
                    }
                    else
                    {
                        Console.WriteLine("Senha ou usuário inválidos...");
                    }
                } while (!loginSucceeded);

                Console.WriteLine("Usuário {0} e senha {1} validados...!", username[0], usersenha[0]);
                goto Label;

            default:
                break;
        }
    }
}
