using SimpleSnake.GameObjects.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private const char snakeSymbol = '\u25CF';
        private Queue<Point> snakeElements;
        private Food[] foods;
        private Wall wall;
        private int foodIndex;

        private int RandomFoodNumber => new Random().Next(0, this.foods.Length);

        private int nextLeftX;
           private int nextTopY;
        private char emptySpace = ' ';

        public Snake(Wall wall)
        {
            this.wall = wall;
            this.foods = new Food[3];
            this.snakeElements = new Queue<Point>();
            foodIndex = RandomFoodNumber;
            this.GetFood();
            this.CreateSnake();

        }
        private void CreateSnake()
        {
            for (int leftX = 0; leftX < 6; leftX++)
            {
                this.snakeElements.Enqueue(new Point(leftX,2 ));
            }
			this.foods[this.foodIndex].SetRandomPosition(snakeElements);
        }

        private void GetFood()
        {
            this.foods[0] = new FoodHash(wall);
            this.foods[1] = new FoodAsterisk(wall);
            this.foods[2] = new FoodDollar(wall);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }



        public bool isMoving(Point direction)
        {
            Point currentSnankeHead = this.snakeElements.Last();
            GetNextPoint(direction, currentSnankeHead);
            bool isPointOfSnake = this.snakeElements.Any(x => x.LeftX == nextLeftX && x.TopY == nextTopY);

            if (isPointOfSnake)
            {
                return false;
            }

            Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);

            if (wall.isPointOfWall(snakeNewHead))
            {
                return false;
            }
            this.snakeElements.Enqueue(snakeNewHead);
            snakeNewHead.Draw(snakeSymbol);
            if (this.foods[foodIndex].isFoodPoint(snakeNewHead))
            {
                this.Eat(direction, currentSnankeHead);
            }
            


            Point snakeTail = this.snakeElements.Dequeue();
            snakeTail.Draw(emptySpace);
                return true;
        }

        public void Eat(Point direction, Point currentSnankeHead)
        {
            int length = this.foods[this.foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                GetNextPoint(direction, currentSnankeHead);
            }

            this.foodIndex = this.RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(snakeElements);


            this.wall.AddPoints(this.snakeElements);
            this.wall.PlayerInfo();




        }
    }
}
