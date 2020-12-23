using System.Windows.Forms;
namespace JustSortings
{
    partial class SortForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
            Application.Exit();
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SortedNumbersTextBox = new System.Windows.Forms.RichTextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LoadNumbersButton = new System.Windows.Forms.Button();
            this.QuickSortRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SortedNumbersTextBox
            // 
            this.SortedNumbersTextBox.Location = new System.Drawing.Point(12, 86);
            this.SortedNumbersTextBox.Name = "SortedNumbersTextBox";
            this.SortedNumbersTextBox.Size = new System.Drawing.Size(780, 269);
            this.SortedNumbersTextBox.TabIndex = 0;
            this.SortedNumbersTextBox.Text = "";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(35, 378);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(180, 50);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сгенерировать новую последовательность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LoadNumbersButton
            // 
            this.LoadNumbersButton.Location = new System.Drawing.Point(593, 378);
            this.LoadNumbersButton.Name = "LoadNumbersButton";
            this.LoadNumbersButton.Size = new System.Drawing.Size(180, 50);
            this.LoadNumbersButton.TabIndex = 4;
            this.LoadNumbersButton.Text = "Загрузить числа";
            this.LoadNumbersButton.UseVisualStyleBackColor = true;
            this.LoadNumbersButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // QuickSortRadioButton
            // 
            this.QuickSortRadioButton.AutoSize = true;
            this.QuickSortRadioButton.Location = new System.Drawing.Point(12, 38);
            this.QuickSortRadioButton.Name = "QuickSortRadioButton";
            this.QuickSortRadioButton.Size = new System.Drawing.Size(72, 17);
            this.QuickSortRadioButton.TabIndex = 5;
            this.QuickSortRadioButton.TabStop = true;
            this.QuickSortRadioButton.Text = "QuickSort";
            this.QuickSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectionSortRadioButton
            // 
            this.SelectionSortRadioButton.AutoSize = true;
            this.SelectionSortRadioButton.Location = new System.Drawing.Point(103, 38);
            this.SelectionSortRadioButton.Name = "SelectionSortRadioButton";
            this.SelectionSortRadioButton.Size = new System.Drawing.Size(88, 17);
            this.SelectionSortRadioButton.TabIndex = 6;
            this.SelectionSortRadioButton.TabStop = true;
            this.SelectionSortRadioButton.Text = "SelectionSort";
            this.SelectionSortRadioButton.UseVisualStyleBackColor = true;
            this.SelectionSortRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectionSortRadioButton);
            this.Controls.Add(this.QuickSortRadioButton);
            this.Controls.Add(this.LoadNumbersButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SortedNumbersTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SortForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SortForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SortedNumbersTextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button button2;
        private SortsPresenter _sortsPresenter;
        private System.Windows.Forms.Button LoadNumbersButton;
        private System.Windows.Forms.RadioButton QuickSortRadioButton;
        private System.Windows.Forms.RadioButton SelectionSortRadioButton;
        
    }
}

