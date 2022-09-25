Console.Write("Nhap so hieu nguyen tu: ");
int atomic1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap ten nguen to: ");
string symbol1 = Console.ReadLine() ?? "";

Console.Write("Nhap khoi luong: ");
double atomic_weight1;
double.TryParse(Console.ReadLine(), out atomic_weight1); 

Console.Write("Nhap so nguyen tu: ");
int atomic_number1 = Convert.ToInt32(Console.ReadLine());

Atom Ca = new Atom(atomic1, symbol1, atomic_weight1, atomic_number1);
Ca.show();