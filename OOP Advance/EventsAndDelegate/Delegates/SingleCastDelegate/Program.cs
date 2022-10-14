using System;
namespace SingelCastDelegate{
    public delegate int Calculator(int n);
    class Program 
    {
        private static int value=10;
        public static int AddNum(int number)
        {
            value+=number;
            return value;
            
        }
        public static int MultNum(int number)
        {
            value*=number;
            return value;
        }
        public static int GetNum()
        {
            return value;
        }

        public static void Main(string[] args)
        {
            //Create delegate instance
            Calculator nc1=new Calculator(AddNum);
            Calculator nc2=new Calculator(MultNum);

            //Calling the method using the delegate objects
            nc1(2);
            System.Console.WriteLine("Value of num:"+GetNum());

            nc2(4);
            System.Console.WriteLine("Value of num:"+GetNum());
            




            
        }
    }
}