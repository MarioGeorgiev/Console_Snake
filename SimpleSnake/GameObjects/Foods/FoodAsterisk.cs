using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    class FoodAsterisk : Food
    {

        private const char foodChar = '*';
        private const int foodPoint = 1;
        public FoodAsterisk(Wall wall) : base(wall, foodChar, foodPoint)
        {
        }
    }
}
