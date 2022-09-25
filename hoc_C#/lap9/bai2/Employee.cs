public class Employee {
    public string name { get; set; }
    public string address { get; set; }

    public Employee(string name, string address) {
        this.name = name;
        this.address = address;
    }

    public override string ToString(){
        return ($"{name} {address}");
    }
}