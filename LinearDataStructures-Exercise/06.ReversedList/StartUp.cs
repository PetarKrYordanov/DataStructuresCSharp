using System;
public class StartUp
{
    public static void Main(string[] args)
    {
        var list = new ReversedList<int>();

        for (int i = 0; i <= 5; i++)
        {
            list.Add(i);
        }
        Console.WriteLine(list[5] +" " + list[0]);
        list.RemoveAt(4);

        Console.WriteLine(string.Join(" ",list));
        Console.WriteLine($"Capacity: {list.Capacity} {list.Count}");

        list.RemoveAt(0);
        Console.WriteLine(list[0]);
        Console.WriteLine(list[3]);

        Console.WriteLine(string.Join(" ", list));
        Console.WriteLine($"Capacity: {list.Capacity} {list.Count}");

    }
}

