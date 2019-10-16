using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }
        Refrigerator aRefrigerator=new Refrigerator();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator.AddWeight(Convert.ToDouble(maxWeightTakeTextBox.Text));
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            aRefrigerator.AddItemunit(Convert.ToDouble(itemTextBox.Text),Convert.ToDouble(weightTextBox.Text));
            if (aRefrigerator.Validation())
            {
                currentWeightTextBox.Text = aRefrigerator.CurrentWeight().ToString();
                remainingWeightTextBox.Text = aRefrigerator.RemainingWeight().ToString();
            }
            else
            {
                MessageBox.Show("maximun weight limit excedd");
            }
        }
    }
}
