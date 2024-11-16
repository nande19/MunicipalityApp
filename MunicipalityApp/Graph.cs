using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    // Graph class to represent a graph where nodes are IssueDetails, and edges are relationships between issues

    public class Graph
    {

        private Dictionary<string, List<IssueDetails>> adjacencyList;

//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Constructor to initialize the adjacency list as an empty dictionary.
        /// </summary>
        public Graph()
        {
            adjacencyList = new Dictionary<string, List<IssueDetails>>();
        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// AddNode method adds a new node (issue) to the graph, represented by its RequestId.
        /// </summary>
        public void AddNode(IssueDetails issue)
        {
            // If the requestId is not already in the adjacency list, add a new entry with an empty list of connected nodes.
            if (!adjacencyList.ContainsKey(issue.RequestId))
                adjacencyList[issue.RequestId] = new List<IssueDetails>();
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// AddEdge method creates an edge between two nodes (issues) by linking their request IDs.
        /// </summary>
        public void AddEdge(string requestId1, string requestId2)
        {
            // Check if both request IDs exist in the adjacency list.
            if (adjacencyList.ContainsKey(requestId1) && adjacencyList.ContainsKey(requestId2))
            {
                // Create a new IssueDetails object representing a relationship and add it to both requestId1 and requestId2 lists.
                adjacencyList[requestId1].Add(new IssueDetails("Related Location", "Related Category", "Related Description", new List<string>(), 0));
                adjacencyList[requestId2].Add(new IssueDetails("Related Location", "Related Category", "Related Description", new List<string>(), 0));
            }
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// TraverseBFS method performs a Breadth-First Search starting from a node with the given startId.
        /// </summary>
        public void TraverseBFS(string startId)
        {
            // HashSet to track visited nodes and avoid re-processing them.
            var visited = new HashSet<string>();

            // Queue to handle nodes to be processed during the BFS traversal.
            var queue = new Queue<IssueDetails>();

            // Mark the start node as visited and enqueue it for processing.
            visited.Add(startId);
            queue.Enqueue(new IssueDetails("Location", "Category", "Description", new List<string>(), 0)); // Starting point for traversal

            // Process the queue until all reachable nodes are visited.
            while (queue.Count > 0)
            {
                // Dequeue the front node to process it.
                var node = queue.Dequeue();

                // Display the RequestId of the current node (this could be any action you want to perform on the node).
                Console.WriteLine(node.RequestId);

                // Iterate through all the adjacent nodes (neighbors) of the current node.
                foreach (var neighbor in adjacencyList[startId])
                {
                    // If the neighbor hasn't been visited, mark it as visited and enqueue it for further processing.
                    if (!visited.Contains(neighbor.RequestId))
                    {
                        visited.Add(neighbor.RequestId);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}      
//---------------------------------------- END OF FILE -------------------------------------------------------//
