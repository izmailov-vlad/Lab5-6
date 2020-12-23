using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    interface IGenerationModel
    {
        void SetNewNumbersParams(int count, int start, int end, SortForm sortForm);
    }
}
