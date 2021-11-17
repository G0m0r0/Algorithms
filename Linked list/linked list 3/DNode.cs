namespace linked_list_3
{
    public class DNode<T>
    {
        public T data;
        public DNode<T> Next;
        public DNode<T> Previous;

        public DNode(T data)
        {
            this.data = data;
            this.Next = null;
            this.Previous = null;
        }
    }
}
