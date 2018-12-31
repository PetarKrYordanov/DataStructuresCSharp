using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LongestSubsequence
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] sequenceNumber = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;

            List<int> result = new List<int>();

            for (int i = 1; i <= sequenceNumber.Length - 1; i++)
            {
                if (sequenceNumber[i - 1] == sequenceNumber[i])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(sequenceNumber[bestStart] + " ");
            }
        }
    }
}
