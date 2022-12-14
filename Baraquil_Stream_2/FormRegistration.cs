
using Baraquil_Stream_2;
using Baraquil_Streams_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{ 
    public partial class FormRegistration : Form
    {
        //----------------------------------------------------------------------------------------------------//
        public static string SetFileName;
        
        //----------------------------------------------------------------------------------------------------//
        public FormRegistration()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------------------//
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FrmFileName FRN = new FrmFileName();
            FRN.ShowDialog();

            string getStudentInfo = StudentNumberTextBox.Text;
            string getFirstName = FirstnameTextBox.Text;
            string getLastName = LastNameTextBox.Text;
            string getMiddleInitial = MiddlenameTextBox.Text;
            string getProgram = ProgramComboBox.Text;
            string getGender = GenderComboBox.Text;
            string getAge = AgeTextBox.Text;
            string getBirthday = BirthdayDatePicker.Text;
            string getContact = ContactNumberTextBox.Text;

            SetFileName = StudentNumberTextBox.Text + ".txt";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student Info:" + getStudentInfo);
                outputFile.WriteLine("Fullname: " + getFirstName + " " + getMiddleInitial + "." + " " + getLastName);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No.: " + getContact);
            }

        }
        //----------------------------------------------------------------------------------------------------//
        private void BtnRecord_Click(object sender, EventArgs e)
        {
            FrmStudentRecord FSR = new FrmStudentRecord();
            FSR.ShowDialog();
        }
        //----------------------------------------------------------------------------------------------------//
    }
}
