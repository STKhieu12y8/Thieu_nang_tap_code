class Manager
{
    public void StudentMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("================================================================");
            Console.WriteLine("       Student List Manager                                     ");
            Console.WriteLine("================================================================");
            Console.WriteLine("1. ADD Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Show All Student");
            Console.WriteLine("4. Back to Main Menu");
            Console.WriteLine("================================================================");
            Console.Write("Your Choice: ");
            int choice;
            bool exists = false;
            int.TryParse(Console.ReadLine(), out choice);
            Display show = new Display();
            switch (choice)
            {
                case 1:
                    Add newStudent = new Add();
                    if (newStudent.AddStudenT())
                    {
                        Console.WriteLine("ADD SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("ADD ERROR");
                    };
                    break;
                case 2:
                    Console.Write("Search Student By ID: ");
                    string ids = Console.ReadLine() ?? "";
                    string? test = show.ShowPathFileStduent(ids);

                    if (test == null)
                    {
                        test = "";
                    }

                    if (ids.Trim().ToUpper() == test.Remove(test.IndexOf(".")))
                    {
                        EditI4 st = new EditI4();
                        st.EditStudentI4(ids.Trim().ToUpper());
                    }
                    else
                    {
                        Console.WriteLine("ID is not Available");
                        System.Threading.Thread.Sleep(1500);
                    }
                    break;
                case 3:
                    show.ShowAllStudent();
                    Console.Write("Input student ID to view details or input \"any key\" to back to menu: ");
                    string chose = Console.ReadLine() ?? "";
                    string? check = show.ShowPathFileStduent(chose);

                    if (check == null)
                    {
                        check = "";
                    }
                    else
                    {

                        if (chose.Trim().ToUpper() == check.Remove(check.IndexOf(".")))
                        {
                            EditI4 st = new EditI4();
                            st.EditStudentI4(chose.Trim().ToUpper());
                        }
                        else
                        {
                            Console.WriteLine("Load data error");

                        }
                    }
                    break;
                case 4:
                    exists = true;
                    break;
                default:
                    break;
            }
            if (exists)
            {
                break;
            }
        }
    }

    public void ClassMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("================================================================");
            Console.WriteLine("       Classes Manager                                          ");
            Console.WriteLine("================================================================");
            Console.WriteLine("1. ADD Class");
            Console.WriteLine("2. Studying class");
            Console.WriteLine("3. Completed Classes");
            Console.WriteLine("4. Closed Classes");
            Console.WriteLine("5. All Classes");
            Console.WriteLine("6. Back to main menu");
            Console.WriteLine("================================================================");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine() ?? "";
            Display show = new Display();
            EditI4 edit = new EditI4();
            bool exists = false;
            string str;
            switch (choice)
            {
                case "1":
                    Add addClass = new Add();
                    if (addClass.addClass())
                    {
                        Console.WriteLine("ADD SUCCESS");
                    }
                    else
                    {
                        Console.WriteLine("ADD ERROR");
                    }
                    break;
                case "2":
                    show.ShowStatusClass("STUDYING");
                    Console.Write("Input \"class name\" to view details or \"any key\" to back menu: ");
                    str = Console.ReadLine() ?? "";
                    if (str.Trim() == "" || str.Length < 3 || str.Length > 7)
                    {
                    }
                    else
                    {
                        edit.EditClassI4(str.ToUpper().Trim());
                    }
                    break;
                case "3":
                    show.ShowStatusClass("FINISH");
                    Console.Write("Input \"class name\" to view details or \"any key\" to back menu: ");
                    str = Console.ReadLine() ?? "";
                    if (str.Trim() == "" || str.Length < 3 || str.Length > 7)
                    {
                    }
                    else
                    {
                        edit.EditClassI4(str.ToUpper().Trim());
                    }
                    break;
                case "4":
                    show.ShowStatusClass("CLOSE");
                    Console.Write("Input \"class name\" to view details or \"any key\" to back menu: ");
                    str = Console.ReadLine() ?? "";
                    if (str.Trim() == "" || str.Length < 3 || str.Length > 7)
                    {
                    }
                    else
                    {
                        edit.EditClassI4(str.ToUpper().Trim());
                    }
                    break;
                case "5":
                    show.ShowAllClass();
                    Console.Write("Input \"class name\" to view details or \"any key\" to back menu: ");
                    str = Console.ReadLine() ?? "";
                    if (str.Trim() == "" || str.Length < 3 || str.Length > 7)
                    {
                    }
                    else
                    {
                        edit.EditClassI4(str.ToUpper().Trim());
                    }
                    break;
                case "6":
                    exists = true;
                    break;
            }
            if (exists)
            {
                break;
            }
        }
    }

}