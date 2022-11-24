using Account_Registration;
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

namespace Baraquil_Stream_2
{
    public partial class FrmStudentRecord : Form
    {
        FormRegistration FormRegistration = new FormRegistration();
        private string path;

        //----------------------------------------------------------------------------------------------------//
        public FrmStudentRecord()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------------------//
        private void BtnFind_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        //----------------------------------------------------------------------------------------------------//
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegistration.ShowDialog();
        }
        //----------------------------------------------------------------------------------------------------//
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LvRecord.Clear();
            MessageBox.Show("Successfully Uploaded!!");
            Close();
        }
        //----------------------------------------------------------------------------------------------------//
        public void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    LvRecord.Items.Add(_getText);
                }
            }
        }
        //----------------------------------------------------------------------------------------------------//
    }
}
