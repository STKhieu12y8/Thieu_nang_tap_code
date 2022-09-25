public class Student : Person
{
    public string? StudentID{set; get;}

    public string? className{set; get;}

    public string[] ProgramList{set; get;} = default!;

    public override string toString() {
        return ($"{Name} {Address} {EmailAddress} {PhoneNumber}  {StudentID} {className} {ProgramList}");
    }
}