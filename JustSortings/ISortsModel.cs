using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    public interface ISortsModel
    {

        int[] GetNumbers();
        void UploadFile();
        int[] LoadNumbers();

        int[] QuickSort();

        void SetParamsOfSequence(ParamsOfSequence paramsOfSequence);

        int[] SelectionSort();

        void GenerateNewNumbers();
    }
}
