using System;

namespace Part4
{
    public class LinkedList
    {
        // Disclaimer, I used this article for ideas on how to do this exercise: 
        // https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
        public Node head;

        public LinkedList()
        {
            this.head = null;
        }

        public void AddFirst(int n)
        {
            Node newNode = new Node(n, null, null);
            newNode.next = this.head;
            newNode.previous = null;
            if (this.head != null)
            {
                this.head.previous = newNode;
            }
            this.head = newNode;
        }
        public void printNodes()
        {
            Node current = this.head;
            while (current!= null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        public void AddLast(int n)
        {
            Node newNode = new Node(n, null, null);
            if (this.head == null)
            {
                newNode.previous = null;
                this.head = newNode;
                return;
            }
            Node lastNode = this.head;
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = newNode;
            newNode.previous = lastNode;
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
            int count = 0;
            Node current = this.head;
            while (current!= null)
            {
                count++;
                current = current.next;
            }
            string[] allValues = new string[count];
            current = this.head;
            int index = 0;
            while (current!= null)
            {
                allValues[index] = current.value.ToString();
                current = current.next;
                index++;
            }
            
            string stringOfValues = String.Join(", ", allValues);
            return stringOfValues;
        }
    }
}
