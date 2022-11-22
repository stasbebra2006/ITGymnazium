using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTemp
{
    public class TempApp
    {
        public void Run()
        {
            double tempSum = 0;
            double temp;
            double i = 0;
            bool processed = true;
            while (processed)
            {
                Console.WriteLine("Write temp");
                temp = Convert.ToDouble(Console.ReadLine());
                if(temp == int.MinValue)
                {
                    processed = false;
                }
                else
                {
                    tempSum += temp;
                    i++;
                }
            }
            double averageTemp = Math.Round(tempSum / i, 1);
            Console.WriteLine($"averageTemp = {averageTemp}");
        }
    }
}
