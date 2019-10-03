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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void customerShowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                //Execute
                SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    customerShowDataGridView.DataSource = dataTable;
                }
                else
                    MessageBox.Show("Data not found");

           
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);
                //Command
                string commandString = @"DELETE FROM Customers WHERE CustomerName = '" + customerNametextbox.Text + "' OR CustomerId = '" + customerIdtextbox.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                //Execute
                SqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Deleted successfully.");
                }
                else
                    MessageBox.Show("Not deleted");

              
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE Customers SET CustomerName = '" + customerNametextbox.Text + "', Address = '" + addresstextbox.Text + "' , Contact = '" + contacttextbox.Text + "' WHERE CustomerId = '" + customerIdtextbox.Text + "' OR CustomerName = '" + customerNametextbox.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                //Execute
                SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                customerShowDataGridView.DataSource = dataTable;

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Updated successfully.");
                }
                else
                    MessageBox.Show("Not updated");

                
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void customerSearchBtn_Click(object sender, EventArgs e)
        {
             try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Customers WHERE CustomerName = '" + customerNametextbox.Text + "' OR CustomerId = '" + customerIdtextbox.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                //Execute
                SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    customerShowDataGridView.DataSource = dataTable;
                }
                else
                    MessageBox.Show("Data not found");

              
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            private bool customerAdd(string CustomerName,int Contact, string Address)
            {
                bool isAdded false;
                try
                {
                    //Connection
                    string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                    SqlConnection SqlConnection = new SqlConnection(connectionString);

                    //Command
                    string commandString = @"INSERT INTO Customers(CustomerName, Contact, Address) VALUES ('" + CustomerName+ "', '" + Contact + "', '" + Address + "')";
                    SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                    //Execute
                    SqlConnection.Open();

                    int isExecuted = sqlCommand.ExecuteNonQuery();
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Inserted successfully.");
                    }
                    else
                        MessageBox.Show("Not inserted");


                    SqlConnection.Close();
                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
