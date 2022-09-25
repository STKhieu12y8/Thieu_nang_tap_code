
int size, max, min;
Console.Write("Nhap so luong phan tu mang: ");
int.TryParse(Console.ReadLine(), out size);

int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    Random ran = new Random();
    array[i] = ran.Next((i), (i + 1000));
}
max = array[0];
min = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] > max) max = array[i];

    if (array[i] < min) min = array[i];
}

Console.WriteLine($"Max is {max} min is {min}");

Console.WriteLine("Cac Phan tu trong mang :");

for (int i = 0; i < size; i++) {
    Console.Write($"{array[i]}  ");
}

