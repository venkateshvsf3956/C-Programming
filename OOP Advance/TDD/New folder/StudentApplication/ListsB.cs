using System;
namespace StudentApplication
{
    public partial class Lists<Type>
    {
        public void Remove(Type data)
        {
            Type [] array4=new Type[_capacity*2];
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