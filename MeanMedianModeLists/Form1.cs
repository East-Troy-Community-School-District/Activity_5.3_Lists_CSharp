/*
 * Mean Median Mode Lists
 * Pawelski
 * 11/13/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * What line creates the list called numbers? Why was
 * the list created as a global variable? What does the
 * following line of code do?
 * meanLabel.Text = Statistics.Mean(numbers).ToString();
 * 
 * Where are the Mean, Median, and Mode methods located? Why
 * might it be a good idea to structure the code like this?
 * How does this change the calls to the methods? How is a list
 * passed as an argument? Looking at the methods, how is this
 * code similar to the code we wrote to find the mean, median, and
 * mode of an array of doubles? How do GUI and CLI programs differ
 * when adding elements to a list? How are they similar?
 * 
 * What happens when you enter text for the number? Currently, this
 * program lacks error handling! Let's add a try-catch block so that
 * it detects any errors and prevents the program from craching
 * catastrophically.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeanMedianModeLists
{
    public partial class MeanMedianModeForm : Form
    {
        private List<double> numbers = new List<double>();
        
        public MeanMedianModeForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(numberTextBox.Text);
            numbers.Add(number);
            numberTextBox.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            meanLabel.Text = Statistics.Mean(numbers).ToString();
            medianLabel.Text = Statistics.Median(numbers).ToString();
            modeLabel.Text = Statistics.Mode(numbers).ToString();
        }
    }
}
