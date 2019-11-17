using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Layer
    {
        int selecteditem = 0;
        public FileSystemInfo[] items;
        public Layer(DirectoryInfo dir)
        {
            FileSystemInfo[] Items = dir.GetFileSystemInfos();
            this.items = Items;
        }
        public int Selecteditem
        {
            get
            {
                return selecteditem;
            }
            set
            {
                if (value >= items.Length)
                {
                    selecteditem = 0;
                }
                else if (value < 0)
                {
                    selecteditem = items.Length - 1;
                }
                else selecteditem = value;
            }
        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 0; i < items.Length; i++)
            {
                if (i == selecteditem)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else Console.BackgroundColor = ConsoleColor.Black;
                if (items[i].GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(items[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\Erkebulan\Desktop\pp2");
            Stack<Layer> history = new Stack<Layer>();
            history.Push(new Layer(dirinfo));
            bool quit = false;
            while (!quit)
            {
                history.Peek().Draw();
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().Selecteditem--;
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().Selecteditem++;
                        break;
                    case ConsoleKey.Enter:
                        int x = history.Peek().Selecteditem;
                        DirectoryInfo y = history.Peek().items[x] as DirectoryInfo;
                        history.Push(new Layer(y));
                        break;
                    case ConsoleKey.Backspace:
                        history.Pop();
                        break;
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                }
            }
        }
    }
}
