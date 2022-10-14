namespace AbstractClasses
{
    public class Syncfusion:AbstractBase
    {
        public override string Name {get{return name;} set{name=value;}}//Abstract property defintion
        public override void Salary (int dates)
        {
            Display();
            Amount=(double)dates*500;
            System.Console.WriteLine("Salary amount:"+Amount);
        }
        
    }
}