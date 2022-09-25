
Console.Write("nhap so luong phan tu: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
for (int i = 0; i < size; i++) {
    Console.Write("Nhap phan tu thu " + i + ": ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int[] arr_odd = new int[size/2];
int[] arr_even = new int[size/2];
int j = 0, k = 0;

for(int i = 0; i < size; i++) {
    if (arr[i] % 2 == 0)
    {
        arr_even[j] = arr[i];
        j++;
    }
    else {
        arr_odd[k] = arr[i];
        k++;
    }
}

Console.WriteLine("Cac phan tu mang ban dau");

foreach(int i in arr) {
    Console.Write($"{i} ");
}
Console.Write("\n");

Console.Write("Cac phan tu mang chan: ");
foreach(int i in arr_even) {
    Console.Write($"{i} ");
}
Console.Write("\n");

Console.Write("Cac phan tu mang le: ");
foreach(int i in arr_odd) {
    Console.Write($"{i} ");
}
Console.Write("\n");