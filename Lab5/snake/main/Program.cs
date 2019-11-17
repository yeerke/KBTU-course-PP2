using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace main
{
    class Program
    {
        static void Serialization(Worm worm)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Worm));
            FileStream fs = new FileStream("worm.txt", FileMode.Create, FileAccess.Write);
            xml.Serialize(fs, worm);
            fs.Close();
        }
        static Worm DeSerialization()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Worm));
            FileStream fs = new FileStream("worm.txt", FileMode.Open, FileAccess.Read);
            Worm worm = xml.Deserialize(fs) as Worm;
            fs.Close();
            return worm;
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(70, 35);
            Console.SetBufferSize(70, 35);
            Console.SetCursorPosition(25, 17);
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetCursorPosition(0, 32);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < 70; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("USER: " + name);
            bool gameOver = false;
            int score = 0;
            Worm worm = new Worm();
            Fruit fruit = new Fruit();
            Wall wall = new Wall();
            worm.sign = 'o';
            wall.sign = '#';
            fruit.sign = 'F';
            worm.eaten = true;
            bool action = true;
            while (!gameOver)
            {                
                if (action == true)
                {
                    worm.Draw();
                    if (worm.newlvl == true)
                    {
                        wall.Clear();
                        wall.CreateWall(worm.cnt / 10 + 1);
                        wall.Draw();
                        worm.newlvl = false;
                    }
                    if (worm.eaten == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(0, 34);
                        Console.Write("SCORE: " + score);
                        score += 100;
                        worm.eaten = false;
                        fruit.generateLoc(wall.body, worm.body);

                    }
                    fruit.Draw();
                }
                int dx = 0, dy = 0;                
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        dx = 0;
                        dy = -1;
                        action = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        dx = -1;
                        dy = 0;
                        action = true;
                        break;
                    case ConsoleKey.DownArrow:
                        dx = 0;
                        dy = 1;
                        action = true;
                        break;
                    case ConsoleKey.RightArrow:
                        dx = 1;
                        dy = 0;
                        action = true;
                        break;
                    case ConsoleKey.F2:
                        Serialization(worm);
                        action = false;
                        break;
                    case ConsoleKey.F3:
                        Worm worm2 = DeSerialization();
                        worm2.body.RemoveAt(0);
                        worm.Clear();
                        worm.cnt = worm2.cnt;
                        worm.body.Clear();
                        foreach(Point p in worm2.body)
                        {
                            worm.body.Add(p);
                        }
                        worm.eaten = worm2.eaten;
                        action = false;
                        break;
                    case ConsoleKey.Escape:
                        gameOver = true;
                        break;
                    default:
                        action = false;
                        Console.SetCursorPosition(Console.CursorLeft-1, Console.CursorTop);
                        Console.Write(' ');
                        break;
                }
                if (worm.body.Count > 1)
                {
                    if (worm.body[0].x + dx == worm.body[1].x && worm.body[0].y + dy == worm.body[1].y)
                    {
                        continue;
                    }
                }
                if (action == true)
                {
                    worm.MoveTo(dx, dy, fruit.body[0].x, fruit.body[0].y);
                    gameOver = (wall.CollisionWithWall(worm.body[0].x, worm.body[0].y) || worm.CollisionWithItself());
                }
                if (pressedKey.Key == ConsoleKey.F3) action = true;
            }
            if (gameOver == true)
            {
                Console.Clear();
                Console.WriteLine("Game Over!");
            }
        }
    }
}