using System.IO;

string line_1 = "dong thu nhat";
string line_2 = "dong thu hai";

try
{
    using( TextWriter files = File.CreateText("text.txt")){
        files.WriteLine(line_1);
        files.WriteLine(line_2);
    }

    using (StreamReader sr = new StreamReader("text.txt")) {
        string? str;
        while ((str = sr.ReadLine()) != null)
        {
            Console.WriteLine(str);
        }
    }

}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
