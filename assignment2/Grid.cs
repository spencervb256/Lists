using System;
namespace assignment2
{
    public class Grid
    {

        //This is a 10 by 10 grid of cells, implemented in a multidimensional ArrayList
        //TODO : change the gridArray to multidimensional ArrayList

        public Cell GenericArray gridArray = new GenericArray(10) { }


        public void Create()
        {
            int n = 0;
            int m = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {


                    //generate grid of cells
                    gridArray[i, j] = new Cell(10, 10);

                    //change this to be a multi dimensional array list, don't need Id's anymore




                }
            }
        }


    }
}
