using System;
using System.IO;

namespace JustSortings
{
    class FileParser
    {
        public int[] ParseFromFile()
        {
            int[] numbers = new int[500];

            string path = System.Environment.CurrentDirectory + @"\\Numbers.txt";

            StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            
            string line;
            int index = 0;
            while ((line = sr.ReadLine()) != null)
            {
                //Перезапись в новый массив если послед. длинне  выделенной памяти
                if (index >= numbers.Length)
                {
                    int[] new_numbers = new int[numbers.Length * 2];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        new_numbers[i] = numbers[i];
                    }
                    numbers = new_numbers;
                }
                numbers[index++] = Convert.ToInt32(line);
            }

            //Перезапись в отформатированном виде (убераем нули, если массив не полностью заполнен)ы
            int[] correct_numbers = new int[index];
            for (int i = 0; i < index; i++)
            {
                correct_numbers[i] = numbers[i];
            }

            sr.Close();
              


            return correct_numbers;
        }

        public void UploadInFile(int[] numbers)
        {
            string path = System.Environment.CurrentDirectory + @"\\Output.txt";
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                   sw.WriteLine(numbers[i] + "\n");
                }
            }
        }
    }
}
