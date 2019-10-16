using System;
using System.IO;

namespace assignment2
{
    public class Snake : MobileObject
    {
        float length;
        float radius;
        float mass;
        int verteb;
        private float volume;

        public Snake(string name, int id,
            float length, float radius, float mass, int verteb, float volume) : base(name, id)
        {

            this.length = length;
            this.radius = radius;
            this.mass = mass;
            this.verteb = verteb;
            this.volume = volume;

        }
        //Getters and Setters
        public void SetLength(float snakeLength)
        {
            this.length = snakeLength;
        }
        public float GetLength()
        {
            return this.length;
        }
        public void SetRadius(float snakeRadius)
        {
            this.radius = snakeRadius;
        }
        public float GetRadius()
        {
            return this.radius;
        }
        public void SetMass(float snakeMass)
        {
            this.mass = snakeMass;
        }
        public float GetMass()
        {
            return this.mass;
        }
        public void SetVerteb(int snakeVerteb)
        {
            this.verteb = snakeVerteb;
        }
        public int GetVerteb()
        {
            return this.verteb;
        }
        public void SetVolume(float snakeVolume)
        {
            this.length = snakeVolume;
        }
        public float GetVolume()
        {
            return this.volume;
        }


        //To string method
        public abstract override string ToString()
        {
            string s = ("The name is : " + GetName() + " and the id is : " + getId());
            return s;
        }


    }
}
