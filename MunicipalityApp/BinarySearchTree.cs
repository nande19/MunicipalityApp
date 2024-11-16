using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data;
            public Node Left;
            public Node Right;

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node root;

        public void Insert(T value)
        {
            root = Insert(root, value);
        }

        private Node Insert(Node node, T value)
        {
            if (node == null) return new Node(value);

            int comparison = value.CompareTo(node.Data);
            if (comparison < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (comparison > 0)
            {
                node.Right = Insert(node.Right, value);
            }

            return node;
        }

        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversal(root, action);
        }

        private void InOrderTraversal(Node node, Action<T> action)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, action);
            action(node.Data);
            InOrderTraversal(node.Right, action);
        }
    }
}