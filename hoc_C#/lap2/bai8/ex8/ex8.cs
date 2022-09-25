using System;

class Program
{

    enum weekday
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
    static void Main(string[] args)
    {
        int choice;

        while (true)
        {
            Console.Write("Enter number: ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("number 1 is " + weekday.monday);
                    break;
                case 2:
                    Console.WriteLine("number 1 is " + weekday.tuesday);
                    break;
                case 3:
                    Console.WriteLine("number 1 is " + weekday.wednesday);
                    break;
                case 4:
                    Console.WriteLine("number 1 is " + weekday.thursday);
                    break;
                case 5:
                    Console.WriteLine("number 1 is " + weekday.friday);
                    break;
                case 6:
                    Console.WriteLine("number 1 is " + weekday.saturday);
                    break;
                case 7:
                    Console.WriteLine("number 1 is " + weekday.sunday);
                    break;
                default:
                    Console.WriteLine("Input error");
                    break;
            }

            Console.Write("you want to continue 1-yes 2-no: ");
            int.TryParse(Console.ReadLine(), out choice);
            if (choice == 1) {
                continue;
            }
            else {
                break;
            }
        }
    }
}
