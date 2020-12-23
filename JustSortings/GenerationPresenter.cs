using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSortings
{
    class GenerationPresenter
    {
        private readonly IGenerationView view;
        private readonly IGenerationModel model;

        public GenerationPresenter(IGenerationView view, IGenerationModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void SetNewNumbersParams(int count, int start, int end, SortForm sortForm)
        {
            model.SetNewNumbersParams(count, start, end, sortForm);
            view.CloseView();
        }
    }
}
