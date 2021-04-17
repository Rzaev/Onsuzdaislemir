using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onsuzdaislemir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressTime.Start();
        }

        int start = 0;
        private void ProgressTime_Tick(object sender, EventArgs e)
        {
            start += 1;
            MyProgress.Value = start;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                ProgressTime.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
