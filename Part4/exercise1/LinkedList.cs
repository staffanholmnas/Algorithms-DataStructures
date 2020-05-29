using System;

namespace Part4
{
    public class LinkedList
    {
        // I used this article as a guide and got ideas on how to start doing this exercise: 
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
        // printNodes() was used for troubleshooting.
        public void printNodes()
        {
            Node current = this.head;
            while (current != null)
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
            if (this.head == null)
            {
                return;
            }

            Node deleteMe = this.head;

            if (deleteMe.next == null && deleteMe.previous == null)
            {
                this.head = null;
            }
            else
            {
                while (deleteMe != null)
                {
                    if (deleteMe.previous == null)
                    {
                        this.head = deleteMe.next;
                    }
                    deleteMe = deleteMe.next;
                }
                this.head.previous = null;
            }
        }
        public void RemoveLast()
        {
            {
                if (this.head == null)
                {
                    return;
                }

                Node deleteLast = this.head;

                if (deleteLast.next == null && deleteLast.previous == null)
                {
                    this.head = null;
                }
                
                while (deleteLast.next != null)
                {
                    deleteLast = deleteLast.next;
                }
                if (deleteLast.previous != null)
                {
                    deleteLast = deleteLast.previous;
                    deleteLast.next = null;
                }
            }
        }
        public int GetNode(int x)
        {
            if (x < 0)
            {
                return 0;
            }

            Node tempNode = this.head;

            if (tempNode == null)
            {
                return 0;
            }
            
            int index = 0;

            while (tempNode != null)
            {
                tempNode = tempNode.next;
                index++;
            } 
            if (x >= index)
            {
                return 0;
            }

            tempNode = this.head;
            index = 0;
            while (tempNode != null)
            {
                if (index == x)
                {
                    break;
                }
                tempNode = tempNode.next;
                index++;
            } 
            return tempNode.value;
        }

        public override string ToString()
        {
            int count = 0;
            Node current = this.head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            string[] allValues = new string[count];
            current = this.head;
            int index = 0;
            while (current != null)
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
