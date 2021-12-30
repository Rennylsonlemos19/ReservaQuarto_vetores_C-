using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECT_reservaQuartos.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            estudante[] vect = new estudante[10];

            Console.WriteLine("OLÁ QUERIDO CLIENTE");
            Console.WriteLine();
            Console.Write("QUANTOS QUARTOS SERÃO ALUGADOS ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"ALUGUEL #{i}");
                Console.Write("NOME:");
                string nome = Console.ReadLine();   
                Console.Write("E-mail:");
                string email = Console.ReadLine();
                Console.Write("QUARTO: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("QUARTOS OCUPADOS: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }      
            Console.ReadKey();
        }
    }
}
