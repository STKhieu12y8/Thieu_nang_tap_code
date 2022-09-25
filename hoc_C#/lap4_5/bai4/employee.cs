public class employee
{
    public string FirstName { set; get; }

    public string LastName { set; get; }

    public string Address { set; get; }

    public long sin { set; get; }

    public double salary { set; get; }

    public employee (string firstName, string lastName, string address, long sin, double salary) {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
        this.salary = salary;
        this.sin = sin;
    }

    public void show () {
        Console.WriteLine($"ho: {FirstName,-8} ten: {LastName,-20} dia chi: {Address,-30} so bao hiem xa hoi: {sin,-18} luong: {salary,-10}");
    }

    public void bouns () {
        Console.WriteLine("thuong: {0}", salary*0.05);
    }
}