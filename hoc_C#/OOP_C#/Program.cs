

while (true)
{
    Console.Clear();
    Console.WriteLine("================================================================");
    Console.WriteLine("---------------VTC Academy Student Manager----------------------");
    Console.WriteLine("================================================================");
    Console.WriteLine("1. Student List Manager");
    Console.WriteLine("2. Class Manager");
    Console.WriteLine("3. Exit Application");
    Console.WriteLine("================================================================");
    Console.Write("# Your choice: ");
    string choice = Console.ReadLine() ?? "";
    Manager MN = new Manager();
    switch (choice)
    {
        case "1":
            MN.StudentMenu();
            break;
        case "2":
            MN.ClassMenu();
            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You sure you want to exit");
            Console.Write("YES-Y   NO-N :  ");
            string ys = Console.ReadLine() ?? "";
            if (ys == "Y" || ys == "y")
            {
                Console.ResetColor();
                Environment.Exit(0);
            }
            Console.ResetColor();
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INPUT ERROR");
            Console.ResetColor();
            break;
    }
}