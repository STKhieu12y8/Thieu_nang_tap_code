int number;
int temp, count = 0;

Console.Write("Nhap so: ");
int.TryParse(Console.ReadLine(), out number);

while (number != 0) {
    temp = number % 10;
    count = count + temp;

    number = number / 10;
}

Console.Write("tong cac chu so: " + count);