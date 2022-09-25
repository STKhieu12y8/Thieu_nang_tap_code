using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

while (true)
{
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("1. Add a list Student and save File ");
    Console.WriteLine("2. Load list student from file ");
    Console.WriteLine("3. Exit program");
    Console.Write("your chose: ");
    int chose = int.Parse(Console.ReadLine()??"");
    if (chose == 1)
    {
        Console.Write("nhap ten: "); string name = Console.ReadLine() ?? "";
        Console.Write("nhap tuoi: "); int age = int.Parse(Console.ReadLine()??"");
        Console.Write("Nhap diem: "); double mark = double.Parse(Console.ReadLine()??"");
        using (TextWriter fs = File.CreateText("dta.json"))
        {
            Student student = new Student(){
                name = name,
                age = age,
                mark = mark
            };
            string obj = JsonConvert.SerializeObject(student);
            fs.WriteLine(obj);
            
        }
    }
    else if (chose == 2) {
       using (StreamReader fr = new StreamReader("dta.json")) {
           //string sv = JsonConvert.DeserializeObject<string>(fr.ReadLine());
       }
    }
    else if (chose == 3) {
        break;
    }
}

