using System.IO;
DirectoryInfo path = new DirectoryInfo("./");
DirectoryInfo[] dis = path.GetDirectories();
FileInfo[] file = path.GetFiles();

foreach (DirectoryInfo i in dis) {
    Console.WriteLine("duong dan: " +i.FullName);
}
Console.WriteLine("");
foreach (var item in file) 
{
    Console.WriteLine("File: " + item.FullName);
}