namespace _04.RemoveOddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var intArr = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            RamoveOddOccurences(intArr);
            Console.WriteLine(string.Join(" ", intArr));
        }

        private static void RamoveOddOccurences(List<int> list)
        {
            List<int> numbersSearched = list.Distinct().ToList();

            foreach (var currentNumber in numbersSearched)
            {
                int occurrences = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == currentNumber)
                    {
                        occurrences++;
                    }
                }

                if (occurrences % 2 == 1)
                {
                    list.RemoveAll(e => e == currentNumber);
                }
            }
        }
    }
}
