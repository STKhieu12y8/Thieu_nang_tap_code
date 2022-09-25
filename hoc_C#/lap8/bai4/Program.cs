public class Amount {
    public double Salary {set; get;}
    public double Bonus {set; get;}
}

public class Program {
    static void Main(string[] args) {
        Amount nv = new Amount();

        double salary = 100000;
        double bonus = 110000;
        
        if (salary < 60000) {
            throw new persionName.AmountException("luong thap hon");
        }
        else {
            nv.Salary = salary;
        }

        if (bonus > 10000) {
            throw new persionName.AmountException("thuong qua muc ");
        }
        else {
            nv.Bonus = bonus;
        }

    }            
}