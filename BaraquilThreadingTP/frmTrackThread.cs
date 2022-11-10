using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaraquilThreadingTP
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            //MyThreadClass MTC = new MyThreadClass();
            //ThreadStart DelThreadStart1 = new ThreadStart(MTC.Thread1);

            ThreadStart DelThreadStart1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart DelThreadStart2 = new ThreadStart(MyThreadClass.Thread2);

            Thread ThreadA = new Thread(DelThreadStart1);
            Thread ThreadB = new Thread(DelThreadStart2);
            Thread ThreadC = new Thread(DelThreadStart1);
            Thread ThreadD = new Thread(DelThreadStart2);

            Console.WriteLine("-Thread Start-");
            LabelThread.Text = "-Thread Start-";

            //Name
            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
            ThreadC.Name = "Thread C";
            ThreadD.Name = "Thread D";

            //Priority
            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            //Start
            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            //Join
            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Console.WriteLine("-End Thread-");
            LabelThread.Text = "-End Thread-";
        }
    }
}
