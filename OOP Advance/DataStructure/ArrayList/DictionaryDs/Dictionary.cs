namespace DictionaryDs
{
    public partial class KeyValue<TKey, TValue>
    {

        private int _count;
        private int _capcity;
        public int Count { get{return _count;}}
        public int Capacity{get{return _capcity;}}
        public KeyValue<TKey,TValue>[]Array{get;set;}
        //indexer
        public TValue this [TKey key]
        {
            get{
                TValue output=default(TValue);
                bool temp=LinearSearch(key,out int index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else{
                    System.Console.WriteLine("Invalid key");
                }
                return output;
            }
            set{
                bool temp=LinearSearch(key,out int position);
                if(temp)
                {
                    Array[position].Value=value;
                }
                else{
                    System.Console.WriteLine("Invalid key");
                }

            }
        }


        public KeyValue()
        {
            _capcity=4;
            _count=0;
            Array=new KeyValue<TKey, TValue>[_capcity];
        }
        public KeyValue(int size)
        {
            _capcity=size;
            _count=0;
            Array=new KeyValue<TKey, TValue>[_capcity];
        }
        public void Add(TKey key,TValue value)
        {
            if (_count==_capcity)
            {
                Growsize();

            }
            bool temp=LinearSearch(key,out int index);
            if(temp==true)
            {
                System.Console.WriteLine("Duplicate key");
            }
            else if(temp==false)
            {
            KeyValue<TKey,TValue> obj=new KeyValue<TKey, TValue>();
            obj.Key=key;
            obj.Value=value;
            Array[_count]=obj;
            _count++;
            }

        }
        public void Growsize()
        {
            _capcity=_capcity*2;
            KeyValue<TKey,TValue> [] array1=new KeyValue<TKey, TValue>[_capcity];
            for (int i=0;i<Array.Length;i++)
            {
                array1[i]=Array[i];

            }
            Array=array1;
        }
        public bool LinearSearch(TKey key,out int index)
        {
            bool value=false;
            index=0;
            for(int i=0;i<_count;i++)
            {
                if (key.Equals(Array[i].Key))
                {
                    index=i;
                    value=true;
                    break;
                }
            }
            return value;



        }

        
        
    }
}