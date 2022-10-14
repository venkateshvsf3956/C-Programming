using System;
namespace EnumTypes;
public enum Gender{Default,Male,Female,Transgender}
class Program 
{
    static void Main (string[]args)
    {
        //Select by string or integer
        System.Console.WriteLine("Select the option Male,female,Transgender");
        Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine(gender1);

        System.Console.WriteLine("Select the option Male,female,Transgender");
        Gender gender2=Gender.Default;
        
        bool temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
        
        while(!temp||!((int)gender2<4 && (int)gender2>0))
        {
           
            System.Console.WriteLine("Invalid Gender \n Enter again.");
            temp=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
             System.Console.WriteLine((int)gender2);
        }
        System.Console.WriteLine(gender2);

        

    }


}