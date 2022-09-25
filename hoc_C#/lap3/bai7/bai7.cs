using System;
  
class Program{
      
static int dem_tan_so_tu_is(string str)
{
      
    string[] a = str.Split(' ');
    string word = "is";
      
    int count = 0;
    for(int i = 0; i < a.Length; i++)
    {    
          
        if (word.Equals(a[i]))
            count++;
    }
    return count;
}
  
public static void Main()
{
    Console.Write("Nhap cau:");
    string str = Console.ReadLine() ?? "";
    Console.Write("so lan xuat hien cua tu is trong cau" + dem_tan_so_tu_is(str));
}
}