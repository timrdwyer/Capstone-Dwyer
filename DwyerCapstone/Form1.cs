using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DwyerCapstone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Close button
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Validate NAME and pass to class1
            
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Class1.Name = txtName.Text;
            }

            //Validate NUMBER OF COURSES has been entered and passes to class1 
            //Validate input is a number
            int parsedNum;
            if (!int.TryParse(txtNumCourses.Text, out parsedNum))
            {
                MessageBox.Show("Number of Courses field must be a number.", "Error", MessageBoxButtons.OK);
                return;
            }
            //Validate that field is not blank
            if (txtNumCourses.Text == "")
            {
                MessageBox.Show("Number of Courses field cannot be blank.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Class1.Number = txtNumCourses.Text;
            }

           
            //Send start date to class1         
            Class1.Date = dtStartDate.Text;
            

            //Pass course code to class1
            Class1.Code = cmbbxCourseCode.Text;

            //Validate a style option is selected
            if (radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show(string.Format("Please select either Online or Hybrid option.", Class2.GetStyle), "Error", MessageBoxButtons.OK);
        }

        private void txtNumCourses_ValueChanged(object sender, EventArgs e)
        {
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //Following lines set output text boxes to value from class2
            displayNumCourses.Text = Class2.GetNumber;
            displayName.Text = Class2.GetName;
            displayDate.Text = Class2.GetDate;
            displayCode.Text = Class2.GetCode;
            displayStyle.Text = Class2.GetStyle;

            //Message box to show the value of Class Style has changed in class2
            MessageBox.Show(string.Format("The course stlye has been changed to {0}",Class2.GetStyle),"Change made", MessageBoxButtons.OK);
           
        }

        private void txtNumCourses2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Checks to see if radio button 2 is checked and sends value 'Hybrid' to class1 if true
            if (radioButton2.Checked == true)
                Class1.Style = "Hybrid";                  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Checks to see if radio button 1 is checked and sends value 'Online' to class1 if true
            if (radioButton1.Checked == true)
                Class1.Style = "Online";
        }

        private void txtCourseCode_SelectedIndexChanged(object sender, EventArgs e)
        {        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseListingDataSet2.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.courseListingDataSet2.Table);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
