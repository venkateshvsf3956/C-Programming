using System;
using System.IO;
namespace System;
class Program 
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder created");
        }
        else{
            System.Console.WriteLine("Folder exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt");
            System.Console.WriteLine("File created");
        }
        else{
            System.Console.WriteLine("File Exists");
        }
        System.Console.WriteLine("Select option \n1.Read file info \n2.Write file info");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                string line;
                StreamReader sr=null;
                try{
                    //Pass the file path and file name to the stream Reader constructor
                    sr=new StreamReader("TestFolder/Test.txt");
                    //Read the first line of the text
                    line=sr.ReadLine();
                    while(line!=null)
                    {
                        //write the line to the console window
                        System.Console.WriteLine(line);
                        //Read the next line
                        line =sr.ReadLine();

                    }
                }catch(Exception e){
                    System.Console.WriteLine("Exception:"+e.Message);

                }
                finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Executing finally block.");
                        sr.Close();
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try{
                    string[] old=File.ReadAllLines("TestFolder/Test.txt");

                    //Pass the file path and filename to the name streamwriter constructor to operator
                    sw=new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter new comment:");
                    string info=Console.ReadLine();
                    string old1="";
                    foreach(string text in old)
                    {
                        old1=old1+"\n"+text;//Append old text
                    }
                    old1=old1+"\n"+info;//append our input text
                    sw.WriteLine(old1); //Write to file
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception:"+e.Message);
                }
                finally{
                    if(sw!=null)
                    {
                        System.Console.WriteLine("Executing finally blocked ");
                        sw.Close();//close the file

                    }
                    
                }
                break;
            }
        }
    }
}