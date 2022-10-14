using System;
using System.IO;

namespace FilesAndFolder;
class program 
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\VenkateshVaithilinga\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath=path+"/Venkat";
        string filePath=folderPath+"/newFile.txt";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found creating folder");
            
            Directory.CreateDirectory(folderPath);
        }
        else{
            System.Console.WriteLine("Directory already exists.");
        }
        if (!File.Exists(filePath))
        {
            System.Console.WriteLine("File not found creating file");
            File.Create(filePath);
            System.Console.WriteLine("File Created");
        }
        else{
            System.Console.WriteLine("File already exists");
        }
        System.Console.WriteLine("Select option \n1.Create folder \n2.Create File \n3.Delete Folder \n4.Delete File");
        int option=int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            {
                System.Console.WriteLine("Enter folder name to create:");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                    System.Console.WriteLine("Folder Created");
                }
                else{
                    System.Console.WriteLine("Folder already Exists.");
                }

                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name to create:");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter File Extension to create");
                string name2=Console.ReadLine();
                string newFile =path+"\\"+name1+"."+name2;
                if (!File.Exists(newFile))
                {
                    File.Create(newFile);
                    System.Console.WriteLine("File Created");
                }
                else{
                    System.Console.WriteLine("File name already exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete:");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                foreach(string name in Directory.GetDirectories(path))
                { 
                    try{
                        

                    
                        Directory.Delete(newPath);
                        System.Console.WriteLine("Folder deleted successfully");
                    

                    }
                    catch(Exception e){
                        System.Console.WriteLine(e.Message);
                    }
                    
                }
                
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);

                }
                System.Console.WriteLine("Select file you want to delete:");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter extension you want to delete");
                string name2=Console.ReadLine();
                
                string newPath=path+"\\"+name1+"."+name2;
                try{

                    foreach(string name in Directory.GetFiles(path))
                    {
                        if (name==newPath)
                        {

                            File.Delete(newPath);
                            System.Console.WriteLine("File deleted");
                        }
                    }
                }
                catch(Exception e)
                {
                        System.Console.WriteLine(e.Message);
                }
                break;
            }
        }

    }
}