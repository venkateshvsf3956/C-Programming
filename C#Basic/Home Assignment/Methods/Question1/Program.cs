using System;
namespace Question1;
class Program {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number");
        int value1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number");
        int value2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("The addition of two number:"+Addition(value1,value2));
        System.Console.WriteLine("The addition of two number:"+Substraction(value1,value2));
        System.Console.WriteLine("The addition of two number:"+ Multiplication(value1,value2));
        System.Console.WriteLine("The addition of two number:"+Division(value1,value2));
        


        int Addition(int value1,int value2)
        {
            int sum;
            sum=value1+value2;
            return sum;
        }
        int Substraction(int value1,int value2)
        {
            int sub;
            sub=value1-value2;
            return sub;
        }
        int Multiplication(int value1,int value2)
        {
            int product;
            product=value1*value2;
            return product;
        }
        int Division(int value1,int value2)
        {
            int quiotent;
            quiotent=value1/value2;
            return quiotent;
        }
    }
}
