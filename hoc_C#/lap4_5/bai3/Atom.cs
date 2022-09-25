public class Atom {
    public int atomic {set; get;}
    public string symbol{set; get;}
    public double atomic_weight{set; get;}
    public int atomic_number{set; get;}

    public Atom(int atomic, string symbol, double atomic_weight, int atomic_number) {
        this.atomic = atomic;
        this.symbol = symbol;
        this.atomic_weight = atomic_weight;
        this.atomic_number = atomic_number;
    }

    public void show() {
        Console.WriteLine($"so hieu nguyen tu: {atomic} Ky hieu hoa hoc: {symbol} Can nang: {atomic_weight} so nguyen tu: {atomic_number}");
    }
}