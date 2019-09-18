using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class coffeshop : Form
    {
        List<string>names = new List<string>{ };
        List<string>contacts = new List<string>{ };
        List<string>addresses = new List<string>{ };
        List<string>orders = new List<string>{ };
        List<int>quantities = new List<int>{ };
        List<int>prices = new List<int>{ };

        int price = 0;
        public coffeshop()
        {
            InitializeComponent();
        }

        private void coffeshop_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text==" " || contactTextBox.Text=="" || AddressTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Your Information");
            }

            else  if (ordercomobox.Text == "select item")
            {
                MessageBox.Show("selected item");
            }

            else if (quntityTextBox.Text == " ")
            {
                MessageBox.Show("Please Enter quantity of coffe");
            }
            else
            {
                foreach(string contact in contacts)
                {
                    if (contact ==contactTextBox.Text)
                    {
                        MessageBox.Show("Please enter number should be unique");
                        return;
                    }
                }
                switch(ordercomobox.Text)
                {
                    case "Black-120":
                    price = 120;
                    break;

                    case "Cold-100":
                    price = 100;
                    break;

                    case "Hot-90":
                    price = 90;
                    break;

                    case "Regular-80":
                    price = 80;
                    break;
                }
                price = Convert.ToInt32(quntityTextBox.Text) * price;
                Addcustomer(nameTextBox.Text, contactTextBox.Text, AddressTextBox.Text, ordercomobox.Text, Convert.ToInt32(quntityTextBox.Text), price);
                ViewCurrentOrder(nameTextBox.Text, contactTextBox.Text, AddressTextBox.Text, ordercomobox.Text, Convert.ToInt32(quntityTextBox.Text), price);
                price = 0;


            }
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            CustomerPurchaseList();
        }
        private void Addcustomer(string name, string mobile, string address, string order, int quantity, int price)
        {
            names.Add(name);
            contacts.Add(mobile);
            addresses.Add(address);
            orders.Add(order);
            quantities.Add(quantity);
            prices.Add(price);
        }
        private void ViewCurrentOrder(string name, string mobile, string address, string order, int quantity, int price)
        {
            showRichTextBox.Text = "name:\t" + name + "\nMobile:\t" + mobile + "\nAddress:\t" + address + "\nOrder;\t" + order + "\nQuantity:\t" + quantity + "\nPrice:\t" + price + "\n----------------------------------\n";
            nameTextBox.Text = "";
            contactTextBox.Text = "";
            AddressTextBox.Text = "";
            ordercomobox.Text = "";
            quntityTextBox.Text = "";
        }
        private void CustomerPurchaseList()
        {
            showRichTextBox.Text = "";
            string message = "";
            for (int i = 0; i < names.Count(); i++)
            {
                message += "name:\t" + names[i] + "\nMobile:\t" + contacts[i] + "\nAddress:\t" + addresses[i] + "\nOrder;\t" + orders[i] + "\nQuantity:\t" + quantities[i] + "\nPrice:\t" + prices[i] + "\n-------------------------------\n";
            }
            showRichTextBox.Text += message;
        }

    }
}