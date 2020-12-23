using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    public struct ParamsOfSequence
    {
        public int count;
        public int start;
        public int end;
    }
    class GenerationModel : IGenerationModel
    {
      

        public void SetNewNumbersParams(int count, int start, int end, SortForm sortForm)
        {
            _paramsOfSequence.count = count;
            _paramsOfSequence.start = start;
            _paramsOfSequence.end = end;

            sortForm.GetSortsPresenter().SetParamsOfSequence(_paramsOfSequence);
        }

        public ParamsOfSequence GetParams()
        {
            return _paramsOfSequence;
        }

        private ParamsOfSequence _paramsOfSequence;
     
    }
}
