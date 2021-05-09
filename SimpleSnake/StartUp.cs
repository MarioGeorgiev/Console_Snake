using SimpleSnake.Core;
using SimpleSnake.GameObjects;
using SimpleSnake.GameObjects.Foods;
using SimpleSnake.Utilities;
using System;
namespace SimpleSnake
{


    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();
            Wall wall = new Wall(20, 20);
            Snake snake = new Snake(wall);
            Engine engine = new Engine(snake,wall);
            engine.Run();

        }
    }
}
