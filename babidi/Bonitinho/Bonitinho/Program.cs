using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Bonitinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            string nome;
            
            
          

            Console.WriteLine("Calculo de IMC");

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua Altura:");
            altura = double.Parse(Console.ReadLine());
            double mult = (altura * altura);

            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());
            double IMC = peso / mult;

            Console.WriteLine("Seu IMC é : {0}", IMC);

            if (IMC < 18.5) {
                Console.WriteLine("Abaixo do peso");
            } else if (IMC > 18.5 && IMC < 24.49) {
                Console.WriteLine("seu peso esta normal");
            } else if (IMC > 25 && IMC < 29.9){
                Console.WriteLine("Sobrepeso"); 
            } else if (IMC > 30 && IMC < 34.9)
            { Console.WriteLine("Obesidade Grau 1"); 
            }
            else if (IMC > 35 && IMC < 39.9)
            { Console.WriteLine("Obesidade Grau 2"); 
            }else if(IMC >= 40){
                Console.WriteLine("Obesidade Grau3");
            }
            



            //Console.WriteLine("seu saldo:{0} conta:{1}", saldo,conta); // colocando a variavel em ordem,representa cada numero saldo = {0} conta = {1}
            
            //Console.WriteLine("Boa noite e volte sempre ao XereCard "  + nome);

           

        }
    }
}
