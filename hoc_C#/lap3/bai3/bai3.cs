using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr;
        int[] arr2;//đảo ngược của arr

        Console.Write("nhap so dai chuoi: ");
        int.TryParse(Console.ReadLine(), out int n);
        arr = new int[n];
        arr2 = new int[n];

        Console.WriteLine("----------------------------------");

        for (int i = 0; i < n; i++)
        {
            Console.Write("nhap phan tu arr[{0}]: ", i);
            int.TryParse(Console.ReadLine(), out arr[i]);
        }

        int temp = n - 1;

        for (int i = 0; i < n; i++)
        {
            arr2[i] = arr[temp];
            temp--;
        }
        Console.WriteLine("----------------------------------");
        Console.Write("mang goc      : ");

        foreach (int e in arr)
        {
            Console.Write($"{e} ");
        }

        Console.Write("\nmang dao nguoc: ");

        foreach (int e in arr2)
        {
            Console.Write($"{e} ");
        }
    }
}