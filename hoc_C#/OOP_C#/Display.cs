using Newtonsoft.Json;
class Display
{
    public void ShowAllStudent()
    {
        DirectoryInfo DI = new DirectoryInfo(@"./data/student/");
        FileInfo[] fis = DI.GetFiles();
        Console.Clear();
        Console.WriteLine("STUDENTS LIST\n");
        Console.WriteLine("┌────────────────┬──────────────────────────────┬────────────┬──────────────────────┬────────────────────────────────────────────────┐");
        Console.WriteLine("│  {0,-14}│  {1,-28}│  {2,-10}│  {3,-20}│  {4,-46}│", "STUDENT ID", "FULLNAME", "CLASS", "PHONE", "EMAIL");
        foreach (var f in fis)
        {
            Student? st = JsonConvert.DeserializeObject<Student>(File.ReadAllText(f.FullName));
            if (st == null)
            {
                Student bin = new Student("", "", "", "", "", "", "", "", "", "", "");
                st = bin;
            }
            Console.WriteLine("├────────────────┼──────────────────────────────┼────────────┼──────────────────────┼────────────────────────────────────────────────┤");
            Console.WriteLine("│  {0,-14}│  {1,-28}│  {2,-10}│  {3,-20}│  {4,-46}│", st.StudentID, (st.FirstName + " " + st.MiddName + " " + st.LastName), st.CLASS, st.PhoneNumber, st.Email);
        }
        Console.WriteLine("└────────────────┴──────────────────────────────┴────────────┴──────────────────────┴────────────────────────────────────────────────┘");
    }
    public void ShowAllClass()
    {
        DirectoryInfo df = new DirectoryInfo(@"./data/class/");
        FileInfo[] fis = df.GetFiles();
        Console.Clear();
        Console.WriteLine("CLASS LIST");
        Console.WriteLine("┌──────────┬────────────┬──────────────────────┬──────────────────────┬──────────────────────┐");
        Console.WriteLine("│  {0,-8}│  {1,-10}│  {2,-20}│  {3,-20}│  {4,-20}│", "CLASS", "STUDY DAY", "STUDY TIME", "CLASSROOM", "STATUS");
        foreach (var f in fis)
        {
            Class? cl = JsonConvert.DeserializeObject<Class>(File.ReadAllText(f.FullName));
            if (cl == null)
            {
                Class bin = new Class("", "", "", "", "", "");
                cl = bin;
            }
            Console.WriteLine("├──────────┼────────────┼──────────────────────┼──────────────────────┼──────────────────────┤");
            Console.WriteLine("│  {0,-8}│  {1,-10}│  {2,-20}│  {3,-20}│  {4,-20}│", cl.className, cl.studyDate, cl.studyHours, cl.classRoom, cl.Status);
        }
        Console.WriteLine("└──────────┴────────────┴──────────────────────┴──────────────────────┴──────────────────────┘");
    }
    public void ShowStatusClass(string status)
    {
        DirectoryInfo df = new DirectoryInfo(@"./data/class/");
        FileInfo[] fis = df.GetFiles();
        Console.Clear();
        Console.WriteLine("CLASS LIST");
        Console.WriteLine("┌──────────┬────────────┬──────────────────────┬──────────────────────┬──────────────────────┐");
        Console.WriteLine("│  {0,-8}│  {1,-10}│  {2,-20}│  {3,-20}│  {4,-20}│", "CLASS", "STUDY DAY", "STUDY TIME", "CLASSROOM", "STATUS");
        foreach (var f in fis)
        {
            Class? cl = JsonConvert.DeserializeObject<Class>(File.ReadAllText(f.FullName));
            if (cl == null)
            {
                Class bin = new Class("", "", "", "", "", "");
                cl = bin;
            }
            if (cl.Status == status)
            {
                Console.WriteLine("├──────────┼────────────┼──────────────────────┼──────────────────────┼──────────────────────┤");
                Console.WriteLine("│  {0,-8}│  {1,-10}│  {2,-20}│  {3,-20}│  {4,-20}│", cl.className, cl.studyDate, cl.studyHours, cl.classRoom, cl.Status);
            }
        }
        Console.WriteLine("└──────────┴────────────┴──────────────────────┴──────────────────────┴──────────────────────┘");
    }
    public void ShowStudentInClass(string classS)
    {
        DirectoryInfo df = new DirectoryInfo(@"./data/student/");
        FileInfo[] fis = df.GetFiles();
        Console.Clear();
        Console.WriteLine($"STUDENTS LIST IN {classS}\n");
        Console.WriteLine("┌────────────────┬──────────────────────────────┬────────────┬──────────────────────┬────────────────────────────────────────────────┐");
        Console.WriteLine("│  {0,-14}│  {1,-28}│  {2,-10}│  {3,-20}│  {4,-46}│", "STUDENT ID", "FULLNAME", "CLASS", "PHONE", "EMAIL");
        foreach (var f in fis)
        {
            Student? st = JsonConvert.DeserializeObject<Student>(File.ReadAllText(f.FullName));
            if (st == null)
            {
                Student bin = new Student("", "", "", "", "", "", "", "", "", "", "");
                st = bin;
            }
            if (st.CLASS == classS)
            {

                Console.WriteLine("├────────────────┼──────────────────────────────┼────────────┼──────────────────────┼────────────────────────────────────────────────┤");
                Console.WriteLine("│  {0,-14}│  {1,-28}│  {2,-10}│  {3,-20}│  {4,-46}│", st.StudentID, (st.FirstName + " " + st.MiddName + " " + st.LastName), st.CLASS, st.PhoneNumber, st.Email);
            }
        }
        Console.WriteLine("└────────────────┴──────────────────────────────┴────────────┴──────────────────────┴────────────────────────────────────────────────┘");
    }
    public string? ShowPathFileStduent(string id)
    {
        DirectoryInfo DI = new DirectoryInfo(@"./data/student/");
        FileInfo[] fis = DI.GetFiles();
        bool check = false;
        foreach (var f in fis)
        {
            if (id == f.Name.Remove(f.Name.IndexOf(".")))
            {
                check = true;
            }

        }

        if (check)
        {
            return ($"{id}.json");
        }
        else
        {
            return null;
        }
    }
    public string? ShowPathFileClass(string Class)
    {
        DirectoryInfo DI = new DirectoryInfo(@"./data/class/");
        FileInfo[] fis = DI.GetFiles();
        bool check = false;
        foreach (var f in fis)
        {
            if (Class == f.Name.Remove(f.Name.IndexOf(".")))
            {
                check = true;
            }

        }

        if (check)
        {
            return ($"{Class}.json");
        }
        else
        {
            return null;
        }
    }
}
