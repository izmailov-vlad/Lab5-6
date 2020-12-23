using System;
using System.IO;

namespace JustSortings
{
    class FileParser
    {
        public int[] ParseFromFile()
        {
            int[] numbers = new int[21];
            string path = @"C:\Users\User\source\repos\JustSortings\Numbers.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int index = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    numbers[index++] = Convert.ToInt32(line);
                }
            }


            return numbers;
        }
    }
}
