using System;
namespace assignment2
{
    public class SubArrays
    {
        int[] intarray = new int[10];


        public void Find(int[] array1, int k)
        {

            int sum = 0;
            
            //Fill array 1 through 10
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 1;
            }
            //This searches through the array and adds up numbers until it equals num > x
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] + array1[i + 1] < k) // Out of bounds array
                {
                    sum += array1[i] + array1[i + 1];
                }
                else
                {

                }
                Console.WriteLine("The sub array which adds up to " + k + "is " + "{" + array1[i] + array1[i + 1] + "}");
            }
                

        }
    }
}
