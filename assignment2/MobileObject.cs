using System;
namespace assignment2
{
    public class MobileObject
    {
        //Instance Variables
        string name;
        int id;



        //Constructor
        public MobileObject(string name, int id)
        {
            this.name = name;
            this.id = id;

        }
        public void SetName(string thisName)
        {
            this.name = thisName;
        }
        public string GetName()
        {
            return name;
        }
        public int getId()
        {
            return id;
        }
    }
}
