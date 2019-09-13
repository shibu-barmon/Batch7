using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (itemcomboBox.Text == "")
            {
                MessageBox.Show("select item");
            }
            else
            {
                MessageBox.Show(itemcomboBox.Text+" is selected");
            }
        }
    }
}
