using System;
using System.Collections.Generic;


class SnakeGame
{
    static int width = 20;
    static int height = 20;
    static int score = 0;
    static List<(int, int)> snake = new List<(int, int)>();
    static (int, int) food;
    static (int, int) direction = (0, 1);
    static Random random = new Random();

    static void Main()
    {
        Console.CursorVisible = false;
        snake.Add((width / 2, height / 2));
        GenerateFood();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;
                direction = key switch
                {
                    ConsoleKey.UpArrow => (-1, 0),
                    ConsoleKey.DownArrow => (1, 0),
                    ConsoleKey.LeftArrow => (0, -1),
                    ConsoleKey.RightArrow => (0, 1),
                    _ => direction
                };
            }

            MoveSnake();
            if (CheckCollision())
            {
                break;
            }

            Draw();
            Thread.Sleep(100);
        }

        Console.Clear();
        Console.WriteLine($"Game Over! Your score: {score}");
    }

    static void MoveSnake()
    {
        var head = snake[0];
        var newHead = (head.Item1 + direction.Item1, head.Item2 + direction.Item2);
        snake.Insert(0, newHead);

        if (newHead == food)
        {
            score++;
            GenerateFood();
        }
        else
        {
            snake.RemoveAt(snake.Count - 1);
        }
    }

    static bool CheckCollision()
    {
        var head = snake[0];
        if (head.Item1 < 0 || head.Item1 >= height || head.Item2 < 0 || head.Item2 >= width)
        {
            return true;
        }

        for (int i = 1; i < snake.Count; i++)
        {
            if (snake[i] == head)
            {
                return true;
            }
        }

        return false;
    }

    static void GenerateFood()
    {
        food = (random.Next(0, height), random.Next(0, width));
    }

    static void Draw()
    {
        Console.Clear();
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (snake.Contains((i, j)))
                {
                    Console.Write("O");
                }
                else if (food == (i, j))
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
