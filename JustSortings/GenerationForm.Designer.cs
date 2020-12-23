namespace JustSortings
{
    partial class GenerationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.MaxElementTextBox = new System.Windows.Forms.TextBox();
            this.MinElementTextBox = new System.Windows.Forms.TextBox();
            this.CountOfElementsTextBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество элементов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Максимальный элемент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Минимальный элемент";
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(140, 110);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 3;
            this.Apply.Text = "Принять";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // MaxElementTextBox
            // 
            this.MaxElementTextBox.Location = new System.Drawing.Point(331, 49);
            this.MaxElementTextBox.Name = "MaxElementTextBox";
            this.MaxElementTextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxElementTextBox.TabIndex = 4;
            // 
            // MinElementTextBox
            // 
            this.MinElementTextBox.Location = new System.Drawing.Point(175, 49);
            this.MinElementTextBox.Name = "MinElementTextBox";
            this.MinElementTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinElementTextBox.TabIndex = 5;
            // 
            // CountOfElementsTextBox
            // 
            this.CountOfElementsTextBox.Location = new System.Drawing.Point(24, 49);
            this.CountOfElementsTextBox.Name = "CountOfElementsTextBox";
            this.CountOfElementsTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountOfElementsTextBox.TabIndex = 6;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(245, 110);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // GenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 155);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CountOfElementsTextBox);
            this.Controls.Add(this.MinElementTextBox);
            this.Controls.Add(this.MaxElementTextBox);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenerationForm";
            this.Text = "GenerationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox MaxElementTextBox;
        private System.Windows.Forms.TextBox MinElementTextBox;
        private System.Windows.Forms.TextBox CountOfElementsTextBox;
        private System.Windows.Forms.Button Cancel;
        private SortForm _sortForm;
        private GenerationPresenter _generationPresenter;
    }
}