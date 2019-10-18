using System;
namespace assignment2
{
    public class SearchMax
    {
        public void FindMax(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("No Local maximum or minimum");
                return;
            }
            int size = a.Length;
            int first_element = a[0];
            int last_element = a[size - 1];
            if (first_element + size - 1 == last_element || first_element - size + 1 == last_element)
            {
                Console.WriteLine("No Local maximum or minimum");
                return;
            }
            if (first_element < a[1])
            {
                //lets find local maximum
                int last_should_be = first_element + (size - 1);
                int local_max = (last_should_be + last_element) / 2;
                Console.WriteLine("local maximum: " + local_max);
            }
            else
            {
                //lets find local maximum
                int last_should_be = first_element - (size - 1);
                int local_min = (last_should_be + last_element) / 2;
                Console.WriteLine("local minimum: " + local_min);
            }
        }
    }
}
