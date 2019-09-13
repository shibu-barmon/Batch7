using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform
{
    public partial class Personal_Information : Form
    {
        public Personal_Information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello !" + nameTextbox1.Text + "\r\n" + nameTextbox2.Text + "\r\n" + nameTextbox3.Text + "\r\n" + nameTextbox4.Text);
            showinformation.Text = nameTextbox1.Text+"\r\n"+nameTextbox2.Text +"\r\n"+ nameTextbox3.Text +"\r\n"+ nameTextbox4.Text;


        }
    }
}
