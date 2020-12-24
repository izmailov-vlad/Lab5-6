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
    
    public partial class GenerationForm : Form, IGenerationView
    {
        public GenerationForm(SortForm sortForm)
        {
            _sortForm = sortForm;
            _generationPresenter = new GenerationPresenter(this, new GenerationModel());
            InitializeComponent();
        }

        public void CloseView()
        {
            this.Close();
        }

        public void GenerateNewNumbers()
        {
            throw new NotImplementedException();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            try
            {
                _generationPresenter.SetNewNumbersParams(
                    Convert.ToInt32(CountOfElementsTextBox.Text),
                    Convert.ToInt32(MinElementTextBox.Text),
                    Convert.ToInt32(MaxElementTextBox.Text),
                    _sortForm
                    );
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Error. Try again");
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
