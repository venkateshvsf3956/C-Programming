namespace AbstractClasses
{
    public class Tcs:AbstractBase
    {
        public override string Name {get{return name;} set{name=value;}}//Abstract property defintion
        public override void Salary (int dates)
        {
            Display();
            Amount=(double)dates*300;
            System.Console.WriteLine("Salary amount:"+Amount);
        }
    }
}