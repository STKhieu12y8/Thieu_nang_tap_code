using System;
class Program {
    static void Main(string[] args) {
            string? a;
            Console.Write("enter number: ");
            a = Console.ReadLine();
            int d;
            int.TryParse(a, out d);

            for (int i = 1; i < 10; i++) {
                Console.WriteLine("{0} * {1} = {2}", d, i, (d*i));
            }
    }
}