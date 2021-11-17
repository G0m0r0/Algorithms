using System;

namespace Tree
{
    class Program
    {
        static void Main()
        {
            var binaryTree = new BinaryTree();
            binaryTree.AddChild(100);
            binaryTree.AddChild(20);
            binaryTree.AddChild(3);
            binaryTree.AddChild(1);
            binaryTree.AddChild(4);
            binaryTree.AddChild(1);
            binaryTree.AddChild(1);
        }
    }
}
