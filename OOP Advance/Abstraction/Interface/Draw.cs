using System;
namespace Interface
{
    public class Draw:IRectangle
    {
        public double Area { get; set; }
        public double Length{get;set;}
        
        public double Breath{get;set;}

       public void GetData(int length,int breath)
        {
            Length=length;
            Breath=breath;
        }

        public void CalculateArea()
        {
            Area=Length*Breath;

        }
        public void show()
        {
            System.Console.WriteLine("Area of Rectangle:"+Area);
        }

        
    }
}