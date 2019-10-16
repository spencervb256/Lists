using System;
namespace assignment2
{
    public class Grid
    {

        /*
                [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
                [11, 12, 13, 14, 15, 16, 17, 18, 19, 20]
                [21, 22, 23, 24, 25, 26, 27, 28, 29, 30]
            
         
        */


        //ArrayList to hold arrays

       // GenericArray<T> gridArray = new GenericArray<T>(10); //type or namespace "T" could not be found

        //ArrayList to hold cells
        //public GenericArray<T> cellsArray = new GenericArray<T>(10); WACK

       // gridArray[1] = cellsArray[1]; //beginning of the 2d array
        /// <summary>
        /// //
        ///
        /// 
        /// </summary>



        public void generateGrid()
        {
            GenericArray<int> gridArray = new GenericArray<int>(10);

            int n = 0;
            int m = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {


                    //Create Grid of cells, height 10, and width 10, with id's in consecutive ascending order
                  //  gridArray[i, j] = new Cell(i * 10 + j + 1, 10, 10);




                }
            }
        }

    }
}

