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
        int index = 0;
        public coffeshop()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string[] name = new string[100];
            string[] number = new string[50];
            string[] address = new string[100];
            string[] order = new string[20];
            int[] quantity = new int[50];
            int[] perorderprice = new int[50];
            int[] totalbill = new int[50];

            name[index] = nametextbox.Text;
            number[index] = Contacttextbox.Text;
            address[index] = Addressbox.Text;
            quantity[index] = Convert.ToInt32(quantbox.Text);
            perorderprice[index] = Convert.ToInt32(perorderpriceTextbox.Text);
            order[index] = (orderbox.Text);


            if (nametextbox.Text == null || Contacttextbox.Text == null || Addressbox.Text == null ||
               quantbox.Text == null || perorderpriceTextbox.Text == null)
            {
                MessageBox.Show("You cannot keep it blank.");
            }
            else
            {
                MessageBox.Show("Sucessfully inserted an order.");
            }

            if (orderbox.Text == null)
            {
                MessageBox.Show("Selct item.");
            }
            else if (orderbox.Text == "Black")
            {
                totalbill[index] = quantity[index] * perorderprice[index];
                showrichtextbox.Text += "Customer Name: " + name[index] + "\n" + "Contact No.: " + number[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + order[index] + "\n" + "Quantity: " + quantity[index] +
                    "\n" + "Price Per " + order[index] + ": " + perorderprice[index] + "\n" + "Total Price: " + totalbill[index] + "\n" + "\n";
            }
            else if (orderbox.Text == "Cold")
            {
                totalbill[index] = quantity[index] * perorderprice[index];
                showrichtextbox.Text += "Customer Name: " + name[index] + "\n" + "Contact No.: " + number[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + order[index] + "\n" + "Quantity: " + quantity[index] +
                    "\n" + "Price Per " + order[index] + ": " + perorderprice[index] + "\n" + "Total Price: " + totalbill[index] + "\n" + "\n";

            }
            else if (orderbox.Text == "Hot")
            {

                totalbill[index] = quantity[index] * perorderprice[index];
                showrichtextbox.Text += "Customer Name: " + name[index] + "\n" + "Contact No.: " + number[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + order[index] + "\n" + "Quantity: " + quantity[index] +
                    "\n" + "Price Per " + order[index] + ": " + perorderprice[index] + "\n" + "Total Price: " + totalbill[index] + "\n" + "\n";

            }
            else if (orderbox.Text == "Regular")
            {
                totalbill[index] = quantity[index] * perorderprice[index];
                showrichtextbox.Text += "Customer Name: " + name[index] + "\n" + "Contact No.: " + number[index] + "\n" +
                    "Address: " + address[index] + "\n" + "Odered item: " + order[index] + "\n" + "Quantity: " + quantity[index] +
                    "\n" + "Price Per " + order[index] + ": " + perorderprice[index] + "\n" + "Total Price: " + totalbill[index] + "\n" + "\n";

            }
            index++;

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

        private void coffeshop_Load(object sender, EventArgs e)
        {

        }
    }
}
