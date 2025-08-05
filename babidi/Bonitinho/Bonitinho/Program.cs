using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonitinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Boa noite, " + nome);
        }
    }
}
