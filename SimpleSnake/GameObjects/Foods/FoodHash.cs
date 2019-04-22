using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    class FoodHash : Food
    {

        private const char foodChar = '#';
        private const int foodPoint = 3;
        public FoodHash(Wall wall) : base(wall, foodChar, foodPoint)
        {
        }
    }
}
