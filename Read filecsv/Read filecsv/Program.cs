using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_filecsv
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"D:\Dowload\test.csv"))
            {
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\n');

                    Console.WriteLine(line);
                }
                

            }
            Console.ReadKey();
        }
    }
}
