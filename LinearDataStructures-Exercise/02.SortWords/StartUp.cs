namespace _02.SortWords
{
    using System;
    using System.Linq;

    public class StartUp
   {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(e => e);

            Console.WriteLine(string.Join(" ", inputArr));
        }
    }
}
