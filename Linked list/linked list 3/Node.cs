namespace linked_list_3
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data)
        {
            this.next = null;
            this.data = data;
        }
    }
}
