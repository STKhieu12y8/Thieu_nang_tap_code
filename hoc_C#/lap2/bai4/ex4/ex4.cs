using System;
class Program {
    static void Main(string[] args) {
        string? price;
        int before;
        Console.Write("enter price: ");
        price = Console.ReadLine();
        int.TryParse(price, out before);
        Console.WriteLine("Sales is 8.25%");
        double tax = ((before * 8.25) / 100);
        Console.WriteLine("price after tax: {1}$\n tax: {0}$", tax, (before + tax));
    }
}