using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarManager
{
    class Program
    {
        class FarManager
        {
            public int cursor;
            public string path;
            public int sz;
            public FileSystemInfo currentfs = null;
            public DirectoryInfo dir = null;
            public FarManager()
            {
                cursor = 0;
            }
            public FarManager(string path)
            {
                //making equal path to public string path
                this.path = path;
                cursor = 0;
                dir = new DirectoryInfo(path);

                //size is equal to amount of directories and files
                sz = dir.GetFileSystemInfos().Length;
            }

            //creating a function which takes 2 values
            public void Color(FileSystemInfo f, int index)
            {
                //changing color of the file which cursor shows
                if (cursor == index)
                {
                    currentfs = f;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    //if it is not current file keeping color of the background to black
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    //changing color to white if it is folder
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    //if it is not folder making it yellow
                    Console.ForegroundColor = ConsoleColor.Yellow;
            }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                dir = new DirectoryInfo(path);
                int ind = 1;

                //adding all elements from each folder
                FileSystemInfo[] fs = dir.GetFileSystemInfos();
                for (int i = 0; i < fs.Length; i++)
                {
                    //using "Color" function to change colors of every element
                    Color(fs[i], i);
                    Console.WriteLine(ind + "." + " " + fs[i]);
                    ind++;
                }
            }
            public void Up()
            {
                cursor--;

                //if we want to go upper than the 1st element going to the bottom
                if (cursor < 0)
                {
                    cursor = sz - 1;
                }
            }
            public void Down()//when we want to go under of the last element,it should go to the first
            {
                cursor++;

                //changing position to the top if there is no more elements in the bottom
                if (cursor == sz)
                {
                    cursor = 0;
                }
            }
            public void Start()
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();

                //program stops its work if we press esc
                while (keyinfo.Key != ConsoleKey.Escape)
                {
                    Show();
                    keyinfo = Console.ReadKey();

                    //going upper using Up()
                    if (keyinfo.Key == ConsoleKey.UpArrow)
                    {
                        Up();
                    }

                    //going lower by adding 1 to cursor
                    else if (keyinfo.Key == ConsoleKey.DownArrow)
                    {
                        Down();
                    }

                    //Enter to open files
                    if (keyinfo.Key == ConsoleKey.Enter)
                    {
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                         //if it is a folder we go into the directory
                            cursor = 0;
                            path = currentfs.FullName;
                        }

                        //if it is a txt file then opening it in the console
                        if (currentfs.GetType() == typeof(FileInfo))
                        {
                            cursor = 0;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;

                            //reading a text from the file
                            using (StreamReader sr = new StreamReader(currentfs.FullName))
                            {
                                //writing a text in the screen using the function ReadtoEnd
                                Console.WriteLine(sr.ReadToEnd());
                            }
                            Console.ReadKey();
                        }
                    }

                    //using "Delete" to delete files
                    if (keyinfo.Key == ConsoleKey.Delete)
                    {
                        cursor = 0;
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            //if it is empty folder then delete without asking
                            if (new DirectoryInfo(currentfs.FullName).GetFileSystemInfos().Length == 0)
                            {
                                Directory.Delete(currentfs.FullName);
                            }

                            //if there is any file or folder in directory we trying to delete then ask if a user is sure
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Are you sure?");

                                //delete if user presses "Y"
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Directory.Delete(currentfs.FullName, true);
                                }



                            }
                        }

                        //deleting file (not folder)
                        else if (currentfs.GetType() == typeof(FileInfo))
                        {
                            File.Delete(currentfs.FullName);
                        }
                    }

                    //using "Tab" to rename files
                    if (keyinfo.Key == ConsoleKey.Tab)
                    {
                        cursor = 0;
                        if (currentfs.GetType() == typeof(DirectoryInfo))
                        {
                            Console.Clear();

                            //new name that we wanna give to a file
                            string s = Console.ReadLine();

                            //name of a path
                            string Name = currentfs.Name;

                            //loaction of a directory
                            string fName = currentfs.FullName;
                            string newpath = "";
                            for (int i = 0; i < fName.Length - Name.Length; i++)
                            {
                                //the path that keeps keeps the location of a directory
                                newpath += fName[i];
                            }
                            newpath = newpath + s;

                            //changing the name
                            Directory.Move(fName, newpath);
                        }
                        else
                        {
                            Console.Clear();
                            string s = Console.ReadLine();
                            string Name = currentfs.Name;
                            string fName = currentfs.FullName;
                            string newpath = "";
                            for (int i = 0; i < fName.Length - Name.Length; i++)
                            {
                                newpath += fName[i];
                            }
                            newpath = newpath + s;
                            File.Move(fName, newpath);
                        }

                    }

                    //using "Backspace" to go backwards
                    if (keyinfo.Key == ConsoleKey.Backspace)
                    {
                        cursor = 0;
                        path = dir.Parent.FullName;
                    }

                }
            }

            static void Main(string[] args)
            {
                //showing the way of folders we are going to work by
                string path = @"C:\Users\Lenovo\Documents\My Games";
                FarManager fm = new FarManager(path);
                fm.Start();
            }
        }
    }
}