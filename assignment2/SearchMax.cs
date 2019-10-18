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
            int first = a[0];
            int last = a[size - 1];
            if (first + size - 1 == last || first - size + 1 == last)
            {
                Console.WriteLine("No Local maximum or minimum");
                return;
            }
            if (first < a[1])
            {
                //lets find local maximum
                int lastShouldBe = first + (size - 1);
                int local_max = (lastShouldBe + last) / 2;
                Console.WriteLine("local maximum: " + local_max);
            }
            else
            {
                //lets find local maximum
                int lastShouldBe = first - (size - 1);
                int local_min = (lastShouldBe + last) / 2;
                Console.WriteLine("local minimum: " + local_min);
            }
        }
    }
}
