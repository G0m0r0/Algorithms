namespace Tree
{
    using System;
    using Tree.Contracts;

    public class BinaryTree : IBinaryTree<int>
    {
        public Node<int> root { get; private set; }

        public BinaryTree()
        {
            this.root = null;
        }

        public void AddChild(int value)
        {
            Node<int> before = null;
            Node<int> after = this.root;

            while (after!=null)
            {
                before = after;
                if (value<=after.value)
                {
                    after = after.left;
                }else if(value>after.value)
                {
                    after = after.right;
                }
            }

            Node<int> newNode = new Node<int>(value);
            if (this.root == null)
            {
                this.root = newNode;
            }else
            {
                if (value <= before.value)
                    before.left = newNode;
                else
                    before.right = newNode;
            }
        }

        public Node<int> Find(int value)
        {
            return this.Find(value, this.root);
        }

        private Node<int> Find(int value, Node<int> parent)
        {
            if (parent != null)
            {
                if (value == parent.value) return parent;
                if (value < parent.value)
                    return Find(value, parent.left);
                else
                    return Find(value, parent.right);
            }

            return null;
        }

        public int MaxValue()
        {
            throw new NotImplementedException();
        }

        public int MinValue()
        {
            throw new NotImplementedException();
        }

        public void remove(int value)
        {
            throw new NotImplementedException();
        }

        public void TraverseInOrder(Node<int> parent)
        {
            throw new NotImplementedException();
        }

        public void TraversePostOrder(Node<int> parent)
        {
            throw new NotImplementedException();
        }

        public void TraversePreOrder(Node<int> parent)
        {
            throw new NotImplementedException();
        }
    }
}
