using System;
namespace assignment2
{

    public class Node
    {
        public Node next;
        public Node previous;
        public Object data;
    }
    public class LList
    {
        private Node head;
        private Node tail;
        private int count = 0;


        //This adds a new node at the head
        public void AddFront(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
            count += 1;
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
            count += 1;
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
        //This method merges another list onto the calling one at the end (and update count)
        public void Merge(LList list1)
        {

        }
        //Searches (brute forces) and returns the closest object to the one which calls this method
        public Object FindClosest(Object obj)
        {
            return null;
        }
        //Deletes first element in list
        public void DeleteFirst()
        {

        }
        //Deletes Last element in the list
        public void DeleteLast()
        {

        }
        //Prints the list forward
        public String PrintAllForward()
        {
            return "";
        }
        //Prints the list backwards
        public String PrintAllReverse()
        {
            return "";
        }

    }
}





