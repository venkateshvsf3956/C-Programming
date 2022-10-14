using System.Collections;
namespace Assessment

{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        private int Position;
        public IEnumerator GetEnumerator()
        {
            Position=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(Position<Count-1)
            {
                Position++;
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