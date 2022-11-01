using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procvičování_11_1
{
    public class Kasa
    {
        public void Run()
        {
            int FullPrice = 0, Price = 0; bool procesed = true;
            Console.WriteLine("zadávájte částky:");
            while(procesed)
            {
                Price = Int32.Parse(Console.ReadLine());
                FullPrice += Price;
                if(Price == 0) procesed = false;
            }
            if(FullPrice > 800)
            {
                FullPrice = FullPrice - (FullPrice / 100 * 5);
            }
            else if (FullPrice > 1000)
            {
                FullPrice = FullPrice - (FullPrice / 100 * 10);
            }
            else if (FullPrice > 2000)
            {
                FullPrice = FullPrice - (FullPrice / 100 * 15);
            }
            Console.WriteLine($"konečná částka je {FullPrice}");
        }
    }
}
