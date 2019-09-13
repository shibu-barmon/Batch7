using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class coffeshop : Form
    {
        public coffeshop()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var name = nametextbox.Text;
            int number  = Convert.ToInt32(Contacttextbox.Text);
            var address = Addressbox.Text;
            var order = orderbox.Text;
            int quantity= Convert.ToInt32(quantbox.Text);
            int amount;
            if (order == "Black")
            {
                amount = 120;
            }
            else if (order == "Cold")
            {
                amount = 100;
            }
            else if (order == "Hot")
            {
                amount = 90;
            }
           
            else
            {
                amount = 80;
            }

            MessageBox.Show("Data Saved");
            showlabel14.Text = name;
            showlabel15.Text = number.ToString();
            showlabel16.Text = address;
            showlabel17.Text = order;
            showlabel18.Text = quantity.ToString();
            string result = Convert.ToString(quantity * amount);
            showlabel19.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showlabel16_Click(object sender, EventArgs e)
        {

        }
    }
}
