using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class Accountoperation : Form
    {
        public Accountoperation()
        {
            InitializeComponent();
        }
        Person aPerson = new Person();

        private void CreateButton_Click(object sender, EventArgs e)
        {
            aPerson.accountNumber = accountNoTextBox.Text;
            aPerson.customerName = customerNameTextBox.Text;
            aPerson.balance = 0;

            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }

        


        private void ReportButton_Click_1(object sender, EventArgs e)
        {
            string Message;
            Message = "Name: " + aPerson.customerName + "\n" + "Acount Number:" + aPerson.accountNumber + "\n" + "Balance:"+ aPerson.balance ;
            MessageBox.Show(Message);
        }

        private void DipositButton_Click_1(object sender, EventArgs e)
        {
            aPerson.Deposit(Convert.ToDouble(amountTextBox.Text));
        }

        private void WithdrawButton_Click_1(object sender, EventArgs e)
        {
            aPerson.Withdraw(Convert.ToDouble(amountTextBox.Text));
        }
    }
}
