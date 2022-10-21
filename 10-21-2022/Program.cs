namespace Program
{
    class Program
    {
        public static void Main()
        {
            LinkedList listA = new LinkedList(new Node(1));
            listA.AddNode(new Node(2));
            listA.AddNode(new Node(10));
            LinkedList listB = new LinkedList(new Node(3));
            listB.AddNode(new Node(10));
            listB.AddNode(new Node(4));
            

            Node intersection = listA.FindIntersection(listB);
            if(intersection != null)
            {
                Console.WriteLine($"Intersection located at the node \"{intersection.Data}\"");
            }
            else
            {
                Console.WriteLine("No intersection was found.");
            }
        }
    }

    internal class Node
    {
        private int _Data;
        public int Data { get { return _Data; } set { _Data = value; } }

        private Node _Next = null;
        public Node Next { get { return _Next; } set { _Next = value; } }

        public Node(int value)
        {
            _Data = value;
        }
    }

    internal class LinkedList
    {
        private int _Count;
        public int Count { get { return _Count; } set { _Count = value; } }

        private Node _Head = null;
        public Node Head { get { return _Head; } set { _Head = value; } }

        private Node _Tail = null;
        public Node Tail { get { return _Tail; } set { _Tail = value; } }

        public LinkedList(Node head)
        {
            _Head = head;
            _Tail = head;
            _Count = 1;
        }

        public void AddNode(Node newNode)
        {
            _Tail.Next = newNode;
            _Tail = newNode;
            _Count++;
        }

        public Node FindIntersection(LinkedList list)
        {
            for(Node nodeA = _Head; nodeA != null; nodeA = nodeA.Next)
            {
                for(Node nodeB = list.Head; nodeB != null; nodeB = nodeB.Next)
                {
                    if(nodeA.Data == nodeB.Data)
                    {
                        return nodeA;
                    }
                }
            }
            return null;
        }
    }
}