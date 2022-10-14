using System;
namespace StudentApplication
{
    public partial class Lists<Type>
    {
        private Type [] Array{get;set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        public Type this [int i]{get{return Array[i];}set{Array[i]=value;}}//Indexer

        //Constructor
        public Lists()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }
        public Lists(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }
        public void Add(Type data)
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
           Type[] array1=new Type[_capacity];
           for(int i=0;i<Array.Length;i++)
           {
            array1[i]=Array[i];
           }
           Array=array1;
        }
        
    }
}