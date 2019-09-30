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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }

        private void oderAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"INSERT INTO Orders(itemName, Quantity, TotalPrice, CustomerName) VALUES ('" + orderItemNameTextbox.Text + "', " + quantityTextbox.Text + ", " + totalPriceTextbox.Text + ", '" + OrderCustomerNameTextbox.Text + "')";
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

                orderIdTextbox.Text = "";
                orderItemNameTextbox.Text = "";
                quantityTextbox.Text = "";
                totalPriceTextbox.Text = "";
                OrderCustomerNameTextbox.Text = "";
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void oderShowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Orders";
                SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                //Execute
                SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    orderShowDataGridView.DataSource = dataTable;
                }
                else
                    MessageBox.Show("Data not found");

                orderIdTextbox.Text = "";
                orderItemNameTextbox.Text = "";
                quantityTextbox.Text = "";
                totalPriceTextbox.Text = "";
                OrderCustomerNameTextbox.Text = "";
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void oderDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"DELETE FROM Orders WHERE OrderId = '" + orderIdTextbox.Text + "' OR CustomerName = '" + orderItemNameTextbox.Text + "' ";
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

                orderIdTextbox.Text = "";
                orderItemNameTextbox.Text = "";
                quantityTextbox.Text = "";
                totalPriceTextbox.Text = "";
                OrderCustomerNameTextbox.Text = "";
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void oderUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"UPDATE Orders SET itemName = '" + orderItemNameTextbox.Text + "', Quantity = " + quantityTextbox.Text + " , TotalPrice = " + totalPriceTextbox.Text + " WHERE OrderId = " + orderIdTextbox.Text + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                //Execute
                SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                orderShowDataGridView.DataSource = dataTable;

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Updated successfully.");
                }
                else
                    MessageBox.Show("Not updated");
                orderIdTextbox.Text = "";
                orderItemNameTextbox.Text = "";
                quantityTextbox.Text = "";
                totalPriceTextbox.Text = "";
                OrderCustomerNameTextbox.Text = "";
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void oderSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection SqlConnection = new SqlConnection(connectionString);

                //Command
                string commandString = @"SELECT * FROM Orders WHERE CustomerName = '" + orderItemNameTextbox.Text + "' OR OrderId = '" + orderIdTextbox.Text + "' ";
                SqlCommand sqlCommand = new SqlCommand(commandString, SqlConnection);

                //Execute
                SqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    orderShowDataGridView.DataSource = dataTable;
                }
                else
                    MessageBox.Show("Data not found");

                orderIdTextbox.Text = "";
                orderItemNameTextbox.Text = "";
                quantityTextbox.Text = "";
                totalPriceTextbox.Text = "";
                OrderCustomerNameTextbox.Text = "";
                SqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
