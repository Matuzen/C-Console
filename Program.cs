using System;

namespace Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
                Console.WriteLine("Impar");

            Console.ReadLine();

            Console.WriteLine("Qual a hora atual?");
            double hora = double.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }

            else if (hora < 18) // else garante a exclusão do if acima
            {
                Console.WriteLine("Boa tarde!");
            }

            else if (hora < 24)
            {
                Console.WriteLine("Boa noite");
            }

            Console.ReadLine();

            Console.WriteLine("Testando o Vetor");

            // string s = Console.ReadLine(); ou
            string[] v = Console.ReadLine().Split(' '); 
            // vetor definido por uma string onde ele recebe o que o usuário digitar e faz a separação por espaço pelo Split
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            
        }
    }
}
