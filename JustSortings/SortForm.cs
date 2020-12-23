using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustSortings
{
    public partial class SortForm : Form, ISortsView
    {
        public SortForm()
        {
            InitializeComponent();
            _sortsPresenter = new SortsPresenter(this, new SortsModel());
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
            if (QuickSortRadioButton.Checked)
            {
                _sortsPresenter.SortNumbers("Quick");
            }
            if (SelectionSortRadioButton.Checked)
            {
                _sortsPresenter.SortNumbers("Selection");
            }
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

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SortForm_Load(object sender, EventArgs e)
        {

        }
    }
}
