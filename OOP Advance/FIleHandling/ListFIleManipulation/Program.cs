using System;
using System.Collections.Generic;
using System.IO;
namespace ListFileManipulation;
class Program 
{
    public static void Main(string[] args)
    {
        List<StudentDetails> vlist=new List<StudentDetails>();
        vlist.Add(new StudentDetails(){Name="Venkat",FatherName="Vaithi",Gender=Gender.Male,Dob=new DateTime(2002,12,12)});
        vlist.Add(new StudentDetails(){Name="Venkat1",FatherName="Vaithi1",Gender=Gender.Male,Dob=new DateTime(2003,12,12)});
        vlist.Add(new StudentDetails(){Name="Venkat2",FatherName="Vaithi2",Gender=Gender.Male,Dob=new DateTime(2004,12,12)});
        vlist.Add(new StudentDetails(){Name="Venkat3",FatherName="Vaithi3",Gender=Gender.Male,Dob=new DateTime(2005,12,12)});
        Insert(vlist);
        Display();
        Update();
        
    }
    static void Insert(List<StudentDetails> vlist)
    {
        StreamWriter write=null;
        if(!File.Exists("Data.csv"))
        {
            System.Console.WriteLine("Creating new csv File.");
            File.Create("Data.csv");
        }
        else {
            System.Console.WriteLine("File found");
        }
        write=new StreamWriter(File.OpenWrite("Data.csv"));
        foreach(var v in vlist)
        {
            write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.Dob.ToString("dd/MM/yyyy"));
        }
        write.Close();
        
    }
    static void Display()
    {
        StreamReader reader=null;
       List<StudentDetails> list=new List<StudentDetails>();
       if (File.Exists("Data.csv"))
       {
        reader=new StreamReader(File.OpenRead("Data.csv"));
        while(!reader.EndOfStream)
        {
            var line=reader.ReadLine();
            var values=line.Split(',');
            if (values[0]!="")
            {
                list.Add(new StudentDetails(){Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),Dob=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});

            }

        }
       }
       else{
        System.Console.WriteLine("File doesn't exists");
       }
       reader.Close();
       foreach(var c in list)
       {
        System.Console.WriteLine("\n--------Detail---------\n");
        System.Console.WriteLine($"Name:{c.Name}\nFather Name:{c.FatherName}\nGender:{c.Gender}\nDate of birth:{c.Dob.ToString("dd/MM/yyyy")}");
       }
    }
    static void Update()
    {
        System.Console.WriteLine("Enter option to update \n1.Update your name \n2.update your father name");
        int option=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the name to be update");
        string name =Console.ReadLine();
        string []lines=File.ReadAllLines("Data.csv");
        for (int i=0;i<lines.Length;i++)
        {
            if(lines[i]!="")
            {
                string[]values=lines[i].Split(',');
                for (int j=0;j<values.Length;j++)
                {
                    if (values[j]==name)
                {
                    System.Console.WriteLine("Enter your update name");
                    string updatename=Console.ReadLine();
                    if (option==1)
                    {
                        lines[i]=updatename+','+values[1]+','+values[2]+','+values[3];
                        System.Console.WriteLine("Successfully updated");
                    }
                    else if(option==2)
                    {
                        lines[i]=values[0]+','+updatename+','+values[2]+','+values[3];
                        System.Console.WriteLine("Successfully updated");
                    }
                }

                }
                
                

            }
        }
        File.WriteAllLines("Data.csv",lines);
    }
}