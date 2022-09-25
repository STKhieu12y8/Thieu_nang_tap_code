Console.Write("Nhap ho: ");
string ho = Console.ReadLine() ?? "";

Console.Write("Nhap ten: ");
string ten = Console.ReadLine() ?? "";

Console.Write("Nhap dia chi: ");
string dia = Console.ReadLine() ?? "";

Console.Write("Nhap so bao hiem xa hoi: ");
long sob; long.TryParse(Console.ReadLine(), out sob);

Console.Write("Nhap luong: ");
double luong; double.TryParse(Console.ReadLine(), out luong);

employee nv = new employee(ho, ten, dia, sob, luong);

nv.show();

nv.bouns();