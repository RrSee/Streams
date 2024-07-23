using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //1
        //using FileStream fs = new("test.txt",FileMode.OpenOrCreate,FileAccess.Write);
        //using StreamWriter sw = new StreamWriter(fs);
        //sw.WriteLine("Hello World");


        //2
        //Console.WriteLine(Directory.GetCurrentDirectory());


        //3
        //if (File.Exists("test.txt"))
        //{
        //    File.Delete("test.txt");
        //}
        //else
        //{
        //    Console.WriteLine("Dosya Bulunamadi!");
        //}


        //4
        //Directory.CreateDirectory("C:\\Users\\nicec\\OneDrive\\Рабочий стол\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net8.0\\Folder");


        //5
        //Directory.Delete("C:\\Users\\nicec\\OneDrive\\Рабочий стол\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net8.0\\Folder");


        //6
        //Directory.Delete("C:\\Users\\nicec\\OneDrive\\Рабочий стол\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\net8.0\\Folder");
        //Directory.CreateDirectory("C:\\Users\\nicec\\OneDrive\\Рабочий стол\\ConsoleApp1\\ConsoleApp1\\bin\\Debug\\Folder");


        //7

        //DirectoryInfo directoryInfo = new("C:\\Users\\nicec\\OneDrive\\Рабочий стол\\ConsoleApp1\\ConsoleApp1\\bin\\Debug");

        //foreach (DirectoryInfo dir in directoryInfo.GetDirectories())
        //{

        //    if (dir.Name == "Folder")
        //    {
        //        Console.WriteLine("Dosya Bulundu!");
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Dosya Bulunamadi!");
        //    }
        //}


        //7.1
        DirectoryInfo directoryInfo = new("C:\\Users\\nicec\\OneDrive\\Рабочий стол\\ConsoleApp1\\ConsoleApp1\\bin\\Debug");

        //foreach (FileInfo file in directoryInfo.GetFiles())
        //{

        //    if (file.Name == "text.txt")
        //    {
        //        Console.WriteLine("Dosya Bulundu!");
        //        break;  
        //    }
        //    else
        //    {
        //        Console.WriteLine("Dosya Bulunamadi!");
        //    }
        //}


        //8
        //foreach (FileInfo file in directoryInfo.GetFiles())
        //{
        //    Console.WriteLine(file.Name);
        //}


        //8.1
        //foreach (DirectoryInfo dir in directoryInfo.GetDirectories()) 
        //{ 
        //    Console.WriteLine(dir.Name);
        //}

    }
}
