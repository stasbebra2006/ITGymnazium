using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objednávky
{
    public class Bobster
    {
        public void Run()
        {
            double sum = 0;
            double sleva = 0;
            double DPH = 0;
            double x;
            double kolik;
            bool processed = true;
            int counter = 0;
            while(processed)
            {
                Console.WriteLine("#############");
                Console.WriteLine("Zadejte počet:");
                x = Double.Parse(Console.ReadLine());
                if(x == 0)
                {
                    processed = false;
                }
                else
                {
                    counter++;
                    Console.WriteLine("#############");
                    Console.WriteLine("Zadejte částku:");
                    kolik = Double.Parse(Console.ReadLine());
                    sum += kolik * x;
                }
            }
            if (counter > 5)
            {
                Console.WriteLine("-------------");
                sleva = sum * 20 / 100;
                sum = sum - sleva;
                DPH = sum * 21 / 100;
                Console.WriteLine($"Výsledek je(se slevou): {sum}");
                Console.WriteLine($"Výsledek z DPH:{sum + DPH}");
            }
            else
            {
                Console.WriteLine("-------------");
                DPH = sum * 21 / 100;
                Console.WriteLine(DPH);
                Console.WriteLine($"Výsledek je: {sum}");
                Console.WriteLine($"Výsledek z DPH:{sum + DPH}");
            }
        }
    }
}
