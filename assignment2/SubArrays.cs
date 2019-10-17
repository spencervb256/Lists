using System;
namespace assignment2
{
    public class SubArrays
    {


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
                if (sum + array1[i] + array1[i + 1] < k) //Finds only one sub array, add in to find 2 different arrays such as {1, 2}, {2, 3}
                                                         //both adding up to less than 6
                {
                    sum += array1[i] + array1[i + 1];
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The sub array which adds up to " + k + "is " + "{" + array1[i] + "," + array1[i+1] + "}");
                    break;
                }
            }
            


        }
    }
}
