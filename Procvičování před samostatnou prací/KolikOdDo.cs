using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKR1
{

    public class KolikOdDo
    {
        public void run()
        {
            Random random = new Random();
            bool processed = true;
            while (processed)
            {
                int kolik, od, dok;
                Console.WriteLine("Zadejte počet čísel");
                kolik = SafelyConvertToInt(Console.ReadLine());
                if (kolik == 0) { processed = false; }
                else
                {
                    Console.WriteLine("od kolika");
                    od = SafelyConvertToInt(Console.ReadLine());
                    Console.WriteLine("do kolika");
                    dok = SafelyConvertToInt(Console.ReadLine());
                    Console.WriteLine("----------------------------------------");
                    for (int i = 0; i < kolik; i++)
                    {
                        Console.WriteLine(random.Next(od, dok));
                    }
                    Console.WriteLine("----------------------------------------");
                }
            }
        }




        public int SafelyConvertToInt(string x)
        {
            if (int.TryParse(x, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
    }


}
