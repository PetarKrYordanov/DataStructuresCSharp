namespace _05.CountOfOccurrences
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var arrOFInteger = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();
              
            arrOFInteger.Select(e => $"{e} -> {arrOFInteger.Count(z => z == e)} times").Distinct().ToList().ForEach(e => Console.WriteLine(e));
        }
    }
}