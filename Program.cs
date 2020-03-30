using System;

namespace Nomecompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva seu primeiro nome: ");
            string nome = Console.ReadLine();
            Console.Write("Agora digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Entao seu nome é " + nome + " " + sobrenome);
            Console.WriteLine("Então seu nome em catalogo é assim " + sobrenome.ToUpper() + ", " + nome);

            Console.ReadKey();
        }
    }
}
