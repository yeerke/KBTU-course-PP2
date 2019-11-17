using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    enum Mode //creating enum to know is it dir or file when pressing enter
    {
        DIR,
        FILE
    }
    class layer
    {
        public string filecontent;
        private int selecteditem = 0;
        private List<FileSystemInfo> items;
        public List<FileSystemInfo> Items
        {
            get
            {
                return items;//property for getting items
            }
        }

        public layer(DirectoryInfo dirinfo) //constructor
        {
            FileSystemInfo[] ItemS = dirinfo.GetFileSystemInfos();
            List<FileSystemInfo> Items = new List<FileSystemInfo>();
            Items.AddRange(ItemS);//converting array into list
            this.items = Items; // getting value
        }
        public void delete(FileSystemInfo sys)//method for deleting 
        {
            if (sys.GetType() == typeof(DirectoryInfo))
            {
                Directory.Delete(sys.FullName, true);//deleting directory
            }
            else
            {
                File.Delete(sys.FullName);//deleting file
            }
            items.RemoveAt(selecteditem); //removing filesysteminfo from list at current index    
        }
        public void rename(FileSystemInfo fInfo)//method for renaming
        {
            if (fInfo.GetType() == typeof(DirectoryInfo))
            {
                DirectoryInfo y = fInfo as DirectoryInfo;
                for (int i = 1; i <= 2; i++) // creating space for writing name from console
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("  ");
                }
                Console.Write("Enter new name:"); //writing in console for user 

                string s = Console.ReadLine(); // name that user enter
                string path = y.Parent.FullName;
                string newname = Path.Combine(path, s); // because there is no command in c# for juct renaming name od diredctory
                y.MoveTo(newname); // we will move file to the same path with new name
            }
            else
            {
                FileInfo y = fInfo as FileInfo; // sme wirth file
                for (int i = 1; i <= 2; i++) // creating space for writing name from console
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("  ");
                }
                Console.Write("Enter new name:"); //writing in console for user 

                string s = Console.ReadLine();
                string newname = Path.Combine(y.Directory.FullName, s);
                y.MoveTo(newname);
            }
        }

        public string openingFile(FileInfo f) // method for reading file
        {
            FileStream fs = new FileStream(f.FullName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = sr.ReadToEnd(); //reading file and saving it into string
            fs.Close();
            sr.Close();
            return s; //saving it into filecontent       
        }
        //property for getting and setting the value of selected item
        public int SelectedItem
        {
            get
            {
                return selecteditem;
            }
            set
            {
                if (value < 0) selecteditem = items.Count - 1;
                else
                {
                    if (value >= items.Count) selecteditem = 0;
                    else selecteditem = value;
                }

            }
        }
        public void Draw(Mode caase) // method for visualization
        {
            if (caase == Mode.FILE)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(filecontent);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == selecteditem)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else Console.BackgroundColor = ConsoleColor.Black;
                    if (items[i].GetType() == typeof(DirectoryInfo))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(items[i].Name);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\Erkebulan\source\Programming");
            Stack<layer> history = new Stack<layer>(); //creating stack for saving layers
            Mode Case = Mode.DIR; // initially its directory mode
            history.Push(new layer(dirinfo));
            bool quit = false;
            while (!quit)
            {
                history.Peek().Draw(Case);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedItem--; //for controlling
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedItem++;
                        break;
                    case ConsoleKey.Enter:
                        int x = history.Peek().SelectedItem;
                        FileSystemInfo y = history.Peek().Items[x] as FileSystemInfo;
                        if (y.GetType() == typeof(DirectoryInfo))//if its directory then creating new layer of directory and pushing it into stack
                        {
                            DirectoryInfo d = history.Peek().Items[x] as DirectoryInfo;
                            history.Push(new layer(d));
                        }
                        else//if its file we will draw content of file
                        {
                            FileInfo f = history.Peek().Items[x] as FileInfo;
                            history.Peek().filecontent = history.Peek().openingFile(f);
                            Case = Mode.FILE;
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (Case == Mode.DIR) // if its directory then we will return previous layer of stack
                        {
                            if (history.Count() > 1)
                            {
                                history.Pop();
                            }
                        } // if its file then it will return the last alyer of stack
                        else
                        {
                            //history.Peek().filecontent = "";
                            Case = Mode.DIR; // switching directoalsdkfjgba;sldkfqowrua;slkdfjz.n.vn;alksfgqrodlkafksfjxzry mode 
                        }
                        break;
                    case ConsoleKey.Delete: // command for deleting
                        int n = history.Peek().SelectedItem;
                        FileSystemInfo fi = history.Peek().Items[n];
                        history.Peek().delete(fi);
                        break;
                    case ConsoleKey.F2: // console key for renaming
                        history.Peek().rename(history.Peek().Items[history.Peek().SelectedItem]);
                        break;
                    case ConsoleKey.Escape: // the end
                        quit = true;
                        break;
                }
            }
        }
    }
}
