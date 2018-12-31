using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.SumAndAverage
{
   public class StartUp
    {
      public  static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Trim()
                .Split(new char[] { ' ', '\t'},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var sumAndAvg = new SumAndAverage(input);
            Console.WriteLine(sumAndAvg);            
        }
    }
    class SumAndAverage
    {

        private List<int> items;
        public SumAndAverage(List<int> arr)
        {
            this.items = arr;
        }

        private int Sum()
        {
            var result = 0;
            for (int i = 0; i < this.items.Count; i++)
            {
                result += this.items[i];
            }
            return result;
        }

        private double Average()
        {
            double result = 0.00d;
            if (this.items.Count == 0)
            {
                return 0;
            }
            result =(double) this.Sum() / this.items.Count;
            return result;
        }

        public override string ToString()
        {
            return $"Sum={Sum()}; Average={Average():f2}";
        }
    }
}
