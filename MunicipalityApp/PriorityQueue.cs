using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class PriorityQueue<T>
    {
        private List<(T Item, DateTime Priority)> elements = new List<(T, DateTime)>();

        // Enqueue an item with a priority
        public void Enqueue(T item, DateTime priority)
        {
            elements.Add((item, priority));
        }

        // Dequeue the item with the highest priority (earliest DateTime)
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

        // Check if the queue is empty
        public bool IsEmpty()
        {
            return elements.Count == 0;
        }
    }
}