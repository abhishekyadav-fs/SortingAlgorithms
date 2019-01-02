using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphBFS
{
    // Graph Node whhich contains the adjacency list of that node
    // Suppose Node A which is connected to node B,D,F -> adjacent will contain B,D,F node
    public class Node
    {
        // Node name
        public string nodeName;
        public List<Node> adjacent = new List<Node>();
        public Node(string name)
        {
            this.nodeName = name;
        }
    }
    public class BFSImplementation
    {
        // Grapho look up dictionary
        // key will be the node name and value will be Node itself
        private Dictionary<string, Node> NodeLookup = new Dictionary<string, Node>();

        /// <summary>
        /// Method to get node using the node name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private Node GetNode(string name)
        {
            return NodeLookup[name];
        }

        /// <summary>
        /// Method to add edge between two nodes ( Directed )
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void AddEdgeDirected(string source, string destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            s.adjacent.Add(d);
        }

        /// <summary>
        /// Method to add undirected edges between two nodes
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void AddEdgeUndirected(string source, string destination)
        {
            Node s = GetNode(source);
            Node d = GetNode(destination);
            s.adjacent.Add(d);
            d.adjacent.Add(s);
        }

        /// <summary>
        /// Method to check if there is a path between two nodes using Deapth First Search
        /// </summary>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns bool></returns>
        public bool HasPatBFS(string start, string destination, out List<string> visitedNodes)
        {
            // Getting the node fron NodeLookUp
            Node s = GetNode(start);
            Node f = GetNode(destination);
            Dictionary<Node, bool> visitedTrack = new Dictionary<Node, bool>();
            return BFS(s, f, visitedTrack, out visitedNodes);
        }

        /// <summary>
        /// Method to do BFS on the graph ( Iterative)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="visited"></param>
        /// <returns></returns>
        public bool BFS(Node source, Node destination, Dictionary<Node, bool> visited, out List<string> visitedList)
        {
            List<string> visitedNode = new List<string>();
            // Already at the destination
            if (source == destination)
            {
                visitedNode.Add(source.nodeName);
                visitedList = visitedNode;
                return true;
            }
            // If the source is already visited then return false.
            //As we have already explored for destination node from this node
            if (visited.ContainsKey(source))
            {
                visitedList = null;
                return false;
            }
            // Creating a queue to keep a track of all nodes to be visited 
            Queue<Node> queue = new Queue<Node>();// Created the stack
            // Enqueueing the source node to stack
            queue.Enqueue(source);
            // Adding the source to queue
            visited.Add(source, true);
            while (queue.Count != 0)
            {
                Node front = queue.Peek();
                visitedNode.Add(front.nodeName);
                visitedList = visitedNode;
                queue.Dequeue();

                // Checking the matching condition
                if (front.Equals(destination))
                {
                    return true;
                }
                // Marking all adjacent node as visited and pushing all its adjacent node to queue
                foreach (var item in front.adjacent)
                {
                    if (!visited.ContainsKey(item))
                    {
                        queue.Enqueue(item);
                        visited.Add(item, true);
                    }
                }

            }
            visitedList = null;
            return false;
        }

        

        static void Main(string[] args)
        {
            BFSImplementation obj = new BFSImplementation();
            // Creating the graph
            Node node = new Node("2");
            obj.NodeLookup.Add(node.nodeName, node);
            node = new Node("0");
            obj.NodeLookup.Add(node.nodeName, node);
            node = new Node("1");
            obj.NodeLookup.Add(node.nodeName, node);
            node = new Node("3");
            obj.NodeLookup.Add(node.nodeName, node);
            //node = new Node("Chennai");
            //obj.NodeLookup.Add(node.nodeName, node);
            //node = new Node("Hyderabad");
            //obj.NodeLookup.Add(node.nodeName, node);
            //node = new Node("Pune");
            //obj.NodeLookup.Add(node.nodeName, node);
            //node = new Node("Kochi");
            //obj.NodeLookup.Add(node.nodeName, node);

            // Adding undirected edges to the graph nodes
            obj.AddEdgeDirected("2", "0");
            obj.AddEdgeDirected("0", "2");
            obj.AddEdgeDirected("0", "1");
            obj.AddEdgeDirected("1", "2");
            obj.AddEdgeDirected("2", "3");
            obj.AddEdgeDirected("3", "3");
            //obj.AddEdgeUndirected("Delhi", "Mumbai");
            //obj.AddEdgeUndirected("Kolkata", "Chennai");
            //obj.AddEdgeUndirected("Mumbai", "Kolkata");
            //obj.AddEdgeUndirected("Chennai", "Bangalore");
            //obj.AddEdgeUndirected("Bangalore", "Hyderabad");
            //obj.AddEdgeUndirected("Mumbai", "Hyderabad");
            //obj.AddEdgeUndirected("Pune", "Kochi");
            //obj.AddEdgeUndirected("Kolkata", "Kolkata");

            // Check if there is path from Delhi to Bangalore
            List<string> visitedNodes;
            bool res = obj.HasPatBFS("2", "1", out visitedNodes);

            Console.WriteLine("Path exists between Delhi and Bangalore : " + res);
            if (res)
            {
                foreach (var item in visitedNodes)
                {
                    Console.Write(item + "=>");
                }
            }
            Console.WriteLine();
            //res = obj.HasPathBFS("Kochi", "Kochi");
            //Console.WriteLine("Path exists between Delhi and Bangalore : " + res);
            Console.ReadKey();

        }
    }
}
