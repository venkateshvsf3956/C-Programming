namespace StackDs
{
    public partial class Stack<Type>
    {
        private Type[] Array{get;set;}
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}

        public Stack()
        {
            _count=0;
            _capacity=4;
            Array =new Type[_capacity];
        }
        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }
        public void Push(Type data)
        {
            if(_count==_capacity)
            {
                GrowSize();

            }
            Array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] array1=new Type[_capacity];
           for(int i=0;i<Array.Length;i++)
           {

             array1[i]=Array[i];
           }
           Array=array1;

        }
        public Type Pop()
        {
            Type value=default(Type);
            if (_count<0)
            {
                System.Console.WriteLine("Empty Stack");
            }
            else if(_count>=0)
            {
                value=Array[_count];
                _count--;
            }
            return value;

        }
        public bool Contains(Type data)
        {
            bool value=false;
            
            for (int i=0;i<Array.Length;i++)
            {
                
                if (data.Equals(Array[i]))
                {
                    value= true;
                }
                
                
            }
            return value;
        }
        public Type Peak()
        {
            return Array[_count];
        }
        public 
    }
}