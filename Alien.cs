namespace NPC.Bots
{
   public struct Alien
    {
        private int pointValue;
        private int hitPoints;
        private bool isAlive;

        public int GetPointValue()
        {
            return this.pointValue;
        }

        public int GetHitPoints() 
        {
            return this.hitPoints;
        }

        public bool GetIsAlive() 
        {
            return this.isAlive;
        }

        public void SetPointValue(int pointValue) 
        {
            this.pointValue = pointValue;
        }

        public void SetHitPoints(int hitPoints)
        {
            this.hitPoints = hitPoints;
        }

        public void SetIsAlive(bool isAlive)
        {
            this.isAlive = isAlive;
        }
    } 
}


