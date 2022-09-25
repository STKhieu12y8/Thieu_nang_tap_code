using System;

class Program
{

    static double InchsToCentimet(int inchs)
    {
        double cm;
        cm = 2.54 * inchs;
        return cm;
    }

    static double CentimetToInchs(int cm)
    {
        double inch;
        inch = cm / 2.54;
        return inch;
    }

    static void Main(string[] args)
    {
        int choice, inch, cm, choic2;
        while (true)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. INCHS to CENTIMET");
                Console.WriteLine("2. CENTIMET to INCHS");
                Console.WriteLine("0. exit");
                Console.Write("your choice: ");
                int.TryParse(Console.ReadLine(), out choice);

            } while (choice > 3);


            switch (choice)
            {
                case 1:
                    Console.Write("enter inchs: ");
                    int.TryParse(Console.ReadLine(), out inch);
                    Console.WriteLine("{0}inch = {1}cm", inch, InchsToCentimet(inch));
                    Console.Read();
                    break;
                case 2:
                    Console.Write("enter Centimet: ");
                    int.TryParse(Console.ReadLine(), out cm);
                    Console.WriteLine("{0}cm = {1}inchs", cm, CentimetToInchs(cm));
                    Console.Read();
                    break;
                case 3:
                    break;
            }
            Console.Write("you want exit: 1-yes    2-no: ");

            int.TryParse(Console.ReadLine(), out choic2);
            
            if (choic2 == 1) {
                break;
            }
            else {
                continue;
            }
        }
    }
}