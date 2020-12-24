using System;
using System.Windows.Forms;
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

        public void UploadFile()
        {
            try
            {
                model.UploadFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Storage is empty");
            }

        }
        public void SortNumbers(string type)
        {
            try {
                if (String.Compare(type, "Quick") == 0)
                {
                    model.QuickSort();
                }

                else if (String.Compare(type, "Selection") == 0)
                {
                    model.SelectionSort();
                }
                

                view.ShowNumbers(model.GetNumbers());
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Nothing to sort");
            }
        }

        public ISortsModel GetSortsModel()
        {
            return model;
        }
        public void SetParamsOfSequence(ParamsOfSequence paramsOfSequence)
        {
            model.SetParamsOfSequence(paramsOfSequence);
            model.GenerateNewNumbers();
            view.ShowNumbers(model.GetNumbers());
        }
        
    }
}
