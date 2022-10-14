using System;
using System.Collections;


namespace StudentApplication
{
    public partial class Lists<Type>:IEnumerable,IEnumerator
    {
        private int Position;
        public IEnumerator GetEnumerator()
        {
            Position=-1;
            return(IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(Position<_count-1)
            {
                ++Position;
                return true;
            }
            Reset();
            return false;

        }
        public void Reset()
        {
            Position=-1;
        }
        public object Current
        {
            get{return Array[Position];}
        }
    }
}