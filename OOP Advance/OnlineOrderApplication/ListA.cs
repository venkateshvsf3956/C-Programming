using System.Collections;
namespace OnlineApplication
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        private int Postion;
        public IEnumerator GetEnumerator()
        {
            Postion=-1;
            return(IEnumerator)this;
        }
        public bool MoveNext()
        {
            if (Postion<_count-1)
            {
                ++Postion;
                    return true;
            }
            Reset();
            return false;
            
        }
        public void Reset()
        {
            Postion=-1;
        }
        public object Current
        {
            get{return Array[Postion];}
        }

        
    }
}