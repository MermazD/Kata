using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        public static string MultipleDeTrois(int nombre)
        {
            if ((nombre % 3) == 0)
                return "Fizz";
            return string.Empty;
        }

        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                string s = string.Empty;
                s = MultipleDeTrois(i);
                Console.WriteLine(string.Format("Nombre : {0}, valeur : {1}",i,s));
            }
            Console.ReadKey();
        }
    }
}
