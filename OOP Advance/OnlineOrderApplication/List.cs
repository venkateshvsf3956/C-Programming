namespace OnlineApplication
{
    public  partial class List<Type>
    {
        //Field
        private Type[] Array{get;set;}
        private int _count;
        private int _capacity;
        //property
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        //Indexer
    public Type this[int i] {get{return Array[i];}set{Array[i]=value;}}

    // default Constructor
    public List()
    {
        _count=0;
        _capacity=4;
        Array=new Type[_capacity];
    }
    //parameterized constructor
    public List(int size)
    {
        _count=0;
        _capacity=size;
        Array=new Type[_capacity];

    }
    public void Add(Type data)
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
        Type []array1=new Type[_capacity*2];
        for (int i=0;i<Array.Length;i++)
        {
            array1[i]=Array[i];
        }
        Array=array1;
    }
        
        
    }
}