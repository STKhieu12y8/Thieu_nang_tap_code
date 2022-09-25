using System;
class Program {
    static void Main(string[] args) {
        string? name, address, phone;

        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter address: ");
        address = Console.ReadLine();
        Console.Write("Enter phone: ");
        phone = Console.ReadLine();

        Console.Write("Name: {0}\tAddress: {1}\tPhone: {2}", name, address, phone);
    }
}