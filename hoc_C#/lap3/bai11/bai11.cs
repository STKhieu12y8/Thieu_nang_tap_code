using System.Text.RegularExpressions;

Console.Write("Nhap dia chi mail: ");
string str = Console.ReadLine() ?? "";

if (Regex.IsMatch(str.ToUpper(), "^[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,}$"))
{
Console.WriteLine($"{str} la dia chi mail.");
}
else
{
Console.WriteLine($"{str} khong phai dia chi mail.");
}