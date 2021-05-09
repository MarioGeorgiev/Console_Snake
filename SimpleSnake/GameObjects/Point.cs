using System;

namespace SimpleSnake.GameObjects
{
    public class Point
    {
        private int leftX;
        private int topY;

        public Point(int leftX, int topY)
        {
            LeftX = leftX;
            TopY = topY;
        }

        public int TopY
        {
            get { return topY; }
            set { topY = value; }
        }

        public int LeftX
        {
            get { return leftX; }
            set { leftX = value; }
        }


        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, TopY);
            Console.Write(symbol);
        }

        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX,topY);
            Console.Write(symbol);
        }
        
    }
}
