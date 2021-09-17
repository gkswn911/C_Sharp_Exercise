// Binary Tree 
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> bTree = new BinaryTree<int>();
            bTree.Root = new BinaryTreeNode<int>(1);
            bTree.Root.Left = new BinaryTreeNode<int>(2);
            bTree.Root.Right = new BinaryTreeNode<int>(3);
            bTree.Root.Left.Left = new BinaryTreeNode<int>(4);

            bTree.PreOrderTraversal(bTree.Root);

        }
    }

    // Binary Node Class
    public class BinaryTreeNode<T>
    {
        public T Data {get ; set ;}
        public BinaryTreeNode<T> Left {get; set;}
        public BinaryTreeNode<T> Right {get; set;}

        public BinaryTreeNode(T data)
        {
            this.Data = Data;
        }
    }

    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root{get; set;}

        // 트리 데이터 출력
        public void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node == null ) return;
            System.Console.WriteLine(node.Data);
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
    }
}