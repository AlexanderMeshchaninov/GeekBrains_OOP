﻿using System;
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

            //Отрисовка рамки
            HorizontalLines upLine = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines downLine = new HorizontalLines(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(76, 24, '#');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
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
