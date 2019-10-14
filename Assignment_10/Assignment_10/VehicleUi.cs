using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_10
{
    public partial class VehicleUi : Form
    {
        Vehicle vehicle = new Vehicle();
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            vehicle.VehilcleName = nameTextBox.Text;
            vehicle.Reg_No = regTextBox.Text;
            nameTextBox.Clear();
            regTextBox.Clear();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            vehicle.AddSpeed(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
          //  vehicle.FindSpeed();
            minTextBox.Text = vehicle.min.ToString();
            maxTextBox.Text = vehicle.max.ToString();
            averageTextBox.Text = vehicle.avg.ToString();
        }
    }
}
