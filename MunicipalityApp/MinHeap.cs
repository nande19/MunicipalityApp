using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    // MinHeap class represents a minimum heap, a binary tree where the parent node has a lower priority than its children.

    public class MinHeap
    {
        // A list that holds the elements in the heap.

        private List<IssueDetails> heap;

        // Constructor initializes the heap as an empty list.

        public MinHeap()
        {
            heap = new List<IssueDetails>();
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Adds a new IssueDetails object to the heap.
        /// </summary>
        public void Add(IssueDetails issue)
        {
            // Add the new issue at the end of the heap
            heap.Add(issue);
            // Restore the heap property by moving the newly added element up if necessary
            HeapifyUp(heap.Count - 1);
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Moves the element at the given index up the heap to restore the heap property.
        /// </summary>

        private void HeapifyUp(int index)
        {
            // Calculate the index of the parent node
            int parentIndex = (index - 1) / 2;

            // If the parent node's priority is greater than the current node's priority, swap them
            if (parentIndex >= 0 && heap[parentIndex].Priority > heap[index].Priority)
            {
                // Swap the parent and the current node
                var temp = heap[parentIndex];
                heap[parentIndex] = heap[index];
                heap[index] = temp;

                // Recursively call HeapifyUp to continue checking if the parent needs to be swapped
                HeapifyUp(parentIndex);
            }
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Removes and returns the element with the minimum priority (root of the heap).
        /// </summary>
        public IssueDetails ExtractMin()
        {
            // If the heap is empty, return null
            if (heap.Count == 0)
                return null;

            // Store the root (min element)
            var min = heap[0];

            // Swap the root with the last element in the heap
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1); // Remove the last element

            // Restore the heap property by moving the new root down
            HeapifyDown(0);

            // Return the removed minimum element
            return min;
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Moves the element at the given index down the heap to restore the heap property.
        /// </summary>
        private void HeapifyDown(int index)
        {
            // Calculate the indices of the left and right children
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int smallest = index;

            // If the left child exists and has a smaller priority, make it the smallest
            if (leftChild < heap.Count && heap[leftChild].Priority < heap[smallest].Priority)
                smallest = leftChild;

            // If the right child exists and has a smaller priority, make it the smallest
            if (rightChild < heap.Count && heap[rightChild].Priority < heap[smallest].Priority)
                smallest = rightChild;

            // If the smallest element is not the current node, swap and continue heapifying down
            if (smallest != index)
            {
                // Swap the current node with the smallest child
                var temp = heap[smallest];
                heap[smallest] = heap[index];
                heap[index] = temp;

                // Recursively call HeapifyDown to restore the heap property
                HeapifyDown(smallest);
            }
        }

        // Property that returns the number of elements in the heap
        public int Count => heap.Count;
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
