namespace Tree.Contracts
{
    interface IBinaryTree<T>
    {
        void AddChild(T data);
        Node<T> Find(T value);
        void remove(T value);
        T MinValue();
        T MaxValue();
        void TraverseInOrder(Node<T> parent);
        void TraversePreOrder(Node<T> parent);
        void TraversePostOrder(Node<T> parent);
    }
}
