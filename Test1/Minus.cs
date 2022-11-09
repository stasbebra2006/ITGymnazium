

namespace Test1
{
    public class Minus
    {
        public void app()
        {
            bool processed = true;
            while (processed)
            {
                int cislo;
                Console.WriteLine(" Zadej číslo");
                cislo = SafelyConvertToInt(Console.ReadLine());
                if (cislo == -1000)
                {
                    processed = false;
                }
                else
                {
                    cislo = cislo - 5000;
                    Console.WriteLine(cislo);
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
