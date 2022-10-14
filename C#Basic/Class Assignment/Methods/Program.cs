using System;
namespace Methods;
class Program 
{
    public static void Main(string[] args)
    {
        
        string condition;
        
        do
        {
        System.Console.WriteLine("Enter the first number");
        int value1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number");
        int value2=int.Parse(Console.ReadLine());
        System.Console.WriteLine(("Enter the option 1.Addition, 2.Substraction 3.Multiplication 4.Division"));
        int option=int.Parse(Console.ReadLine());

        
        switch(option)
        {
            case 1:
            {
                
                System.Console.WriteLine("The Addition of two values:"+Addition(value1,value2));
                
                break;
            }
            case 2:
            {
                System.Console.WriteLine("The suubstraction of two numbers:"+Substraction(value1,value2));
                
            break;
            
            }

            case 3:
            {
                System.Console.WriteLine("The Multiplication of two number:"+Multiplication(value1,value2));

            break;
            }
            case 4:
            {
                System.Console.WriteLine("The Division of two number:"+Division(value1,value2));
                break;

                
            }
            default:
            {
                System.Console.WriteLine("Choose the correct option");
                break;
            }
        }
        System.Console.WriteLine("Do you want any operation again-Enter yes or no");
        condition=Console.ReadLine().ToLower();
        
        
        }while(condition=="yes");

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