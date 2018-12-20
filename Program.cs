using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 0;
            int number = 1;
            while (loop < 10) // tant que la boucle "loop" est inférieur a 10 répétions, elle continue
            {
                Console.WriteLine("Bonjour, je suis le message n°" + number++);
                loop++;
            }
        }
    }
}
