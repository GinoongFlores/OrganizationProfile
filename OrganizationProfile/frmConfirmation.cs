﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.setStudentNo.ToString();
            lblName.Text = StudentInformationClass.setFullName;
            lblProgram.Text = StudentInformationClass.setProgram;
            lblBirthday.Text = StudentInformationClass.setBirthday;
            lblGender.Text = StudentInformationClass.setGender;
            lblContactNo.Text = StudentInformationClass.setContactNo.ToString();
            lblAge.Text = StudentInformationClass.setAge.ToString();
        }
    }
}
