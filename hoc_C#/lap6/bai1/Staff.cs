public class Staff : Employee
{
    public override string CaculateVacation()
    {
        return "Cong 4 tuan lam viec";
    }
    public override double? CaculateBonus()
    {
        return salary += salary * 0.6;
    }

    public override string toString()
    {
        return ($"{Name} {Address} {EmailAddress} {PhoneNumber} {EmployeeId} {department} {salary} {dataHired}");
    }
}