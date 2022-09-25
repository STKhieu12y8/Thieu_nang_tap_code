using Newtonsoft.Json;
using System.Text.RegularExpressions;
class Add
{
    public bool AddStudenT()
    {
        Console.Clear();
        Console.WriteLine("ADD STUDENT");

        Console.Write("STUDENT ID: ");
        string id = Console.ReadLine() ?? "";

        Console.Write("FirstName: ");
        string firstName = Console.ReadLine() ?? "";

        Console.Write("MiddName: ");
        string middtName = Console.ReadLine() ?? "";

        Console.Write("LastName: ");
        string lastName = Console.ReadLine() ?? "";

        string date;
        while (true)
        {
            Console.Write("BirthDate: ");
            date = Console.ReadLine() ?? "";
            if (Regex.IsMatch(date, @"^\d{1,2}/\d{1,2}/\d{4}$"))
            {
                break;
            }
        }

        Console.Write("Address: ");
        string address = Console.ReadLine() ?? "";

        string sdt;
        while (true)
        {
            Console.Write("Phone Number: ");
            sdt = Console.ReadLine() ?? "";
            if (Regex.IsMatch(sdt, @"^((09(\d){8})|(086(\d){7})|(088(\d){7})|(089(\d){7})|(01(\d){9}))$"))
            {
                break;
            }
        }

        string email;
        while (true)
        {
            Console.Write("Email Addrees: ");
            email = Console.ReadLine() ?? "";
            if (Regex.IsMatch(email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                break;
            }
        }

        string status;
        while (true)
        {
            Console.WriteLine("CHOSE STATUS\n1. Studying\n2. Reseve\n3. Suspended\n4. Dropout\n5. Graduaed");
            Console.Write("Chose: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                status = "Studying";
                break;
            }
            else if (choice == "2")
            {
                status = "Reseve";
                break;
            }
            else if (choice == "3")
            {
                status = "Suspended";
                break;
            }
            else if (choice == "4")
            {
                status = "Dropout";
                break;
            }
            else if (choice == "5")
            {
                status = "Graduaed";
                break;
            }
            else
            {
                Console.WriteLine("chose error\n\nre_choice\n");
            }
        }

        string clasS;
        while (true)
        {
            Console.Write("Class: ");
            clasS = Console.ReadLine() ?? "";
            DirectoryInfo DI = new DirectoryInfo(@"./data/class/");
            FileInfo[] fis = DI.GetFiles();
            bool check = false;
            foreach (FileInfo i in fis)
            {
                if (clasS.ToUpper().Trim() == i.Name.Remove(i.Name.IndexOf(".")))
                {
                    clasS = i.Name.Remove(i.Name.IndexOf("."));
                    check = true;
                }
            }

            if (check)
            {
                break;
            }
            else
            {
                Console.WriteLine("Class is not available");
            }

        }

        Console.Write("Node: ");
        string node = Console.ReadLine() ?? "";

        string files = JsonConvert.SerializeObject(new Student(id.ToUpper().Trim(), firstName.Trim(), lastName.Trim(), middtName.Trim(), date, address, sdt.Trim(), email.Trim(), status, clasS, node));

        File.WriteAllText(@$"data\student\{(id.ToUpper().Trim())}.json", files);
        return true;
    }

    public bool addClass()
    {

        Console.Clear();

        Console.WriteLine("ADD CLASS");

        // Console.Write("Class Name: ");
        // string className = Console.ReadLine() ?? "";
        string className;
        while (true)
        {
            Console.Write("Class: ");
            className = Console.ReadLine() ?? "";
            DirectoryInfo DI = new DirectoryInfo(@"./data/class/");
            FileInfo[] fis = DI.GetFiles();
            bool check = true;
            foreach (FileInfo i in fis)
            {
                if (className.ToUpper().Trim() == i.Name.Remove(i.Name.IndexOf(".")))
                {
                    Console.WriteLine("Class is available");
                    check = false;
                }
            }

            if (check)
            {
                break;
            }
        }

        Console.Write("Study day: ");
        string studyDay = Console.ReadLine() ?? "";

        Console.Write("Study time: ");
        string studyTime = Console.ReadLine() ?? "";

        Console.Write("Class room: ");
        string classRoom = Console.ReadLine() ?? "";

        string status;
        while (true)
        {
            Console.WriteLine("CHOSE STATUS");
            Console.WriteLine("1. STUDYING\n2. PAUSE\n3. FINISH \n4. CLOSED\n");
            Console.Write("Chose: ");
            string choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                status = "STUDYING";
                break;
            }
            else if (choice == "2")
            {
                status = "PAUSE";
                break;
            }
            else if (choice == "3")
            {
                status = "FINISH";
                break;
            }
            else if (choice == "4")
            {
                status = "CLOSED";
                break;
            }
            else
            {
                Console.WriteLine("chose error\n\nre_choice\n");
            }
        }

        Console.Write("Facutly: ");
        string facutly = Console.ReadLine() ?? "";

        string cls = JsonConvert.SerializeObject(new Class((className.ToUpper().Trim()), facutly, status, classRoom, studyDay, studyTime));
        File.WriteAllText(@$"./data/class/{(className.ToUpper().Trim())}.json", cls);

        return true;
    }
}
