using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        int value1 =Convert.ToInt32(15);
        int value2=Convert.ToInt32(20);
        bool  a=value1>value2;
        bool  b=value1<value2;
        bool  c=value1>=value2;
        bool  d=value1<=value2;
        bool  e=value1!=value2;
        bool  f=value1==value2;
        bool g=value1>=10 && value2>=10;
        bool h=value1>=10 || value2>=30;
        bool i=!(value1>20);
        bool j=!(value1>20);
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        Console.WriteLine($"{c}");
        Console.WriteLine($"{d}");
        Console.WriteLine($"{e}");
        Console.WriteLine($"{f}");
        Console.WriteLine($"{g}");
        Console.WriteLine($"{h}");
        Console.WriteLine($"{i}");
        Console.WriteLine($"{j}");
        string k= (value1==15) ?"True":"False";
        int l=value1++;
        int m=value1--;
        Console.WriteLine($"{k}");
        Console.WriteLine($"{l}");
        Console.WriteLine($"{m}");

    }
}