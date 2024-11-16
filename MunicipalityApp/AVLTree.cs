using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class AVLTree
    {
        // Node class represents each node in the AVL Tree, holding data, left and right child references, and the height of the node.
        public class Node
        {
            public IssueDetails Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Height { get; set; }
            //--------------------------------------------------------------------------------------------------------//

            /// <summary>
            /// Node constructor initializes a node with data and sets left and right children to null, and height to 1.
            /// </summary>
            public Node(IssueDetails data)
            {
                Data = data;
                Left = Right = null;
                Height = 1;
            }
        }

        private Node root;
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Right rotation of a node in the AVL tree. This operation is used to balance the tree when it becomes unbalanced.
        /// </summary>
        private Node RightRotate(Node y)
        {
            Node x = y.Left;
            Node T2 = x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x;
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Left rotation of a node in the AVL tree. This operation is used to balance the tree when it becomes unbalanced.
        /// </summary>
        private Node LeftRotate(Node x)
        {
            Node y = x.Right; // Set y to be the right child of x.
            Node T2 = y.Left; // Set T2 to be the left child of y (this will become the new right child of x).

            // Perform the rotation: y becomes the new root of the subtree, and x becomes its left child.
            y.Left = x;
            x.Right = T2;

            // Update the heights of x and y to reflect the changes in the tree structure.
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            return y; // Return the new root of the subtree.
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Returns the height of a node. If the node is null, it returns 0.
        /// </summary>
        private int GetHeight(Node node)
        {
            return node == null ? 0 : node.Height;
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Calculates the balance factor of a node, which is the difference between the height of the left and right subtrees.
        /// </summary>
        private int GetBalance(Node node)
        {
            return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Public method to insert an IssueDetails object into the AVL Tree.
        /// </summary>
        public void Insert(IssueDetails issue)
        {
            root = Insert(root, issue); // Insert the issue and update the root.
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Private recursive method to insert a new IssueDetails object into the AVL tree.
        /// </summary>
        private Node Insert(Node node, IssueDetails issue)
        {
            // Step 1: Perform normal BST insert
            if (node == null)
                return new Node(issue);

            if (string.Compare(issue.RequestId, node.Data.RequestId) < 0)
                node.Left = Insert(node.Left, issue);
            else if (string.Compare(issue.RequestId, node.Data.RequestId) > 0)
                node.Right = Insert(node.Right, issue);
            else // Duplicate keys are not allowed
                return node;

            // Step 2: Update height of this ancestor node
            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;

            // Step 3: Get the balance factor to check whether this node became unbalanced
            int balance = GetBalance(node);

            // If this node becomes unbalanced, then there are 4 cases

            // Left Left Case
            if (balance > 1 && string.Compare(issue.RequestId, node.Left.Data.RequestId) < 0)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && string.Compare(issue.RequestId, node.Right.Data.RequestId) > 0)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && string.Compare(issue.RequestId, node.Left.Data.RequestId) > 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && string.Compare(issue.RequestId, node.Right.Data.RequestId) < 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            // return the (unchanged) node pointer
            return node;
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Public method for performing in-order traversal of the AVL tree.
        /// </summary>
        public void InOrderTraversal(Action<IssueDetails> action)
        {
            InOrderTraversal(root, action); // Call the recursive helper method for in-order traversal.
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Private recursive method for in-order traversal of the AVL tree.
        /// </summary>
        private void InOrderTraversal(Node node, Action<IssueDetails> action)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, action); // Traverse the left subtree.
                action(node.Data); // Perform the action on the current node's data.
                InOrderTraversal(node.Right, action); // Traverse the right subtree.
            }
        }
    }
}        
//---------------------------------------- END OF FILE -------------------------------------------------------//
