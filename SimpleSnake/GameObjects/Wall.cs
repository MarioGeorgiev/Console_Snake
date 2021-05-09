using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';
        public Wall(int leftX, int topY) 
            : base(leftX, topY)
        {
            InitiallizeWallBorders();
        }

        private void InitiallizeWallBorders()
        {
            SetHorizontalLine(0);
            SetHorizontalLine(this.TopY - 1);

            SetVerticalLine(0);
            SetVerticalLine(this.LeftX);
        }

        private void SetHorizontalLine(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                Draw(leftX, topY, wallSymbol);
            }
        }
        private void SetVerticalLine(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                Draw(leftX, topY, wallSymbol);
            }
        }
        public bool isPointOfTheWall(Point snake)
        {
            return snake.TopY == 0 || snake.LeftX == 0 || snake.TopY == this.TopY || snake.LeftX == this.LeftX;
        }

    }
}
