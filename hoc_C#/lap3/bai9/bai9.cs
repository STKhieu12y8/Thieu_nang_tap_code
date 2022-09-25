Console.Write("nhap cau: ");


string str = Console.ReadLine() ?? "";


string[] arr = str.Split(" ");
Console.WriteLine("tong so tu trong cau: "+ arr.Length);