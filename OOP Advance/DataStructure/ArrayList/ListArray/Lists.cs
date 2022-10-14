using System;
namespace ListsDs
{
    public partial class ArrayList
    {
        private Object [] Array{get;set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        public Object this [int i]{get{return Array[i];}set{Array[i]=value;}}//Indexer

        //Constructor
        public ArrayList()
        {
            _count=0;
            _capacity=4;
            Array=new Object[_capacity];
        }
        public ArrayList(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Object[_capacity];
        }
        public void AddData(Object data)
        {
            if (_count==_capacity)
            {
                GrowSize();

            }

            Array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity = _capacity*2;
           Object[] array1=new Object[_capacity];
           for(int i=0;i<Array.Length;i++)
           {
            array1[i]=Array[i];
           }
           Array=array1;
        }
        
    }
}                                           