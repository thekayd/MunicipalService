
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace MunicipalServicesApp
{
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }

        public int CompareTo(ServiceRequest other)
        {
            return this.Priority.CompareTo(other.Priority);
        }
    }

    public class TreeNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public int Height { get; set; }
        public bool IsRed { get; set; }

        public TreeNode(T data)
        {
            Data = data;
            Height = 1;
            IsRed = true;
        }
    }

    public class ServiceManager
    {
        private TreeNode<ServiceRequest> bstRoot;
        private TreeNode<ServiceRequest> avlRoot;
        private TreeNode<ServiceRequest> rbRoot;
        private List<ServiceRequest> heap;
        private Dictionary<string, List<string>> serviceGraph;
        private Dictionary<string, List<(string, int)>> weightedGraph = new Dictionary<string, List<(string, int)>>();
        private static int lastRequestId = 005;

        public ServiceManager()
        {
            heap = new List<ServiceRequest>();
            serviceGraph = new Dictionary<string, List<string>>();

            // Initialize sample graph connections
            InitializeGraph();

            // Run the graph operations immediately
            RunGraphOperations();
        }

        // Method to generate a new unique ID
        public static string GenerateNextRequestId()
        {
            lastRequestId++;
            return $"SR{lastRequestId:D3}";
        }

        private void InitializeGraph()
        {
            // Sample connections for MST and BFS testing
            AddWeightedGraphConnection("SR001", "SR002", 4);
            AddWeightedGraphConnection("SR002", "SR003", 6);
            AddWeightedGraphConnection("SR003", "SR004", 5);
            AddWeightedGraphConnection("SR001", "SR004", 10);
            AddWeightedGraphConnection("SR002", "SR004", 2);
        }

        // BST Operations
        public void InsertBST(ServiceRequest request)
        {
            bstRoot = InsertBSTRecursive(bstRoot, request);
        }

        private TreeNode<ServiceRequest> InsertBSTRecursive(TreeNode<ServiceRequest> node, ServiceRequest request)
        {
            if (node == null)
                return new TreeNode<ServiceRequest>(request);

            if (request.CompareTo(node.Data) < 0)
                node.Left = InsertBSTRecursive(node.Left, request);
            else
                node.Right = InsertBSTRecursive(node.Right, request);

            return node;
        }

        // AVL Tree Operations
        public void InsertAVL(ServiceRequest request)
        {
            avlRoot = InsertAVLRecursive(avlRoot, request);
        }

        private TreeNode<ServiceRequest> InsertAVLRecursive(TreeNode<ServiceRequest> node, ServiceRequest request)
        {
            if (node == null)
                return new TreeNode<ServiceRequest>(request);

            if (request.CompareTo(node.Data) < 0)
                node.Left = InsertAVLRecursive(node.Left, request);
            else
                node.Right = InsertAVLRecursive(node.Right, request);

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            // Left Left Case
            if (balance > 1 && request.CompareTo(node.Left.Data) < 0)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && request.CompareTo(node.Right.Data) > 0)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && request.CompareTo(node.Left.Data) > 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && request.CompareTo(node.Right.Data) < 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        private int GetHeight(TreeNode<ServiceRequest> node)
        {
            if (node == null)
                return 0;
            return node.Height;
        }

        private int GetBalance(TreeNode<ServiceRequest> node)
        {
            if (node == null)
                return 0;
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        private TreeNode<ServiceRequest> RightRotate(TreeNode<ServiceRequest> y)
        {
            TreeNode<ServiceRequest> x = y.Left;
            TreeNode<ServiceRequest> T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x;
        }

        private TreeNode<ServiceRequest> LeftRotate(TreeNode<ServiceRequest> x)
        {
            TreeNode<ServiceRequest> y = x.Right;
            TreeNode<ServiceRequest> T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            return y;
        }

        // Red-Black Tree Operations
        public void InsertRB(ServiceRequest request)
        {
            rbRoot = InsertRBRecursive(rbRoot, request);
            rbRoot.IsRed = false; // Root must be black
        }

        private TreeNode<ServiceRequest> InsertRBRecursive(TreeNode<ServiceRequest> node, ServiceRequest request)
        {
            if (node == null)
                return new TreeNode<ServiceRequest>(request);

            if (request.CompareTo(node.Data) < 0)
                node.Left = InsertRBRecursive(node.Left, request);
            else
                node.Right = InsertRBRecursive(node.Right, request);

            // Fix Red-Black tree violations
            if (IsRed(node.Right) && !IsRed(node.Left))
                node = RotateLeft(node);
            if (IsRed(node.Left) && IsRed(node.Left.Left))
                node = RotateRight(node);
            if (IsRed(node.Left) && IsRed(node.Right))
                FlipColors(node);

            return node;
        }

        private bool IsRed(TreeNode<ServiceRequest> node)
        {
            if (node == null)
                return false;
            return node.IsRed;
        }

        private TreeNode<ServiceRequest> RotateLeft(TreeNode<ServiceRequest> node)
        {
            TreeNode<ServiceRequest> x = node.Right;
            node.Right = x.Left;
            x.Left = node;
            x.IsRed = node.IsRed;
            node.IsRed = true;
            return x;
        }

        private TreeNode<ServiceRequest> RotateRight(TreeNode<ServiceRequest> node)
        {
            TreeNode<ServiceRequest> x = node.Left;
            node.Left = x.Right;
            x.Right = node;
            x.IsRed = node.IsRed;
            node.IsRed = true;
            return x;
        }

        private void FlipColors(TreeNode<ServiceRequest> node)
        {
            node.IsRed = true;
            node.Left.IsRed = false;
            node.Right.IsRed = false;
        }

        // Heap Operations
        public void InsertHeap(ServiceRequest request)
        {
            heap.Add(request);
            HeapifyUp(heap.Count - 1);
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index].CompareTo(heap[parent]) >= 0)
                    break;

                ServiceRequest temp = heap[index];
                heap[index] = heap[parent];
                heap[parent] = temp;
                index = parent;
            }
        }

        // Graph Operations
        public void AddGraphConnection(string requestId, string relatedRequestId)
        {
            if (!serviceGraph.ContainsKey(requestId))
                serviceGraph[requestId] = new List<string>();

            serviceGraph[requestId].Add(relatedRequestId);
        }

        public List<string> GetRelatedRequests(string requestId)
        {
            return serviceGraph.ContainsKey(requestId) ? serviceGraph[requestId] : new List<string>();
        }

        // Find requests using different data structures
        public ServiceRequest FindRequestBST(string id)
        {
            return FindRequestBSTRecursive(bstRoot, id);
        }

        private ServiceRequest FindRequestBSTRecursive(TreeNode<ServiceRequest> node, string id)
        {
            if (node == null)
                return null;

            if (node.Data.Id == id)
                return node.Data;

            ServiceRequest left = FindRequestBSTRecursive(node.Left, id);
            if (left != null)
                return left;

            return FindRequestBSTRecursive(node.Right, id);
        }

        // Get all requests in order of priority
        public List<ServiceRequest> GetPrioritizedRequests()
        {
            List<ServiceRequest> result = new List<ServiceRequest>();
            InorderTraversal(bstRoot, result);
            return result;
        }

        private void InorderTraversal(TreeNode<ServiceRequest> node, List<ServiceRequest> result)
        {
            if (node != null)
            {
                InorderTraversal(node.Left, result);
                result.Add(node.Data);
                InorderTraversal(node.Right, result);
            }
        }

        public void AddWeightedGraphConnection(string requestId, string relatedRequestId, int weight)
        {
            if (!weightedGraph.ContainsKey(requestId))
                weightedGraph[requestId] = new List<(string, int)>();
            weightedGraph[requestId].Add((relatedRequestId, weight));

            if (!weightedGraph.ContainsKey(relatedRequestId))
                weightedGraph[relatedRequestId] = new List<(string, int)>();
            weightedGraph[relatedRequestId].Add((requestId, weight)); // Undirected graph
        }

        // Graph Traversal (BFS)
        public List<string> BFS(string startId)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            var result = new List<string>();

            queue.Enqueue(startId);
            visited.Add(startId);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Add(current);

                if (serviceGraph.ContainsKey(current))
                {
                    foreach (var neighbor in serviceGraph[current])
                    {
                        if (!visited.Contains(neighbor))
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
            return result;
        }

        // Minimum Spanning Tree using Prim's Algorithm
        public List<(string, string, int)> GetMinimumSpanningTree()
        {
            var mstEdges = new List<(string, string, int)>();
            var visited = new HashSet<string>();
            var priorityQueue = new SortedSet<(int weight, string from, string to)>();

            // Start with an arbitrary node
            string startNode = weightedGraph.Keys.First();
            visited.Add(startNode);

            foreach (var (neighbor, weight) in weightedGraph[startNode])
                priorityQueue.Add((weight, startNode, neighbor));

            while (priorityQueue.Count > 0 && visited.Count < weightedGraph.Count)
            {
                var (weight, from, to) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                if (visited.Contains(to)) continue;

                visited.Add(to);
                mstEdges.Add((from, to, weight));

                foreach (var (nextNeighbor, nextWeight) in weightedGraph[to])
                {
                    if (!visited.Contains(nextNeighbor))
                        priorityQueue.Add((nextWeight, to, nextNeighbor));
                }
            }

            return mstEdges;
        }

        // Logging Method
        private void LogToFile(string message)
        {
            using (var writer = new StreamWriter("graph_operations_log.txt", true))
            {
                writer.WriteLine(message);
            }
        }

        // Graph Operations Runner Method
        public void RunGraphOperations()
        {
            // Log BFS traversal result
            string startNode = "SR001"; // Example start node
            var bfsResult = BFS(startNode);
            LogToFile("BFS Traversal from " + startNode + ":");
            bfsResult.ForEach(id => LogToFile(id));

            LogToFile(""); // Add a blank line for readability

            // Log Minimum Spanning Tree result
            var mstResult = GetMinimumSpanningTree();
            LogToFile("Minimum Spanning Tree:");
            foreach (var (from, to, weight) in mstResult)
            {
                LogToFile($"{from} - {to} : {weight}");
            }

            LogToFile("=================================="); // Separator for each run
        }
    }
}


