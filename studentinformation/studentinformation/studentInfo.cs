using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentinformation
{
    public partial class studentInfo : Form
    {

        List<string> ids = new List<string> { };
        List<string> names = new List<string> { };
        List<string> mobiles = new List<string> { };
        List<int> ages = new List<int> { };
        List<string> addresses = new List<string> { };
        List<double> cgpa = new List<double> { };

        public studentInfo()
        {
            InitializeComponent();
        }



        private void idtextBox_TextChanged(object sender, EventArgs e)
        {
            idtextBox.MaxLength = 4;
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {
            nametextBox.MaxLength = 30;
        }

        private void mobiletextBox_TextChanged(object sender, EventArgs e)
        {
            mobiletextBox.MaxLength = 11;
        }

        private void gpatextBox_TextChanged(object sender, EventArgs e)
        {
            gpatextBox.MaxLength = 4;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (idtextBox.Text == "" || nametextBox.Text == "" || mobiletextBox.Text == "")
            {
                MessageBox.Show("Please Enter ID name and number first");
            }
            else
            {
                if (idtextBox.Text.Length < 4)
                {
                    MessageBox.Show("Minimum 4 digi number");
                }


                else
                {
                    if (nametextBox.Text.Length > 30)
                    {
                        MessageBox.Show("Enter  Your name maximum 30 digits");
                    }


                    else
                    {
                        if (mobiletextBox.Text.Length < 11)
                        {
                            MessageBox.Show("Enter your phone 11 digit number");
                        }
                        else
                        {
                            if (agetextBox.Text == "")
                            {
                                MessageBox.Show("please enter your age");
                            }

                            else
                            {
                                int i;
                                if (!int.TryParse(agetextBox.Text, out i))
                                {
                                    MessageBox.Show("enter only number");
                                    return;
                                }
                            }
                            if (gpatextBox.Text == "")
                            {
                                MessageBox.Show("enter your gpa");
                            }
                            else
                            {
                                int q;
                                if (!int.TryParse(gpatextBox.Text, out q))
                                {
                                    MessageBox.Show("Enter Your gpa");
                                    return;
                                }
                                else
                                {
                                    foreach (string id in ids)
                                    {
                                        if (id == idtextBox.Text)
                                        {
                                            MessageBox.Show("please enter number");
                                            return;
                                        }
                                    }

                                    foreach (string mobile in mobiles)
                                    {
                                        if (mobile == mobiletextBox.Text)
                                        {
                                            MessageBox.Show("please enter contact number");
                                            return;
                                        }
                                    }
                                    Addstudent(idtextBox.Text, nametextBox.Text, mobiletextBox.Text, Convert.ToInt32(agetextBox.Text), addresstextBox.Text, Convert.ToInt32(gpatextBox.Text));
                                    MessageBox.Show("Data saved successfully");
                                    viewcurrentstudent(idtextBox.Text, nametextBox.Text, mobiletextBox.Text, Convert.ToInt32(agetextBox.Text), addresstextBox.Text, Convert.ToInt32(gpatextBox.Text));

                                }
                            }
                        }
                    }
                }
            }
        }





        private void Addstudent(string id, string name, string mobile, int age, string address, double gpa)
        {
            ids.Add(id);
            names.Add(name);
            mobiles.Add(mobile);
            ages.Add(age);
            addresses.Add(address);
            cgpa.Add(gpa);
        }
        private void viewcurrentstudent(string id, string name, string mobile, int age, string address, double gpa)
        {
            string message;
            message = "ID:\t" + id + "\nName:\t" + name + "\nmobile:\t" + mobile + "\nAge:\t" + age + "\naddress:\t" + address + "\nGPA Point:\t" + gpa;
            showrichTextBox.Text = message;
        }
        private void CaculatTotalGpa()
        {
            double counter = 0;
            double sum = 0;
            double ans = 0;
            for (int i = 0; i < cgpa.Count; i++)
            {
                sum += cgpa[i];
                counter++;
            }
            ans = sum / counter;
            avergetextBox.Text = ans.ToString();
            TotaltextBox.Text = sum.ToString();
        }
        private void MaxGpa()
        {
            double maxValue = cgpa.Max();
            int index = cgpa.IndexOf(maxValue);
            double minValue = cgpa.Min();
            int index1 = cgpa.IndexOf(minValue);

            maxnametextBox.AppendText(names[index]);
            minnametextBox.AppendText(names[index]);
            maxtextBox.Text = maxValue.ToString();
            mintextBox.Text = minValue.ToString();

        }

        private void show()

        {

            string message = "";
            for (int i = 0; i < ids.Count(); i++)
            {
                message = "ID:\t" + ids[i] + "\nName:\t" + names[i] + "\nmobile:\t" + mobiles[i] + "\nAge:\t" + ages[i] + "\naddress:\t" + addresses[i] + "\nGPA Point:\t" + cgpa[i] + "\n------------------\n";
            }
            showrichTextBox.Text += message;
        }

        private void showbutton_Click_1(object sender, EventArgs e)
        {
            showrichTextBox.Text = "";
            string message = "";
            for (int i = 0; i < ids.Count(); i++)
            {
                message = "ID:\t" + ids[i] + "\nName:\t" + names[i] + "\nmobile:\t" + mobiles[i] + "\nAge:\t" + ages[i] + "\naddress:\t" + addresses[i] + "\nGPA Point:\t" + cgpa[i] + "\n------------------\n";
            }
            showrichTextBox.Text += message;
            CaculatTotalGpa();
            MaxGpa();
        }

        private void searchbutton_Click_1(object sender, EventArgs e)
        {
            showrichTextBox.Text = "";
            if (idradioButton.Checked == true)
            {
                string message = "";
                if (ids.Contains(idtextBox.Text))
                {
                    int index = ids.IndexOf(idtextBox.Text);
                    message += "Id:\t" + ids[index] + "\nName:\t" + names[index] + "\nMobile:\t" + mobiles[index] + "\naddress:\t" + addresses[index] + "\nGPA:\t" + cgpa[index] + "\n-----------------------------\n";
                    showrichTextBox.Text += message;
                }
                else
                {
                    MessageBox.Show("no data found");
                }
            }
            if (nameradioButton.Checked == true)
            {
                string message = "";
                if (names.Contains(nametextBox.Text))
                {
                    int index = names.IndexOf(nametextBox.Text);
                    message += "Id:\t" + ids[index] + "\nName:\t" + names[index] + "\nMobile:\t" + mobiles[index] + "\naddress:\t" + addresses[index] + "\nGPA:\t" + cgpa[index] + "\n-----------------------------\n";
                    showrichTextBox.Text += message;
                }
                else
                {
                    MessageBox.Show("no data found");
                }


            }

            if (mobileradioButton.Checked == true)
            {
                string message = "";
                if (mobiles.Contains(mobiletextBox.Text))
                {
                    int index = mobiles.IndexOf(mobiletextBox.Text);
                    message += "Id:\t" + ids[index] + "\nName:\t" + names[index] + "\nMobile:\t" + mobiles[index] + "\naddress:\t" + addresses[index] + "\nGPA:\t" + cgpa[index] + "\n-----------------------------\n";
                    showrichTextBox.Text += message;
                }
                else
                {
                    MessageBox.Show("no data found");
                }


            }
        }
    }
}