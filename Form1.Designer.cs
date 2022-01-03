
namespace Rocks.Test._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toSortNumber = new System.Windows.Forms.TextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.bubbleSortRdBox = new System.Windows.Forms.RadioButton();
            this.quickSortRdBox = new System.Windows.Forms.RadioButton();
            this.sortedTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toSortNumber
            // 
            this.toSortNumber.Location = new System.Drawing.Point(72, 66);
            this.toSortNumber.Name = "toSortNumber";
            this.toSortNumber.Size = new System.Drawing.Size(292, 23);
            this.toSortNumber.TabIndex = 0;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(152, 266);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 1;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // bubbleSortRdBox
            // 
            this.bubbleSortRdBox.AutoSize = true;
            this.bubbleSortRdBox.Location = new System.Drawing.Point(490, 66);
            this.bubbleSortRdBox.Name = "bubbleSortRdBox";
            this.bubbleSortRdBox.Size = new System.Drawing.Size(86, 19);
            this.bubbleSortRdBox.TabIndex = 4;
            this.bubbleSortRdBox.TabStop = true;
            this.bubbleSortRdBox.Text = "Bubble Sort";
            this.bubbleSortRdBox.UseVisualStyleBackColor = true;
            // 
            // quickSortRdBox
            // 
            this.quickSortRdBox.AutoSize = true;
            this.quickSortRdBox.Location = new System.Drawing.Point(490, 122);
            this.quickSortRdBox.Name = "quickSortRdBox";
            this.quickSortRdBox.Size = new System.Drawing.Size(80, 19);
            this.quickSortRdBox.TabIndex = 5;
            this.quickSortRdBox.TabStop = true;
            this.quickSortRdBox.Text = "Quick Sort";
            this.quickSortRdBox.UseVisualStyleBackColor = true;
            // 
            // sortedTxtBox
            // 
            this.sortedTxtBox.Location = new System.Drawing.Point(72, 150);
            this.sortedTxtBox.Name = "sortedTxtBox";
            this.sortedTxtBox.Size = new System.Drawing.Size(292, 23);
            this.sortedTxtBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortedTxtBox);
            this.Controls.Add(this.quickSortRdBox);
            this.Controls.Add(this.bubbleSortRdBox);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.toSortNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toSortNumber;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.RadioButton bubbleSortRdBox;
        private System.Windows.Forms.RadioButton quickSortRdBox;
        private System.Windows.Forms.TextBox sortedTxtBox;
    }
}

