using System;
namespace assignment2
{
    public class SubArrays
    {


        public void Find(int[] array1, int k)
        {


            //Fill array 1 through 10
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 1;
            }
            int currSum = array1[0];
            int start = 0;
            int end = 0;


            while (end < array1.Length)
            {
                if (currSum == k)
                {
                    Console.WriteLine("Found sub array  {" + array1[start] + " , " + array1[end] + "}");
                }

                if (currSum < k)
                {
                    end++;
                    if (end < array1.Length)
                        currSum += array1[end];
                }
                else
                {
                    currSum -= array1[start];
                    start++;
                }
            }
        }
    }
}
