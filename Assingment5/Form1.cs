using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment5
{
    public partial class studentForm : Form
    {
        List<int> studentID = new List<int> { };
        List<string> studentName = new List<string> { };
        List<string> mobile = new List<string> { };
        List<int> age = new List<int> { };
        List<string> address = new List<string> { };
        List<double> gpa = new List<double> { };
        public studentForm()
        {
            InitializeComponent();
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Please enter your id");
                return;
            }

            if (idTextBox.Text.Length != 4)
            {
                MessageBox.Show("Id must be in 4 character!");
                return;
            }

            //Unique
            if (studentID.Contains(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Already exits");
                return;
            }

            if (String.IsNullOrEmpty(nameTextBox.Text) || nameTextBox.Text.Length >= 30)
            {
                MessageBox.Show("Please enter Name and Name must be in 30 character!");
                return;
            }

            if (String.IsNullOrEmpty(mobileTextBox.Text) || mobileTextBox.Text.Length != 11)
            {

                MessageBox.Show("Please enter Mobile No and Mobile No must be in 11 character!");
                return;
            }
            if(mobile.Contains((mobileTextBox.Text))
            {
                MessageBox.Show("This mobile number already exits");

            }

            if (String.IsNullOrEmpty(gpaTextBox.Text))
            {
                MessageBox.Show("Please enter valid CGPA!");
                return;
            }
            if (Convert.ToDouble(gpaTextBox.Text) < 0 || Convert.ToDouble(gpaTextBox.Text) > 5)
            {
                MessageBox.Show("Please enter valid CGPA");
                return;
            }
            else
            {
                AddStudent(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, mobileTextBox.Text,
                Convert.ToInt32(ageTextBox.Text), addressTextBox.Text, Convert.ToDouble(gpaTextBox.Text));
            }


            string output = "";
            for (int i = 0; i < studentID.Count(); i++)
            {
                output = "Student ID: " + studentID[i] + "\n" + "Student Name: " + studentName[i] + "\n"
                          + "Student Mobile: " + mobile[i] + "\n" + "Student Age: " + age[i] + "\n" + "Student Address: " + address[i] + "\n" + "GPA: " + gpa[i] + "\n\n";
            }
            richTextBox.Text = output;

            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaTextBox.Text = "";

        }


        public void AddStudent(int id, string Name, string Mobile, int Age, string Address, double Gpa)
        {
            studentID.Add(id);
            studentName.Add(Name);
            mobile.Add(Mobile);
            age.Add(Age);
            address.Add(Address);
            gpa.Add(Gpa);

        }

   


          

        //private void ShowButton_Click(object sender, EventArgs e)
        //{
        //    showStudent();
        //    //idTextBox.Text = "";
        //    //nameTextBox.Text = "";
        //    //mobileTextBox.Text = "";
        //    //ageTextBox.Text = "";
        //    //addressTextBox.Text = "";
        //    //gpaTextBox.Text = "";
        //}

        public void showStudent()
        {
            string output = "";
            for (int i = 0; i < studentID.Count(); i++)
            {
                output += "Student ID: " + studentID[i] + "\n" + "Student Name: " + studentName[i] + "\n"
                          + "Student Mobile: " + mobile[i] + "\n" + "Student Age: " + age[i] + "\n" + "Student Address: " + address[i] + "\n" + "GPA: " + gpa[i] + "\n\n";
            }
            ClearList();
            richTextBox.Text = output;

            var min = gpa.Min();
            var max = gpa.Max();
            var sum = gpa.Sum();
            var average = gpa.Average();
            var maxNumberName = gpa.IndexOf(gpa.Max());
            var minNumberName = gpa.IndexOf(gpa.Min());

            nameMaxTextBox.Text = studentName[maxNumberName];
            minNameTextBox.Text = studentName[minNumberName];
            maxTextBox.Text = max.ToString();
            minTextBox.Text = min.ToString();
            totalTextBox.Text = sum.ToString();
            averegeTextBox.Text = average.ToString();

        }
        private void ClearList()
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            mobileTextBox.Clear();
            ageTextBox.Clear();
            addressTextBox.Clear();
            gpaTextBox.Clear();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            if (idRadioButton.Checked == true)
            {
                richTextBox.Text = "";
                for (int i = 0; i <studentID.Count(); i++)
                {
                    if (idTextBox.Text.Equals(studentID[i]))
                    {
                        richTextBox.Text = "ID: " + studentID[i] + "\n" + "Name: " + studentName[i] + "\n" + "Mobile: " + mobile[i] + "\n" + "Age: " + age[i] + "\n" +
                       "Address: " + address[i] + "\n" + "GPA: " + gpa[i];

                    }
                    idTextBox.Text = "";
                    ClearList();
                }
            }

            else if (nameRadioButton.Checked == true)
            {
                richTextBox.Text = "";
                for (int i = 0; i < studentName.Count(); i++)
                {
                    if (nameTextBox.Text.Equals(studentName[i]))
                    {
                        richTextBox.Text = "ID: " + studentID[i] + "\n" + "Name: " + studentName[i] + "\n" + "Mobile: " + mobile[i] + "\n" + "Age: " + age[i] + "\n" +
                      "Address: " + address[i] + "\n" + "GPA: " + gpa[i];
                    }
                    nameTextBox.Text = "";
                    ClearList();
                }
            }

            else if (mobileRadioButton.Checked == true)
            {
                richTextBox.Text = "";
                for (int i = 0; i < mobile.Count(); i++)
                {
                    if (mobileTextBox.Text.Equals(mobile[i]))
                    {
                        richTextBox.Text = "ID: " + studentID[i] + "\n" + "Name: " +studentName[i] + "\n" + "Mobile: " + mobile[i] + "\n" + "Age: " + age[i] + "\n" +
                    "Address: " + address[i] + "\n" + "GPA: " + gpa[i];

                    }
                    mobileTextBox.Text = "";
                    ClearList();
                }

            }
        }

            private void showButton_Click(object sender, EventArgs e)
            {
            showStudent();
            idTextBox.Text = "";
            nameTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaTextBox.Text = "";

            }


     }
}

