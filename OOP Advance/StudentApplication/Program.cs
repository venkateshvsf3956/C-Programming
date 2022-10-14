using System;

namespace StudentApplication;
class  Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
       //Operation.AddDefaultData();

       Operation.MainMenu();
       Files.WriteToFiles();
       
        
    }
}