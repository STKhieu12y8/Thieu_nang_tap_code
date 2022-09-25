public delegate double Conversion(double x);

class DelegateFeetToInch {
    public static double FeetToInch(double x) {
        return x * 12;
    }
}
class Program {
    static void Main(string[] args) {
        Conversion test = new Conversion(DelegateFeetToInch.FeetToInch);
        Console.Write("enter Feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double inches = test(feet);
        Console.WriteLine($"{feet} feet to {inches} inch");

    }
}