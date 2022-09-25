using Newtonsoft.Json;
class EditI4
{
    public void EditStudentI4(string id)
    {
        Student? temp = JsonConvert.DeserializeObject<Student>(File.ReadAllText(@$"./data/student/{id}.json"));
        if (temp == null)
        {
            Console.WriteLine("Data Load Error");
        }
        else
        {
            bool exits = false;
            while (true)
            {
                Console.Clear();
                temp.ShowI4();
                Console.WriteLine("1. Update information");
                Console.WriteLine("2. Change student status");
                Console.WriteLine("3. Change class");
                Console.WriteLine("4. Back to menu");
                string choice;
                Console.Write("Your choice: ");
                choice = Console.ReadLine() ?? "";
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("The System alow edit \"phone number\" and \"email\" you must edit all it");
                        Console.Write("Enter phoneNumber: ");
                        string phoneNumber = Console.ReadLine() ?? "";
                        Console.Write("Enter mailAddress: ");
                        string mailAddress = Console.ReadLine() ?? "";
                        temp.PhoneNumber = phoneNumber;
                        temp.Email = mailAddress;
                        break;
                    case "2":
                        Console.WriteLine("Change student status");
                        Console.WriteLine("1. Studying\n2. Reserve\n3. Suspended\n4. Dropout\n5.Grauated");
                        Console.Write("Your choice: ");
                        string ch;
                        ch = Console.ReadLine() ?? "";
                        if (ch == "1")
                        {
                            temp.Status = ("Studying");
                        }
                        else if (ch == "2")
                        {
                            temp.Status = ("Reserve");
                        }
                        else if (ch == "3")
                        {
                            temp.Status = ("Suspended");
                        }
                        else if (ch == "4")
                        {
                            temp.Status = ("Dropout");
                        }
                        else if (ch == "5")
                        {
                            temp.Status = ("Grauated");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Change Student Class");
                        while (true)
                        {
                            Console.Write("Enter class: ");
                            string clasS = Console.ReadLine() ?? "";
                            DirectoryInfo DI = new DirectoryInfo(@"./data/class/");
                            FileInfo[] fis = DI.GetFiles();
                            bool check = false;
                            foreach (FileInfo i in fis)
                            {
                                if (clasS.ToUpper().Trim() == i.Name.Remove(i.Name.IndexOf(".")))
                                {
                                    temp.CLASS = clasS.ToUpper().Trim();
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
                        break;
                    case "4":
                        exits = true;
                        break;
                    default:
                        Console.WriteLine("Input error");
                        break;
                }

                string files = JsonConvert.SerializeObject(temp);
                File.WriteAllText(@$"./data/student/{id}.json", files);

                if (exits)
                {
                    break;
                }
            }

        }
    }

    public void EditClassI4(string Class)
    {
        Class? Temp = JsonConvert.DeserializeObject<Class>(File.ReadAllText(@$"./data/class/{Class}.json"));
        if (Temp == null)
        {
            Console.WriteLine("Data Load Error");
        }
        else
        {
            bool exits = false;
            while (true)
            {
                Console.Clear();
                Temp.ShowI4();
                Console.WriteLine("1. Update information");
                Console.WriteLine("2. Change class status");
                Console.WriteLine("3. Show student list");
                Console.WriteLine("4. Back to menu");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine()??"";
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("The System alow edit \"study day\", \"study time\" and \"class room\" you must edit all it");
                        Console.Write("enter study day: ");
                        string study_day = Console.ReadLine() ?? "";
                        Console.Write("enter study_time: ");
                        string study_time = Console.ReadLine() ?? "";
                        Console.Write("enter class room: ");
                        string classRomm = Console.ReadLine() ?? "";
                        Temp.studyDate = study_day;
                        Temp.studyHours = study_time;
                        break;
                    case "2":
                        Console.WriteLine("Change Class status");
                        Console.WriteLine("1. STUDYING\n2. PAUSE\n3. FINISH\n4. CLOSED\n");
                        Console.Write("Your choice: ");
                        string ch = Console.ReadLine() ?? "";
                        if (ch == "1")
                        {
                            Temp.Status = "STUDYING";
                        }
                        else if (ch == "2")
                        {
                            Temp.Status = "PAUSE";
                        }
                        else if (ch == "3")
                        {
                            Temp.Status = "FINISH";
                        }
                        else if (ch == "4")
                        {
                            Temp.Status = ("CLOSED");
                        }
                        break;
                    case "3":
                    Display show =  new Display();
                        show.ShowStudentInClass(Class.ToUpper());
                        Console.WriteLine("\nWaintting back to menu....");
                        System.Threading.Thread.Sleep(3000);
                        break;
                    case "4":
                        exits = true;
                        break;
                    default:
                        Console.WriteLine("input error");
                        break;
                }
                string fs = JsonConvert.SerializeObject(Temp);
                File.WriteAllText(@$"./data/class/{Class}.json", fs);
                if (exits)
                {
                    break;
                }
            }
        } 
    }
}
