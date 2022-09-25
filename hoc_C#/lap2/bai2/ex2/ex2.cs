using System;
class Program {
    static void Main(string[] args) {
        string? a, b, c;
        Console.Write("enter integer number a: ");
        a = Console.ReadLine();
        Console.Write("enter integer number b: ");
        b = Console.ReadLine();
        Console.Write("enter integer number c: ");
        c = Console.ReadLine();

        int x, y, z, max;

        int.TryParse(a, out x);
        int.TryParse(b, out y);
        int.TryParse(c, out z);

        max = x;

        if(max < y) {
            max = y;
        }
        if(max < z) {
            max = z;
        }
        
        Console.Write("Max number is: {0}", max);
    }
}