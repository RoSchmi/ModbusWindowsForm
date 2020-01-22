using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusWindowsForm
{
    public partial class AsyncMessageBox : Form
    {
        public AsyncMessageBox(string Message)
        {
            InitializeComponent();

            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            label1.Text = Message;
        }
        

        void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

    }
}
