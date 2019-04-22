namespace SimpleSnake
{
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using SimpleSnake.GameObjects.Foods;
    using System;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(30, 30);
            Snake snake = new Snake(wall);

            Engine engine = new Engine(snake, wall);
            engine.Run();

        }
    }
}
