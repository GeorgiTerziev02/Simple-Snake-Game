using System;

namespace SimpleSnake.GameObjects
{
    public class Score
    {
        private int leftX;
        private int topY;
        public Score(int leftX, int topY)
        {
            this.leftX = leftX;
            this.topY = topY;

            this.Points = 0;
        }
        public int Points { get; private set; }

        public void IncreasePoints(int food)
        {
            this.Points += food + 1;
        }
        public void PrintPoints()
        {
            Console.SetCursorPosition(leftX, topY);
            Console.WriteLine("Your score:");
            Console.SetCursorPosition(leftX, topY + 1);
            Console.WriteLine(this.Points);
            Console.SetCursorPosition(leftX, topY + 2);
        }
    }
}
