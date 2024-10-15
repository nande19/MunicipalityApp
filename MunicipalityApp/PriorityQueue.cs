using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class PriorityQueue<T>
    {
        // List to store elements with their priority
        private List<(T Item, DateTime Priority)> elements = new List<(T, DateTime)>();
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        // Enqueue an item with a priority
        public void Enqueue(T item, DateTime priority)
        {
            elements.Add((item, priority));
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Adds an item to the priority queue with the specified priority (DateTime).
        /// </summary>
        public T Dequeue()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("The queue is empty.");

            // Find the item with the highest priority (earliest DateTime)
            var highestPriorityIndex = 0;
            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i].Priority < elements[highestPriorityIndex].Priority)
                {
                    highestPriorityIndex = i;
                }
            }

            // Get the item with the highest priority and remove it from the list
            var item = elements[highestPriorityIndex].Item;
            elements.RemoveAt(highestPriorityIndex);
            return item;
        }

//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Check if the queue is empty
        /// </summary>
        public bool IsEmpty()
        {
            return elements.Count == 0;
        }
    }
}      
//---------------------------------------- END OF FILE -------------------------------------------------------//
