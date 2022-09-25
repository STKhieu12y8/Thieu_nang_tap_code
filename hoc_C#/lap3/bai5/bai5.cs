
int[] arr1 = new int[100];
int[] fr1 = new int[100];
int n, i, j, bien_dem;


Console.Write("\nDem so lan xuat hien cua tung phan tu trong mang trong C#:\n");

Console.Write("Nhap so phan tu can luu giu trong mang: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("Phan tu - {0}: ", i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
    fr1[i] = -1;
}
for (i = 0; i < n; i++)
{
    bien_dem = 1;
    for (j = i + 1; j < n; j++)
    {
        if (arr1[i] == arr1[j])
        {
            bien_dem++;
            fr1[j] = 0;
        }
    }

    if (fr1[i] != 0)
    {
        fr1[i] = bien_dem;
    }
}
Console.Write("\nTan suat xuat hien cua tung phan tu trong mang la: \n");
for (i = 0; i < n; i++)
{
    if (fr1[i] != 0)
    {
        Console.Write("Phan tu {0} xuat hien {1} lan\n", arr1[i], fr1[i]);
    }
}