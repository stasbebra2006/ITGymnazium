using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procvičování_11_1
{
    public class SlovoKrat
    {
        public void Run()
        {
            int krat; string slovo; bool procesed = true;
            while (procesed)
            {
                Console.WriteLine("Napište vlastní slovo a pak kolik krat");
                Console.WriteLine("Slovo:");
                slovo = Console.ReadLine();
                Console.WriteLine("Kolik krat:");
                krat = Int32.Parse(Console.ReadLine());
                if(krat == 0) procesed = false;
                for (int i = 0; i < krat; i++)
                {
                    Console.WriteLine(slovo);
                }
            }
        }
    }
}
