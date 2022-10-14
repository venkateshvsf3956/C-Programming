using System;
namespace Exception1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Number");
        int input1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter another number:");
        int input2=int.Parse(Console.ReadLine());
        try{
            int output=input1/input2;
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine("Exception:"+e.Message);
        }
        catch(FormatException e)
        {
            System.Console.WriteLine("Exception:"+e.StackTrace);
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally{
            System.Console.WriteLine("Finally Completed");
        }


       
    }
}