public class Facutly : Employee
{
    public override string CaculateVacation()
    {
        return "Cong 5 tuan lam viec";
    }
    public override double? CaculateBonus()
    {
        return salary += salary * 0.5;
    }
    public override string toString()
    {
        return ($"{Name} {Address} {EmailAddress} {PhoneNumber} {EmployeeId} {department} {salary} {dataHired}");
    }
}