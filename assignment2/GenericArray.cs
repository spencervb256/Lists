using System;

namespace assignment2
{

public class GenericArray<T>
{
        //start of ArrayList implementation

       //The array
        private T[] array;

        //Constructor
        public GenericArray(int size)
        {
            array = new T[size + 1];
        }

        //METHODS FOR ARRAY LIST
        //
        //
        public void Create(int size)
        {
            array = new T[size + 1];
        }
        private void Grow(int newsize)
        {

            Array.Resize(ref array, newsize);

        }

        //this adds to the last index, calls grow if it needs to
        public void Append(T value)
        {

            for (int i = 0; array[i + 1] == null; i++)
            {
                if (array[i + 1] == null)
                {
                    array[i + 1] = value;
                }
                if (i >= array.Length)
                {
                    Grow(array.Length * 2);
                    array[i + 1] = value;
                }
            }
        }
        //This should sort the array without making second array, use in built array sorting for now
        public void InPlaceSort()
        {
            Array.Sort(array);
        }
        //This method should swap the position of two elements in the array list
        public void Swap(int index1, int index2)
        {
            
        }
        //This method deletes the last element in the array
        public void DeleteLast()
        {
            for (int i = 0; array[i + 1] == null; i++)
            {
                array[i] = default (T);

                //wack
            }
        }
        //this method takes in two array lists and returns a 3rd unsorted which is the first 2 unsorted
        public static GenericArray<T> Merge(GenericArray<T> al1, GenericArray<T> al2)
        {
            int biggestArray = ((al1.array.Length > al2.array.Length ? al1.array.Length : al2.array.Length));
            GenericArray<T> al3 = new GenericArray<T>(biggestArray);
            foreach (var item in al1.array)
            {
                al3.Append(item);
            }
            foreach (var item in al2.array)
            {
                al3.Append(item);

            }
            return al3;
        }


        //returns string of array list
        public String PrintAllForward()
        {
            string arrayList = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayList += array[i];
            }
            return arrayList;

        }
        //Returns string of array list but backwards
        public String PrintAllReverse()
        {
            string arrayListBackwards = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                arrayListBackwards += array[i];
            }
            return arrayListBackwards;
        }


    }
}
        
      
   
        
