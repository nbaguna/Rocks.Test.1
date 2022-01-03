using Rocks.Test._1.Controller;
using Rocks.Test._1.Services;
using Rocks.Test._1.Specification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocks.Test._1
{
    public partial class Form1 : Form
    {
        private NumberSpecification numberSpecification;
        private SortingController sortingController;

        public Form1()
        {
            InitializeComponent();
            this.numberSpecification = new NumberSpecification();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            var number = this.toSortNumber.Text;
            if(this.numberSpecification.IsSatisfiedBy(number))
            {
                if(bubbleSortRdBox.Checked == true)
                {
                    this.sortingController = new SortingController(new BubbleSort());
                    sortedTxtBox.Text = new string(this.sortingController.NumberSortingController(number.ToCharArray()));
                }
                else if (quickSortRdBox.Checked == true)
                {
                    this.sortingController = new SortingController(new QuickSort());
                    sortedTxtBox.Text = new string(this.sortingController.NumberSortingController(number.ToCharArray()));
                }
                else
                {
                    MessageBox.Show("Please Select Sorting Type");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
