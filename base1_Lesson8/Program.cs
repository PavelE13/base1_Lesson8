using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace base1_Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Информация по дирректории: ");
            string pathD = "F:/Обучение 2035/ProjectC";
            string[] directory = Directory.GetDirectories(pathD);
            string[] files = Directory.GetFiles(pathD);
            Directory.SetCurrentDirectory(pathD);
            if (Directory.Exists(pathD))
            {
                foreach (string dir in directory)
                {
                    Console.WriteLine(dir);

                }
                foreach (string fil in files)
                {
                    Console.WriteLine(fil);

                }

            }
            else
            {
                Console.WriteLine(" Дирректория {0}: не существует", pathD);
            }
            Console.ReadKey();
        }
    }
}
