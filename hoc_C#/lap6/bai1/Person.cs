public class Person {
    public string Name{set; get;}
    public string Address{set; get;}
    public string EmailAddress{set; get;}
    public string PhoneNumber{set; get;}

    public Person() {
        this.Name = "No name";
        this.Address = "No address";
        this.EmailAddress = "No email address";
        this.PhoneNumber = "No phone number";
    }

    public virtual string toString() {
        return ($"{Name} {Address} {EmailAddress} {PhoneNumber}");
    }
    
}