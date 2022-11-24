using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baraquil_Streams_1
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        //----------------------------------------------------------------------------------------------------//
        public FrmFileName()
        {
            InitializeComponent();
        }
        //----------------------------------------------------------------------------------------------------//
        private void BtnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = TxtFileName.Text + ".txt";
            Close();
        }
        //----------------------------------------------------------------------------------------------------//
    }
}
