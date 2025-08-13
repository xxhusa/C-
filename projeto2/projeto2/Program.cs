using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            pessoa objJogador;
            pessoa camisa10;
            pessoa camisa7;

            objJogador = new pessoa();
            camisa10 = new pessoa();
            camisa7 = new pessoa();

            objJogador.cadastrar();
            camisa10.cadastrar();
            camisa7.cadastrar();

            objJogador.Exibir();
            camisa10.Exibir();
            camisa7.Exibir();

            




        }
    }
}
