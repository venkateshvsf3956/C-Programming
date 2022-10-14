namespace DictionaryDs
{
    public partial class KeyValue<TKey,TValue>
    {
        public bool ContainsKey(TKey key)
        {
            bool temp=LinearSearch(key,out int position);
            return temp;

        }
        public bool ContainsValue(TValue value)
        {
            bool temp=false;
            for (int i =0;i<_count;i++)
            {
                if (value.Equals(Array[i].Value))
                {
                    temp=true;
                    break;
                }
            }
            return temp;


        }
        public KeyValue<TKey,TValue> ElementAt(int index)
        {
            KeyValue<TKey,TValue> result=null;
            if(index>=0  && index<_count)
            {
                result=Array[index];
            }
            else{
                System.Console.WriteLine("Out of index");
            }
            return result;
        }
        public bool Remove(TKey key)
        {
            KeyValue<TKey,TValue> [] array4=new KeyValue<TKey,TValue>[_capcity];
            bool temp=false;
            int j=0;
            for (int i=0; i<_count;i++)
            {
                if (key.Equals(Array[i].Key))
                {
                    i++;
                    temp=true;
                }
                array4[j]=Array[i];
                j++;

            }
            Array=array4;
            _count--;
            return temp;



        }
        }
        
    }
