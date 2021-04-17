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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void BackPic_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            FadeEffectTime.Start();
        }

        private void FadeEffectTime_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.00)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                FadeEffectTime.Stop();
                Application.Exit();
            }
        }
    }
}
