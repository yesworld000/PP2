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
            //showing full name of first and second file
        string FilePath = @"C:\Users\Lenovo\Documents\pp2\Week 2\Task 4\Path\output1.txt";
        string FilePath1 = @"C:\Users\Lenovo\Documents\pp2\Week 2\Task 4\Path1\output2.txt";

        StreamWriter sw = new StreamWriter(FilePath);
        sw.Close();

            //copying file from path to path1
        File.Copy(FilePath, FilePath1);

            //deleting file from first path
        File.Delete(FilePath);
        
    }
    }
}