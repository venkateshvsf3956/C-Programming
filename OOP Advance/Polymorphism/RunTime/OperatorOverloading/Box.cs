using System;
namespace OperatorOverLoading
{
    public class Box
    {
        private double length;
        private double breath;
        private double height;
        public Box(double length1,double breath1,double height1)
        
        {
            length=length1;
            breath=breath1;
            height=height1;

        }
        public Box()
        {
            length=0;
            breath=0;
            height=0;

        }
            public static Box operator +(Box box1,Box box2)
    {
        Box box=new Box();
        box.length=box1.length+box2.length;
        box.breath=box1.breath+box2.breath;
        box.height=box1.height+box2.height;
        return box;
    }
        public double CalculateArea()
        {
            return length*breath*height;
        }

    }
}