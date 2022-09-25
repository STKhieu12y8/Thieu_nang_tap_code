public class Employee : Person {
    public string? EmployeeId { set; get; }

    public string? department { set; get; }

    public double? salary { set; get; }

    public string? dataHired { set; get; }
    
    public override string toString() {
        return ($"{Name} {Address} {EmailAddress} {PhoneNumber} {EmployeeId} {department} {salary} {dataHired}");
    }

    public virtual double? CaculateBonus() {
     return salary;    
    }
    public virtual string CaculateVacation() {
        return ("Cong them 3 tuan lam viec");
    }
    
}