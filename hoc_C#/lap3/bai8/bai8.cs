using System;
using System.Linq;
using System.Collections.Generic;

class Program
{

    static public void Main()
    {

        string[] subjects = { "Java", "Python", "Swift", "CSS",
                          "C#", "Django", "C++", "Javascript",
                          "HTML", "PHP" };

        Console.Write("The subjects are: \n");
        Console.WriteLine(string.Join(", ", subjects));


        var subjectSplit = from i in Enumerable.Range(0, subjects.Length)
                           group subjects[i] by i / 3;

        Console.WriteLine("\nThe group of subjects are:");
        foreach (var subject in subjectSplit)
            subjectView(string.Join(",  ", subject.ToArray()));
    }

    static void subjectView(string subject)
    {
        Console.WriteLine(subject);
    }
}