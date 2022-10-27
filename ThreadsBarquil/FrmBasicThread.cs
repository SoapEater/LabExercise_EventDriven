using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsBaraquil
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "-Before Starting Thread-";
            ThreadStart threadStart = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(threadStart);
            ThreadB = new Thread(threadStart);

            ThreadA.Start();
            ThreadA.Name = "Thread A";
            ThreadB.Start();
            ThreadB.Name = "Thread B";

            ThreadA.Join();
            ThreadB.Join();

            if (!ThreadA.IsAlive && !ThreadB.IsAlive)
            {
                label1.Text = "-End of Thread-";
            }
        }
        public FrmBasicThread()
        {
            InitializeComponent();
        }
    }
}
