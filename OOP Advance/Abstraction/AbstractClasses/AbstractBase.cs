using System;
namespace AbstractClasses
{
    public abstract class AbstractBase
    {
        //noraml field
        protected string name;//do not use field abstarct class
        public abstract string Name {get; set;}//Abstract property
        public double Amount { get; set; }//Normal property
        public void Display(){System.Console.WriteLine("Normal method: "+name);}//Normal method
        public abstract void Salary(int dates);//Abstract method

        
    }
}