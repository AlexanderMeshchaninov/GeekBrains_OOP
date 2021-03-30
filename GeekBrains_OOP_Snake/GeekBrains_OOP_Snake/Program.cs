using System;
using System.Collections.Generic;
using System.Threading;

namespace GeekBrains_OOP_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(83, 25);
            Console.SetBufferSize(83, 25);
            Console.CursorVisible = false;

            Walls walls = new Walls(76, 23);
            walls.Draw();


            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(76, 24, '#');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.WriteLine("Игра окончена");
                    break;
                }
                if (snake.SnakeEat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.SnakeControl(key.Key);
                }
            }
            Console.ReadKey();
        }
	}
}
