using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    class FoodDollar : Food
    {
        private const char foodChar = '$';
        private const int foodPoint = 2;
        public FoodDollar(Wall wall) : base(wall, foodChar, foodPoint)
        {
        }
    }
}
