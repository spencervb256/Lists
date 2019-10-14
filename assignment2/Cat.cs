using System;
namespace assignment2
{
    public class Cat : MobileObject
    {
        float torsoLength;
        float headLength;
        float tailLength;
        float legLength;
        float mass;
        float totalLength;
        public Cat(String name, int id,
            float torsoLength, float headLength, float tailLength, float legLength, float mass, float totalLength)
            : base(name, id)
        {
            this.torsoLength = torsoLength;
            this.headLength = headLength;
            this.tailLength = tailLength;
            this.legLength = legLength;
            this.mass = mass;
            this.totalLength = totalLength;
        }

        //getters and setters
        public void SetTorsoLength(float torso)
        {
            torsoLength = torso;
        }
        public float GetTorsoLength()
        {
            return this.torsoLength;
        }
        public void SetHeadLength(float head)
        {
            headLength = head;
        }
        public float GetHeadLength()
        {
            return this.headLength;
        }
        public void SetTailLength(float tail)
        {
            this.tailLength = tail;
        }
        public float GetTailLength()
        {
            return this.tailLength;
        }
        public void SetLegLength(float leg)
        {
            this.legLength = leg;
        }
        public float GetLegLength()
        {
            return this.legLength;
        }
        public void SetMass(float desiredMass)
        {
            this.mass = desiredMass;
        }
        public float GetMass()
        {
            return this.mass;
        }
        public void SetTotalLength(float desiredTotalLength)
        {
            this.totalLength = (headLength + torsoLength + legLength);
        }
        public float GetTotalLength()
        {
            return this.totalLength;
        }
        
    }
}
