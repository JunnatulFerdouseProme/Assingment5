using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment5
{
    public partial class studentForm : Form
    {
        ErrorProvider erp = new ErrorProvider();


        List<string> ids = new List<string>();
        List<string> names = new List<string>();
        List<string> mobiles = new List<string>();
        List<string> ages = new List<string>();
        List<string> addres = new List<string>();
        List<string> gpas = new List<string>();

        string message = " ";
        int index = 0;
        public studentForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gpaLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            erp.Clear();

            if (idTextBox.Text.Equals(" ") || idTextBox.Text.Length != 4)
            {
                index++;
                erp.SetError(idTextBox, "Enter your Id in 4 character");
                return;
            }
            else if (checkDuplicateID()) ;
            else if (nameTextBox.Text.Equals(" ") || nameTextBox.Text.Length > 30)
            {
                index++;
                erp.SetError(nameTextBox, "Enter your Name less then 30 character");
                return;
            }

            else if (mobileTextBox.Text.Equals(" ") || mobileTextBox.Text.Length != 11)
            {
                index++;
                erp.SetError(phoneTextBox, "Enter your phone number in 11 character");
                return;
            }
            else if (checkDuplicateMobile()) ;

            else if (ageTextBox.Text.Equals(" ") || ageTextBox.Text.Length > 50)
            {
                index++;
                erp.SetError(ageTextBox, "Enter your age ");
                return;
            }

            else if (addressTextBox.Text.Equals(" "))
            {
                index++;
                erp.SetError(addressTextBox, "Write your address ");
                return;
            }

            else if (gpaTextBox.Text.Equals(" ") || (float.Parse(gpaTextBox.Text) < 1 || float.Parse(gpaTextBox.Text) > 4))
            {
                index++;
                erp.SetError(gpaTextBox, "GPA point must be in 1-4 ");
                return;
            }

            ids.Add(idTextBox.Text);
            names.Add(nameTextBox.Text);
            mobiles.Add(mobileTextBox.Text);
            ages.Add(ageTextBox.Text);
            addres.Add(addressTextBox.Text);
            gpas.Add(gpaTextBox.Text);

            richTextBox.Text = "ID : " + idTextBox.Text + "\n" + "Name : " + nameTextBox.Text + "\n" + "Mobile : " + mobileTextBox.Text + "\n" + "Age : " + ageTextBox.Text + "\n" + "Address : " + addressTextBox.Text + "\n" + "GPA : " + gpaTextBox.Text + "\n";
            MessageBox.Show("Student is admitted");
            Clear();

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            String minName = " ", maxName = " ";
            float min = 10, max = 0, avg = 0, total = 0, gpatext;


            for (int j = 0; j < ids.Count(); j++)
            {
                gpatext = float.Parse(gpas[j]);
                total += gpatext;

                if (min > gpatext)
                {
                    min = gpatext;
                    minName = names[j];
                }

                if (max < gpatext)
                {
                    max = gpatext;
                    maxName = names[j];

                }

                message += "ID : " + ids[j] + "\n" + "Name : " + names[j] + "\n" + "Mobile : " + mobiles[j] + "\n" + "Age : " + ages[j] + "\n" + "Address : " + addres[j] + "\n" + "GPA : " + gpas[j] + "\n" + "\n";

                maxTextBox.Text = max.ToString();
                nameMaxTextBox.Text = maxName;
                mimTextBox.Text = min.ToString();
                mimNameTextBox.Text = minName;
                totalTextBox.Text = total.ToString();
                averegeTextBox.Text = (total / ids.Count()).ToString();
            }
            richTextBox.Text = message;

        }

        private void Clear()
        {
            nameTextBox.Text = "";
            idTextBox.Text = "";
            mobileTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            gpaTextBox.Text = "";
            maxTextBox.Text = "";
            mimTextBox.Text = "";
            nameMaxTextBox.Text = "";
            mimNameTextBox.Text = "";
            averegeTextBox.Text = "";
            totalTextBox.Text = "";

        }

    }

    
    
}

