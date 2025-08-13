using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2
{
    class pessoa
    {
        public string nome;
        public string email;
        public string telefone;

        public void cadastrar() {

        Console.WriteLine("Digite o nome do jogador:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu E-mail:");
            email = Console.ReadLine();

            Console.WriteLine("Digite seu telefone:");
            telefone = Console.ReadLine();

        }

        public void Exibir()
        {
            Console.WriteLine("nome: {0}" ,nome);
            Console.WriteLine("email : {0}" ,email);
            Console.WriteLine("telefone : {0}" ,telefone);
        }

    }
}
