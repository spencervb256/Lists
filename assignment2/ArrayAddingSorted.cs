using System;
namespace assignment2
{
    public class ArrayAddingSorted
    {
        public int[] ints = new int[10];




        //Given an integer x and an unsorted array of integers, write a program to determine whether two numbers
        //in the array add up to x

        public void add(int x)
        {
            int difference;

            for (int i = 0; i < ints.Length; i++)
            {
                
                ints[i] = i;
            }
            for(int j = 0; j< ints.Length; j++)
            {
                difference = x - ints[j];

                if (ints[j] == difference)
                {

                    Console.WriteLine("The two numbers which add up to " + x + "are " + ints[j] + "and " + (x - difference));


                }
                break;
            }
            
            
            Console.WriteLine("No two numbers add up to " + x);

        }


    }
}
