using System;
namespace assignment2
{

    public class Node
    {
        public Node next;
        //  public Node previous;
        public Object data;
    }
    public class LList
    {
        private Node head;
        // private Node tail;


        //This adds a new node at the head
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }
        //This adds a new node to the tail
        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }
        //*This gets the count of the lis
        //*Should be O(1) so need to track count in other methods
        public int GetCount()
        {
            return -1;
        }
        //Keep track of size of list, generate random # up to that size, insert at that position in list
        public void InsertAtRandomLocation(Object data) 
        {

        }
    }
}





