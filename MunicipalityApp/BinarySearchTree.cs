using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    // Generic Binary Search Tree class where T is a type that implements IComparable
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data;  // The data stored in the node
            public Node Left;  // Pointer to the left child node
            public Node Right;  // Pointer to the right child node


            // Constructor to initialize a new node with the provided data

            public Node(T data)
            {
                Data = data;
            }
        }

        private Node root;  // Root of the binary search tree

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Public method to insert a value into the binary search tree.
        /// </summary>
        public void Insert(T value)
        {
            root = Insert(root, value);  // Call the private recursive insert method
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Private recursive method to insert a value into the tree.
        /// </summary>
        private Node Insert(Node node, T value)
        {
            // If the node is null, create a new node with the value
            if (node == null) return new Node(value);

            // Compare the value to be inserted with the current node's data
            int comparison = value.CompareTo(node.Data);

            // If the value is less than the current node's data, insert it into the left subtree
            if (comparison < 0)
            {
                node.Left = Insert(node.Left, value);
            }
            // If the value is greater than the current node's data, insert it into the right subtree
            else if (comparison > 0)
            {
                node.Right = Insert(node.Right, value);
            }

            // Return the unchanged node pointer
            return node;
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Public method to perform an in-order traversal of the tree and apply the specified action to each element.
        /// </summary>
        public void InOrderTraversal(Action<T> action)
        {
            InOrderTraversal(root, action);  // Call the private recursive in-order traversal method
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Private recursive method to perform an in-order traversal of the tree.
        /// </summary>
        private void InOrderTraversal(Node node, Action<T> action)
        {
            // Base case: if the node is null, return (no action)
            if (node == null) return;

            // Recursively traverse the left subtree
            InOrderTraversal(node.Left, action);

            // Apply the action to the current node's data
            action(node.Data);

            // Recursively traverse the right subtree
            InOrderTraversal(node.Right, action);
        }
         //--------------------------------------------------------------------------------------------------------//

            /// <summary>
            /// Public method to find a node by its RequestId.
            /// </summary>
        public T Find(string requestId)
        {
            return Find(root, requestId);
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Private recursive method to find a node by its RequestId.
        /// </summary>
        private T Find(Node node, string requestId)
        {
            // If the node is null, the issue isn't found
            if (node == null)
            {
                return default(T);  // Return default value if not found
            }

            // Assuming the data in the node is of type IssueDetails or a similar class with RequestId
            IssueDetails issue = node.Data as IssueDetails;

            // If the RequestId matches, return the issue
            if (issue != null && string.Compare(requestId, issue.RequestId, StringComparison.OrdinalIgnoreCase) == 0)
            {
                return node.Data;
            }

            // If the RequestId is less, search the left subtree
            if (string.Compare(requestId, issue.RequestId, StringComparison.OrdinalIgnoreCase) < 0)
            {
                return Find(node.Left, requestId);
            }

            // If the RequestId is greater, search the right subtree
            return Find(node.Right, requestId);
        }
    }
}
//---------------------------------------- END OF FILE -------------------------------------------------------//
