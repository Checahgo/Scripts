namespace Beginning.CSharp
{
    public struct Player
        {
            public string Name;
            private int score;
            public int Lives;

            public void SetScore(int score)
            {
                this.score = score;
            }

            public int GetScore()
            {
                return this.score = score + 1;
            }
        }
}