using System;
namespace MethodsPractice;
class Program 
{
    public static void Main(string[] args)
    {
        //Method with arguments and with return type
        
        //Method with argument without return type
        sub(9,7);
        void sub(int value1,int value2)
        {
            int sub1;
            sub1=value1-value2;
            System.Console.WriteLine("The substraction of 2 number"+sub1);
        }
        int product1=Multiplication();
        System.Console.WriteLine("The product is :"+product1);
        System.Console.WriteLine(Multiplication());

        //method without argument with return type
        int Multiplication()
        {
            int data1=1,data2=2;
            int product;
            product=data1*data2;
            return product;
        }
        //method without argument without return type
        void Division()
        {
            int value1=10,value2=2;
        }
    }
}
