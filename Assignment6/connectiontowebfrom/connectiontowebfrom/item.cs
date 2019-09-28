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

namespace connectiontowebfrom
{
    public partial class item : Form
    {
        public item()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {//Connection
            try
            {
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //command
                string CommandString = @"INSERT INTO items(itemName,itemPrice)VALUES('" + itemnametextBox.Text + "'," + itempricetextBox.Text + ");";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Data saved successfully");

                }
                else
                {
                    MessageBox.Show("Not inserted");
                    itemIDtextBox.Text = "";
                    itemnametextBox.Text = "";
                    itempricetextBox.Text = "";

                    sqlConnection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            try { 
            string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            string CommandString = @"SELECT * FROM items";
            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);


            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showdataGridView.DataSource = dataTable;
                }
                else
                {
                    showdataGridView.DataSource = null;
                    MessageBox.Show("No Data Found!");
                    itemIDtextBox.Text = "";
                    itemnametextBox.Text = "";
                    itempricetextBox.Text = "";
                    sqlConnection.Close();

                }
            }
                catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //command
                string CommandString = @"DELETE FROM items WHERE itemID=" + itemIDtextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Deleted successfully.");
                }
                else
                    MessageBox.Show("Not deleted");
                itemIDtextBox.Text = "";
                itemnametextBox.Text = "";
                itempricetextBox.Text = "";
                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //command
                string CommandString = @"UPDATE items SET itemName='" + itemnametextBox.Text + "',itemPrice=" + itempricetextBox.Text + " WHERE itemID=" + itemIDtextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                showdataGridView.DataSource = dataTable;
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Updated successfully.");
                }
                else
                    MessageBox.Show("Not updated");
                itemIDtextBox.Text = "";
                itemnametextBox.Text = "";
                itempricetextBox.Text = "";
                sqlConnection.Close();
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                string CommandString = @"SELECT * FROM items WHERE itemName='"+itemIDtextBox.Text+"'OR itemID="+itemIDtextBox.Text+";";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);


                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    showdataGridView.DataSource = dataTable;
                }
                else
                {
                    showdataGridView.DataSource = null;
                    MessageBox.Show("No Data Found!");
                    itemIDtextBox.Text = "";
                    itemnametextBox.Text = "";
                    itempricetextBox.Text = "";
                    sqlConnection.Close();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
