using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace base2_Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            string mypath = "MyFile/file6.txt";
            Random random = new Random();
            const int c10 = 10;
            int sum=0;
            StreamWriter saveNumber = new StreamWriter(mypath, false);
            int [] numberRand = new int[c10];
            int[] numbertoFile = new int[c10];
            if (!File.Exists(mypath))
            {
                File.Create(mypath);
            }
            for (int i = 0; i < c10; i++)
            {
                numberRand[i] = random.Next(20, 150);
                saveNumber.WriteLine(numberRand[i]);
                saveNumber.Flush();
            }
            saveNumber.Close(); 
            StreamReader readNumber = new StreamReader(mypath);
            for (int i = 0; i < c10; i++)
            {
                numbertoFile[i]= Convert.ToInt32(readNumber.ReadLine());
            }
            readNumber.Close();
            for (int i = 0; i < c10; i++)
            {
                sum +=numbertoFile[i];
            }
            Console.WriteLine(" Сумма в файле {0} = {1}",mypath,sum);
            Console.ReadKey();
        }
    }
}
