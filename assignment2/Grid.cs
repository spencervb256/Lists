using System;
using System;
namespace assignment2
{
    public class Grid
    {
        //ArrayList to hold arrays

        GenericArray<T> gridArray = new GenericArray<T>(10); //type or namespace "T" could not be found

        //ArrayList to hold cells
        public GenericArray<T> cellsArray = new GenericArray<T>(10);

        gridArray[1] = cellsArray[1]; //beginning of the 2d array
        //



        public void generateGrid()
        {

            int n = 0;
            int m = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {


                    //Create Grid of cells, height 10, and width 10, with id's in consecutive ascending order
                    gridArray[i, j] = new Cell(i * 10 + j + 1, 10, 10);




                }
            }
        }

    }
}