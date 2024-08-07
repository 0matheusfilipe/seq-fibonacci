using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termo1 = 0;
            int termo2 = 1;
            int somaTermos = 0;

            Console.Write("Insira o número de valores da sequência: ");
            int numValores = int.Parse(Console.ReadLine());
            Console.WriteLine("Sequência de Fibonacci com " + numValores + " valores: ");
            for (int i = 0; i < numValores; i++) 
            {
                if(i < numValores - 1)
                {
                    Console.Write(termo1 + ", ");
                }
                else
                {
                Console.Write(termo1);
                }
                somaTermos = termo1 + termo2;
                termo1 = termo2;
                termo2 = somaTermos;
            }
            Console.ReadKey();
        }
    }
}
