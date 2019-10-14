using System;

namespace assignment2
{

public class ArrayList<T>
{
        //start of ArrayList implementation

       //The array
        private T[] array;

        //Constructor
        public ArrayList(int size)
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
                array[i] = default (T); //Throwing error that cannot convert null to type parameter 'T'

                //wack
            }
        }
        //this method takes in two array lists and returns a 3rd unsorted which is the first 2 unsorted
        public static ArrayList Merge(ArrayList al1, ArrayList al2)
        {
            ArrayList al3 = new ArrayList(20);
            al3.();
            foreach (var item in al1)
            {

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






//methods for ArrayList


//This creates an empty array list
        //This doubles the size of the array when it grows
        
        //This adds to the last index, calls grow if it needs to
        
      
   
        
