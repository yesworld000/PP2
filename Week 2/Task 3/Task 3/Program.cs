using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        //creating a function which adds spaces between levels
        static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
                Console.Write("  ");
        }

        static void Damir(DirectoryInfo directory, int level)
        {
            //getting info about files and directories
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                //writing spaces between levels
                PrintSpaces(level);

                //writing names of files
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)
            {
                //writing spaces between levels
                PrintSpaces(level);

                //writing names of directories
                Console.WriteLine(d.Name);

                //adding one to level when there is new directory
                Damir(d, level + 1);
            }
        }
        static void Main(string[] args)
        {
            //showing directory of a folder
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Lenovo\Documents\My Games");

            //calling function which is called Damir
            Damir(d, 0);
        }
    }
}
