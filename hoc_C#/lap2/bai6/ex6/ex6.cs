using System;

class Program {
    static void Main(string[] args) {
        double min_base = 5.15;
        int max_hours = 56;
        double bases;
        int hours;

        Console.WriteLine("Min base pay: 5.15$\nMax hours: 56h");

        do
        {
            Console.Write("enter base: ");
            double.TryParse(Console.ReadLine(), out bases);
            if (bases < min_base)
            {
                Console.WriteLine("base salary is too low");
            }
        } while (bases < min_base);

        do
        {
            Console.Write("enter hours: ");
            int.TryParse(Console.ReadLine(), out hours);
            if (hours > max_hours)
            {
                Console.WriteLine("exceed the specified number of hours");
            }
        } while (hours > max_hours);
    }
}
