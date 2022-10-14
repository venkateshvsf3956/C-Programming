namespace ListsDs
{
    public partial class Lists<Type>
    {
        public void Insert(int index,Type data)
        {
            
            
            
            Type []array3=new Type[_capacity*2];
           // int count=0;
            for (int i=0;i<_count;i++)
            {
                if (i<index)
                {
                    array3[i]=Array[i];


                }
                else if (i==index)
                {
                    array3[index]=data;
                }

              
                else if (i>=index){
                    array3[i+1]=Array[i];
                }
                

          


            }
            array3[index]=data;

            Array=array3;
            _count++;
            foreach (var i in array3)
            {
                System.Console.Write("\t"+i);
            }

        }
        public void RemoveAt(int index)
        {
            for (int i=0;i<_count;i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
                _count++;
            }
            foreach (var i in Array)
            {
                System.Console.Write("\t"+i);
            }

        }
        
    }
}