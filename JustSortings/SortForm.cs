using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace JustSortings
{
    public partial class SortForm : Form, ISortsView
    {
        public SortForm()
        {
            InitializeComponent();
            _sortsPresenter = new SortsPresenter(this, new SortsModel());
            uploadToolTip = new ToolTip();
            workTime.Visible = false;
            uploadToolTip.SetToolTip(UploadButton, "Upload numbers in file");
        }  

        public void ShowNumbers(int []numbers)
        {
            SortedNumbersTextBox.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                SortedNumbersTextBox.Text += Convert.ToString(numbers[i]) + "\n";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            

            if (QuickSortRadioButton.Checked)
            {
                _sortsPresenter.SortNumbers("Quick");
            }
            if (SelectionSortRadioButton.Checked)
            {
                _sortsPresenter.SortNumbers("Selection");
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format(
                "{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            workTime.Text = "Время работы: " + elapsedTime;
            workTime.Visible = true;
       

            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            _sortsPresenter.LoadNumbers();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GenerationForm generationForm = new GenerationForm(this);
            generationForm.ShowDialog();
        }

        public SortsPresenter GetSortsPresenter()
        {
            return _sortsPresenter;
        }

        public ISortsModel GetSortsModel()
        {
            return _sortsPresenter.GetSortsModel();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SortForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            _sortsPresenter.UploadFile();
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
