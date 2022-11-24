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

namespace Baraquil_Streams_1
{
    public partial class FrmLab1 : Form
    {
        //----------------------------------------------------------------------------------------------------//
        public FrmLab1()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------------------//
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName FFN = new FrmFileName();
            FFN.ShowDialog();

            string getInput = TxtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }
        //----------------------------------------------------------------------------------------------------//
    }
}
