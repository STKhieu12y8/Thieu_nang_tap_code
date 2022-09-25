public class Student {
    public string StudentID { get; init; }
    public string BirthDate { get; set; }
    public string Addresses { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }
    public string CLASS { get; set; }
    public string Nodes { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set;}
    public string MiddName { get; set; }
    public Student(string StudentID, string FirstName, string LastName, string MiddleName, string BirthDate, string addresses, string phoneNumber, string email, string status, string Class, string node) {
        this.FirstName = FirstName;
        this.MiddName = MiddleName;
        this.LastName = LastName;
        this.StudentID = StudentID;
        this.BirthDate = BirthDate;
        this.Addresses = addresses;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.Status = status;
        this.CLASS = Class;
        this.Nodes = node;
    }
    public void ShowI4() {
        Console.WriteLine("========================================================");
        Console.WriteLine("                   STUDENT INFOMATION");
        Console.WriteLine("========================================================");
        Console.WriteLine("Student ID:   "+StudentID);
        Console.WriteLine("FirstName:    "+FirstName);
        Console.WriteLine("MiddleName:   "+MiddName);
        Console.WriteLine("LastName:     "+LastName);
        Console.WriteLine("Birthday:     "+BirthDate);
        Console.WriteLine("Address:      "+Addresses);
        Console.WriteLine("Phone:        "+PhoneNumber);
        Console.WriteLine("Email:        "+Email);
        Console.WriteLine("Class Name:   "+CLASS);
        Console.WriteLine("Note:         "+Nodes);
        Console.WriteLine("Status:       "+Status);
        Console.WriteLine("=======================================================\n");
    }
    // public void Edit_P_M(string phoneNumber, string email) {
    //     this.PhoneNumber = phoneNumber;
    //     this.Email = email;
    // }
    // public void Edit_S(string Status) {
    //     this.Status = Status;
    // }
    // public void Edit_C(string Class) {
    //     this.CLASS = Class;
    // }
    // public string GetFirstName() {
    //     return this.FirstName;
    // }
    // public string GetLastName() {
    //     return this.LastName;
    // }
    // public string GetMiddleName() {
    //     return this.MiddName;
    // }
    // public string GetStudentId() {
    //     return this.StudentID;
    // }
    // public string GetBirthDate() {
    //     return this.BirthDate;
    // }
    // public string GetPhoneNumber() {
    //     return this.PhoneNumber;
    // }
    // public string GetEmail() {
    //     return this.Email;
    // }
    // public string GetClass() {
    //     return this.CLASS;
    // }
    //public string GetNode() {
        // return this.Nodes;
    // }
}