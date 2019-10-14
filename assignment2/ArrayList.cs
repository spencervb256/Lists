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

        




        public void PrintAll()
        {
            for (int i = 0; i < array.Length; i++)

                Console.WriteLine(array.GetValue(i));
        }
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

            for (int i = 0; array.GetValue(i + 1) == null; i++)
            {
                if (array.GetValue(i + 1) == null)
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

        //returns string of array list
        public String PrintAllForward()
        {
            string arrayList = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayList += array.GetValue(i);
            }
            return arrayList;

        }
        //Returns string of array list but backwards
        public String PrintAllReverse()
        {
            string arrayListBackwards = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                arrayListBackwards += array.GetValue(i);
            }
            return arrayListBackwards;
        }


    }
}






//methods for ArrayList


//This creates an empty array list
        //This doubles the size of the array when it grows
        
        //This adds to the last index, calls grow if it needs to
        
      
        //this sorts the array without making a new array, using built in sorting
        public void InPlaceSort()
        {

        }
        //This method swaps the position of two elements in list
        public void Swap(int index1, int index2)
        {

        }
        //This method delets the last element
        public void deleteLast()
        {

        }
        //this method takes in two array lists and returns a 3rd unsorted which is the first 2 unsorted
        public static ArrayList Merge(ArrayList al1, ArrayList al2)
        {
            ArrayList al3 = new ArrayList();
            al3.Create();
            foreach (var item in al1)
            {

            }
            return al3;
        }
        //This returns a string that is the whole structure 
        public string StringPrintAllForward()
        {
            return null;

        }
        //This returns a string of the whole arraylist but backwards
        public string StringPrintAllReverse()
        {
            return null;
        }
        //This deletes all values from the array
        public void DeleteAll()
        {

        }
    }

}
