
namespace Part4
{
    public class LinkedList
    {

        public Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public void AddFirst(LinkedList linkedList, int n)
        {
            Node newNode = new Node(n);
            newNode.next = linkedList.head;
            newNode.previous = null;
            if (linkedList.head != null)
            {
                linkedList.head.previous = newNode;
            }
            linkedList.head = newNode;
            
        }
        public void AddLast(int n)
        {

        }
        public void RemoveFirst()
        {

        }
        public void RemoveLast()
        {

        }
        public void GetNode(int x)
        {

        }

        public override string ToString()
        {
            

            return this.node.value.ToString();
        }
    }
}