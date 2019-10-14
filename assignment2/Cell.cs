using System;
namespace assignment2
{
    public class Cell
    {
        //private int id;
        //private double[] position;
        private float width;
        private float height;


        public Cell(float width, float height)
        {
            //this.id = id;
            this.width = width;
            this.height = height;
        }
        
        public void SetWidth(float desiredWidth)
        {
            this.width = desiredWidth;
        }
        public float GetWidth()
        {
            return width;
        }
        public void SetHeight(float desiredHeight)
        {
            this.height = desiredHeight;
        }
        public float GetHeight()
        {
            return height;
        }

    }
}
