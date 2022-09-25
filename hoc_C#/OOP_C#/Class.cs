public class Class {
    public string className { get; set; }
    public string Facutly { get; set; }
    public string Status { get; set; }
    public string classRoom { get; set; }
    public string studyDate { get; set; }
    public string studyHours { get; set; }

    public Class(string className, string Facutly, string Status, string classRoom, string studyDate, string studyHours) {
        this.className = className;
        this.Facutly = Facutly;
        this.Status = Status;
        this.classRoom = classRoom;
        this.studyDate = studyDate;
        this.studyHours = studyHours;
    }
    public void ShowI4() {
        Console.Clear();
        Console.WriteLine("Class Information");
        Console.WriteLine("======================================");
        Console.WriteLine("Class Name:    " + className);
        Console.WriteLine("Study Day:     " + studyDate);
        Console.WriteLine("Study Hours:   " + studyHours);
        Console.WriteLine("Class Room:    " + classRoom);
        Console.WriteLine("Status:        " + Status);
        Console.WriteLine("Facutly:       " + Facutly);
        Console.WriteLine("======================================\n");
    }

    public void edit(string studyDate, string studyHour, string classRoom, string status) {
        this.studyDate = studyDate;
        this.studyHours = studyHour;
        this.classRoom = classRoom;
        this.Status = status;
    }
}