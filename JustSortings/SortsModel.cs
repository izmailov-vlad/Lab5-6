using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    class SortsModel : ISortsModel
    {
        
        public int[] LoadNumbers()
        {
            FileParser parser = new FileParser();
            numbers = parser.ParseFromFile();
            return numbers;
        }

        public int[] GetNumbers()
        {
            return numbers;
        }

        public void SetParamsOfSequence(ParamsOfSequence paramsOfSequence) 
        {
            _paramsOfSequence = paramsOfSequence;
        }

        public void GenerateNewNumbers()
        { 
            int count = _paramsOfSequence.count;
            int start = _paramsOfSequence.start;
            int end = _paramsOfSequence.end;

            Random rand = new Random();
            int[] new_numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                new_numbers[i] = rand.Next(start, end);
            }
            numbers = new_numbers;
        }

        public int[] QuickSort()
        {
            QuickSort sort = new QuickSort();
            sort.Sort(ref numbers, 0, numbers.Length - 1);
            return numbers;
        }

        public int[] SelectionSort()
        {
            SelectionSort sort = new SelectionSort();
            sort.Sort(ref numbers);
            return numbers;
        }

        private int[] numbers;
        private ParamsOfSequence _paramsOfSequence;
    }
}
