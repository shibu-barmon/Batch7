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
       
        private void Display()
        {
            try
            {
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                string CommandString = @"SELECT * FROM items";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);


                sqlConnection.Open();

                //show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showdataGridView.DataSource = dataTable;
                }
                else
                {

                    MessageBox.Show("No Data Found!");



                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private bool Delete(int itemID)
        {
            try
            {
                //Connection
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //command
                string CommandString = @"DELETE FROM items WHERE itemID="+itemID +"";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

                sqlConnection.Open();


                //Delete
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return false;
        }
        private bool Update(int itemID, string itemName,double itemPrice)
        {
            try
            {
                //Connection
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //command
                string CommandString = @"UPDATE items SET itemName='" + itemName + "',itemPrice=" + itemPrice + " WHERE itemID=" + itemID + "";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

                sqlConnection.Open();

                //update
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }

                sqlConnection.Close();

            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return false;
        }
        private void Search(string itemName)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM items WHERE itemName='" + itemName + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show or search
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showdataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No Data Found");
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

        }

    }
}
