using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace connectiontowebfrom.Repository
{
    public class itemRepository
    {
        public bool Add(string itemName, double itemPrice)

        {
            bool isAdded = false;
            //Connection
            try
            {
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //command
                string CommandString = @"INSERT INTO items(itemName,itemPrice)VALUES('" + itemName + "'," + itemPrice + ");";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }
                //if (isExecuted > 0)
                //{
                //    MessageBox.Show("Data saved successfully");

                //}
                //else
                //{
                //    MessageBox.Show("Not inserted");

                //}
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }

            return isAdded;
        }
        public bool IsNameExist(string itemName)
        {
            bool isExist = false;
            try
            {
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                string CommandString = @"SELECT * FROM items WHERE itemName='" + itemName 
+ "'";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);


                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
            return isExist;
        }
        public DataTable Display()
        {
        //    try
        //    {
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                string CommandString = @"SELECT * FROM items";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);


                sqlConnection.Open();

                //show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    showdataGridView.DataSource = dataTable;
                //}
                //else
                //{

                //  //  MessageBox.Show("No Data Found!");



                //}
                sqlConnection.Close();
            
            //catch (Exception exception)
            //{
            //  //  MessageBox.Show(exception.Message);
            //}
            return dataTable;
        }
        public bool Delete(int itemID)
        {
            try
            {
                //Connection
                string ConnectionString = @"Server=DESKTOP-R7PQERG\SQLEXPRESS;Database=coffeeshop;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //command
                string CommandString = @"DELETE FROM items WHERE itemID=" + itemID + "";
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
                //MessageBox.Show(exception.Message);
            }
            return false;
        }
        public bool Update(int itemID, string itemName, double itemPrice)
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
                //MessageBox.Show(exception.Message);
            }
            return false;
        }
        public DataTable Search(string itemName)
        {
            //try
            //{
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
                //if (dataTable.Rows.Count > 0)
                //{
                //    showdataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    //MessageBox.Show("No Data Found");
                //}

                //Close
                sqlConnection.Close();

                //}
                //catch (Exception exeption)
                //{
                //    //MessageBox.Show(exeption.Message);
                //}
                return dataTable;

            }
    }
}
