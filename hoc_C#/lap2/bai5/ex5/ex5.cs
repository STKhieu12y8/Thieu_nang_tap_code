using System;

class Program {
    static void Main(string[] args) {
        int hour;
        int bases;

        Console.Write("enter the number of hour worked: ");
        int.TryParse(Console.ReadLine(), out hour);
        Console.Write("Base pay rate ($): ");
        int.TryParse(Console.ReadLine(), out bases);

        Console.Write("Total pay: {0}$", (hour*bases));
    }
}