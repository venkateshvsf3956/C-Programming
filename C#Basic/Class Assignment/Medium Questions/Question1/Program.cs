using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the employee salary:");
        int salary=Convert.ToInt32(Console.ReadLine());
        
        if (salary<=10000)
        {
            int input=salary+salary;
            
            int total=(input*12);
            int tax=(total/100)*7;
            int annum=total-tax;
            System.Console.WriteLine("annum salary:"+annum);
        }
        else if((salary>10000)&&(salary<=20000))
        {
            int hra=(salary/100)*25;
            int da=(salary/100)*90;
            int total=(hra+da+salary)*12;
            int tax=(total/100)*7;
            int annum=total-tax;
            System.Console.WriteLine("annum salary:"+annum);

        }
        else if ((salary>20000))
        {
            int hra=(salary/100)*30;
            int da=(salary/100)*95;
            int total=(hra+da+salary)*12;
            int tax=(total/100)*7;
            int annum=total-tax;
            System.Console.WriteLine("annum salary:"+annum);

        }
    }
}