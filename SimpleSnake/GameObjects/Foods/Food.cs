using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food : Point
    {
        private Wall wall;
        private Random random;
        private char foodSymbol;
        public Food(Wall wall,char foodSymbol,int points) 
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            FoodPoints = points;
            this.foodSymbol = foodSymbol;
            random = new Random();
        }
        public int FoodPoints { get; private set; }
        //public char FoodSymbol { get; private set; }
        public void SetRandomPosition(Queue<Point> snake)
        {
             this.LeftX = random.Next(2, LeftX-2);
             this.TopY = random.Next(2, TopY-2);

            bool isPointOfTheSnake = snake.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);
            while(isPointOfTheSnake)
            {
                this.LeftX = random.Next(2, LeftX - 2);
                this.TopY = random.Next(2, TopY - 2);

                isPointOfTheSnake = snake.Any(x => x.LeftX == this.LeftX && x.TopY == this.TopY);
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
        public bool IsFoodPoint(Point snake)
        {
            return snake.TopY == this.TopY &&
                snake.LeftX == this.LeftX;
        }
    }
}
