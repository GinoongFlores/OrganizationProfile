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

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        private static string _FullName;
        private static int _Age;
        private static string _contactNo;
        private static long _studentNo;

        /////return methods 
        public long StudentNumber(string studNum)
        {
            try
            {

            _studentNo = long.Parse(studNum);
            }

            catch(FormatException e)
            {
                MessageBox.Show("Invalid Student Number!");
            }
            return _studentNo;
        }

        public string ContactNo(string Contact)
        {

            
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                /*_contactNo = long.Parse(Contact);*/
                _contactNo = Contact;
            }
            else
            {
                MessageBox.Show("Invalid Number Format!");
            }

            return _contactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") && Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") && Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            else
            {
                MessageBox.Show("Invalid Name Format!");

            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            } 

            else
            {
                MessageBox.Show("Invalid Format!");
            }

            return _Age;
        }
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] listOfPrograms = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitatality Management",
                "BS in Tourism Management"
            };

            for(int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(listOfPrograms[i].ToString()); 
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {

            StudentInformationClass.setFullName = FullName(txtLastName.Text,
txtFirstName.Text, txtMiddleInitial.Text);
            StudentInformationClass.setStudentNo = (int)StudentNumber(txtStudentNo.Text);
            StudentInformationClass.setProgram = cbPrograms.Text;

            StudentInformationClass.setGender = cbGender.Text;
            StudentInformationClass.setContactNo = "+63" + ContactNo(txtContactNo.Text.Substring(1));
            StudentInformationClass.setAge = Age(txtAge.Text);
            StudentInformationClass.setBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");
           
            }

            catch (FormatException eq)
            {
                MessageBox.Show("Format Exception!");
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("Argument Null Exception!");

            }

            catch (OverflowException)
            {
                MessageBox.Show("Overflow Exception!");

            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index Out Of Range Exception!");

            }
            finally
            {
                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
           
        }
    }
}
