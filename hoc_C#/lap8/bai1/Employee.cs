using System;
public class Employee
{
    public static int numberOfEmployees;
    private static int counter;
    private string name;

    public static int Counter
    {
        get { return counter; }
    }

    public string Name {
        set {name = value; }
        get { return name; }
    }

    public Employee (string name) {
        this.name = name;
        counter = ++ counter + numberOfEmployees; ;
    }
}