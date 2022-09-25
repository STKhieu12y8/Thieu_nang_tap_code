Console.WriteLine("Chuong trinh tim kiem mang");

int size = 10, temp;
int[] arr = new int[size]; 

for (int i = 0; i < size; i++) {
    Console.Write("arr {0} = ", i);
    int.TryParse(Console.ReadLine(), out arr[i]);
}

Console.Write("Nhap so muon kiem tra: ");
int.TryParse(Console.ReadLine(), out temp);

for (int i = 0; i < size; i++) {
    if (temp == arr[i]) {
        Console.Write($"Vi tri cua phan tu trong mang thu {i}");
        break;
    }
}