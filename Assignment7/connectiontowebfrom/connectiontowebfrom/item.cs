using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connectiontowebfrom.BLL;

namespace connectiontowebfrom
{
    public partial class item : Form
    {
        itemManager _itemManager = new itemManager();
        public item()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            //price is mandotory
            if (String.IsNullOrEmpty(itempricetextBox.Text)) 
            {
                MessageBox.Show("price can not be Empty");
                return;
            }
            if (_itemManager.IsNameExist(itemnametextBox.Text))
            {
                MessageBox.Show(itemnametextBox.Text+ " already exist!");
                return;
            }
           bool Added = _itemManager.Add(itemnametextBox.Text, Convert.ToDouble(itempricetextBox.Text));
                if (Added)
                {
                    MessageBox.Show("Data saved successfully");

                }
               else
                {
                    MessageBox.Show("Not inserted");

                }
            Display();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            Display();



        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            //price is mandotory
            if (String.IsNullOrEmpty(itemIDtextBox.Text))
            {
                MessageBox.Show("ID can not be Empty");
                return;
            }
            
            if(Delete(Convert.ToInt32(itemIDtextBox.Text)))
            {
                MessageBox.Show("Data Deleted successfully");

            }
            else
            {
                MessageBox.Show("Not Deleted");

            }
            Display();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            //id is mandotory
            if (String.IsNullOrEmpty(itemIDtextBox.Text))
            {
                MessageBox.Show("ID can not be Empty");
                return;
            }
            //price is mandotory
            if (String.IsNullOrEmpty(itempricetextBox.Text))
            {
                MessageBox.Show("price can not be Empty");
                return;
            }

            

            if (Update( Convert.ToInt32(itemIDtextBox.Text),itemnametextBox.Text,Convert.ToDouble(itempricetextBox.Text)))
            {
                MessageBox.Show("Data Updated successfully");
                Display();

            }
            else
            {
                MessageBox.Show("Not Updated");

            }
           
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            Search(itemnametextBox.Text);

        }
        //Method
       
      
     
        
       

    }
}
