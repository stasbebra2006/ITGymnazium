using System.Linq.Expressions;

namespace Procvičování_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 nebo 2?");
            int x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    SlovoKrat slovoKrat = new SlovoKrat();
                    slovoKrat.Run();
                    break;
                case 2:
                    Kasa kasa = new Kasa();
                    kasa.Run();
                    break;
                default:
                    Console.WriteLine("NEEEE!!!!");
                    break;
            }
        }
    }
}