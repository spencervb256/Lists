using System;
using System.IO;

namespace assignment2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            
            String[] snakenames = File.ReadAllLines("snakenames.txt");
            String[] catnames = File.ReadAllLines("catnames.txt");

            //Create some snakes and cats
            Snake snake1 = new Snake(snakenames[0], 1, 24, 14, 9, 230, 30);
            Snake snake2 = new Snake(snakenames[1], 2, 27, 11, 13, 257, 49);
            Snake snake3 = new Snake(snakenames[2], 3, 15, 12, 6, 241, 43);
            Snake snake4 = new Snake(snakenames[3], 4, 22, 17, 7, 299, 28);
            Snake snake5 = new Snake(snakenames[4], 5, 31, 9, 14, 208, 52);

            Cat cat1 = new Cat(catnames[0], 6, 47, 11, 22, 18, 16, (47 + 11 + 18));
            Cat cat2 = new Cat(catnames[1], 7, 39, 9, 20, 23, 14, (39 + 9 + 23));
            Cat cat3 = new Cat(catnames[2], 8, 42, 15, 25, 20, 17, (42 + 15 + 20));
            Cat cat4 = new Cat(catnames[3], 9, 37, 9, 19, 19, 15, (37 + 9 + 19));
            Cat cat5 = new Cat(catnames[4], 10, 41, 12, 27, 21, 13, (41 + 12 + 21));

            //Add those snakes and cats into a doubly linked list
            DoublyLinkedList ll = new DoublyLinkedList(0);
            ll.AddFront(snake1);
            ll.AddLast(snake2);
            ll.AddLast(snake3);
            ll.AddLast(snake4);
            ll.AddLast(snake5);

            ll.AddLast(cat1);
            ll.AddLast(cat2);
            ll.AddLast(cat3);
            ll.AddLast(cat4);
            ll.AddLast(cat5);

            snake1.ToString();

        }


    }
}


