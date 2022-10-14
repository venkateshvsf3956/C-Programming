namespace QueueDs
{
    public partial class Queue<Type>
    {
        
        private int _count;
        private int _head;
        private int _capacity;
        private int _tail;
        public int Count{get{return _count;}}
        private Type[] Array{get;set;}
        public Queue()
        {
            _count=0;
            _capacity=4;
            _head=0;
            _tail=0;
           Array=new Type[_capacity];
            
        }
        public Queue(int size)
        {
            _count=0;
            _capacity=size;
            _head=0;
            _tail=0;
           Array=new Type[_capacity];

        }
        public void EnQueue(Type data)
        {
            if (_tail==_capacity)
            {
                GrowSize();

            }
            Array[_tail]=data;
            _tail++;
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
        public Type Dequeue()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Queue Empty");
            }
            else {
                value =Array[_head];
                _head++;
                _count--;
            }
            return value;
        }
        public Type Peek()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Queue Empty");
            }
            else {
                value =Array[_head];
            }
            return value;

        }
        public bool Contain(Type data)
        {
            bool value=false;
            for(int i=0;i<_tail;i++)
            {
                if(data.Equals(Array[i]))
                {
                    value=true;
                }
                
            }
            return value;
        }

        
    }
}