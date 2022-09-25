using Customer;
using Order;
using System;
public class Program
{
    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }
    static void Main(string[] args)
    {
        Action<string> action;
        Console.Write("moi ban nhap ten: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Nhap dia chi: ");
        string address = Console.ReadLine() ?? "";
        Console.WriteLine("Mon hang muon mua: ");
        Console.Write("1 banh my\t 2 ro gia\t 3 mua ca 2\t: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Build bill = new Build(name, address, choice);
        action = ShowMessage;
        action(" hoan thanh");
    }
}
