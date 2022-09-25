[Serializable]
public class Student
{
    public string? name { set; get; }
    public int age { set; get; }
    public double mark { set; get; }

    public void show() {
        Console.WriteLine($"Name: {name}, age: {age}, mark: {mark}");
    }
}