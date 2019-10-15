﻿using System;
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
        private int count;

        public LList(int count)
        {
            this.count = count;

        }


        //This adds a new node at the head
        public void AddFront(Object data)
        {

            if (head == null)
            {
                // First node. Head and Tail now point to the one and only node (set to contain data)

                head = new Node() { data = data };
                tail = head;
            }
            else
            {
                // New node becomes new Head of list

                var oldHead = head;

                // Head now points to new node containing data
                head = new Node()
                {
                    data = data,
                    next = oldHead // points to what used to be the Head (now 2nd in list)
                };
                // Node that used to be the Head now points back to new Head
                oldHead.previous = head;
            }
            
        }
        //This adds a new node to the tail
        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node() { data = data };
                head.data = data;
                head.next = null;
            }
            else
            {
                //new Node becomes tail of list
                var oldTail = tail;

                //tail now points to new node containing data
                tail = new Node()
                {
                    data = data,
                    previous = oldTail


                };
            }
            count += 1;
        }
        //*This gets the count of the list
        //*Should be O(1) so need to track count in other methods
        public int GetCount()
        {
            return count;
        }
        //Keep track of size of list, generate random # up to that size, insert at that position in list
        public void InsertAtRandomLocation(Object data) 
        {
            Random random = new Random();
            int randomNum = random.Next(1, count);
            Node current = head;

            tail.data = data;
            //find the position, and swap it with the tail
            for (int i = 0; i < randomNum; i++)
            {
                current.previous = current;
                current.next = current.next.next;

            }
            //swap the data of current node with data of tail node
            Node temp = new Node();
            temp.data = current.data;
            current.data = tail.data;
            tail.data = temp;

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
            String forward = "";
            return forward;
        }
        //Prints the list backwards
        public String PrintAllReverse()
        {
            string backwards = "";
            return backwards;
        }

    }
}





