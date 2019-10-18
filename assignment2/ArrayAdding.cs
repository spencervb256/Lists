using System;
namespace assignment2
{
    public class ArrayAdding
    {



        public int[] ints = new int[10];

        //Given an integer x and an unsorted array of integers, write a program to determine whether two numbers
        //in the array add up to x

        public void add(int x)
        {
            Random random = new Random();


            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(1, 10);
            }
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[i] + ints[j] == x)
                    {
                        Console.WriteLine("The two integers which add up to " + x + "are" + ints[i] + "and" + ints[j]);
                    }
                }
            }
            Console.WriteLine("No two numbers add up to " + x);

        }
            

    }
}
