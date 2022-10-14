namespace ListsDs
{
    public partial class ArrayList
    {
        public void Remove(Object data)
        {
            Object [] array4=new Object[_capacity*2];
            int j=0;
            for (int i=0; i<_count;i++)
            {
                if (data.Equals(Array[i]))
                {
                    i++;
                }
                array4[j]=Array[i];
                j++;

            }
            Array=array4;
            _count--;


        }
        
    }
}