
namespace Part4
{
    public class LinkedList
    {

        public Node node;

        public LinkedList()
        {
            this.node = new Node(0,null,null);
        }

        public void AddFirst(int n)
        {
            this.node.value = n;
            
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