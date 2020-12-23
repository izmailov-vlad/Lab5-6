using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    public class SortsPresenter
    {
        private readonly ISortsView view;
        private readonly ISortsModel model;

        public SortsPresenter(ISortsView view, ISortsModel model)
        {
            this.view = view;
            this.model = model;
        }


        public void LoadNumbers()
        {
            var numbers = model.LoadNumbers();
            view.ShowNumbers(numbers);
        }

        public void SortNumbers(string type)
        {
            if (String.Compare(type, "Quick") == 0)
            {
                model.QuickSort();
            }
            
            if (String.Compare(type, "Selection") == 0)
            {
                model.SelectionSort();
            }

            view.ShowNumbers(model.GetNumbers());
        }

        public void SetParamsOfSequence(ParamsOfSequence paramsOfSequence)
        {
            model.SetParamsOfSequence(paramsOfSequence);
            model.GenerateNewNumbers();
            view.ShowNumbers(model.GetNumbers());
        }
        
    }
}
