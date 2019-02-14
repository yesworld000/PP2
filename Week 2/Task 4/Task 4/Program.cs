using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //showing full name of first file
            string pathString = @"C:\Users\Lenovo\Documents\pp2\Week 2\Task 4\Path";

            //giving name to file
            string fileName = "file1.txt";

            //uniting path with file's name
            pathString = System.IO.Path.Combine(pathString, fileName);

            //creating new file "file1" if there is no any other file
            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString)) ;
            }

            //showing way to the file which is gonna be copy of "file1"
            string FilePath1 = @"C:\Users\Lenovo\Documents\pp2\Week 2\Task 4\Path1\copy.txt";

            //copying file from path to path1
            File.Copy(pathString, FilePath1);

            //deleting file from first path
            File.Delete(pathString);
        
    }
    }
}