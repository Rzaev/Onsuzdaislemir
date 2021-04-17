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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheck.Checked)
                PasswordTxt.PasswordChar = '\0';
            else
                PasswordTxt.PasswordChar = '•';
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UsernameTxt.Text = string.Empty;
            PasswordTxt.Text = "";
            UsernameTxt.Focus();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginBtn.Cursor == Cursors.Hand)
            {
                //MainMenuForm mainMenuForm = new MainMenuForm();
                //mainMenuForm.Show();
                TeacherSide teacherSide = new TeacherSide();
                teacherSide.Show();
                this.Close();
            }
        }

        private void MyTextChange(object sender, EventArgs e)
        {
            if (UsernameTxt.Text != "" && PasswordTxt.Text != "")
            {
                LoginBtn.ForeColor = Color.Lime;
                LoginBtn.Cursor = Cursors.Hand;
            }
            else
            {
                LoginBtn.ForeColor = Color.Red;
                LoginBtn.Cursor = Cursors.No;
            }
        }
    }
}
