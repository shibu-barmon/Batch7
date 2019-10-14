using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_11
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator refrigerator = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            refrigerator.Weight= Convert.ToDouble(weightTextBox.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string message = refrigerator.FindWeight(Convert.ToDouble(itemsTextBox.Text),Convert.ToDouble(weightKgTextBox.Text));
            currentWeightTextBox.Text = refrigerator.CurrentWeight.ToString();
            remainingWeightTextBox.Text = refrigerator.RemaininWeight.ToString();

            
            MessageBox.Show(message);

        }
    }
}
