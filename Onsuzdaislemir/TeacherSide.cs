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
    public partial class TeacherSide : Form
    {
        public TeacherSide()
        {
            InitializeComponent();
            TeacherisMaleorFemale();
        }

        private void VisiblePic_Click(object sender, EventArgs e)
        {
            if(VisiblePic.Image==Properties.Resources.visible)
            {
                VisiblePic.Image = Properties.Resources.hide;
                PasswordTxt.PasswordChar = '\0';
            }
            else if(VisiblePic.Image==Properties.Resources.hide)
            {
                VisiblePic.Image = Properties.Resources.visible;
                PasswordTxt.PasswordChar = '•';
            }
        }

        private void TeacherisMaleorFemale()
        {
            int n = 3;
            if (/*oglandirsa*/ n==1)
            {
                ProfilImage.Image = Properties.Resources.man_teacher;
            }
            else if(/*qadindirsa*/ n==2)
            {
                ProfilImage.Image = Properties.Resources.woman_teacher;
            }
            else if(/*otherdise*/ n==3)
            {
                ProfilImage.Image = Properties.Resources.lgbt_flag;
            }
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherFont.MaxSize = 15;
            TeacherFont.MinSize = 8;
            TeacherFont.ShowDialog();
            foreach (var item in DataPage.Controls)
            {
                if(item is Label lbl)
                {
                    lbl.Font = TeacherFont.Font;
                }
            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPage.BackColor = Color.Black;
            foreach (var item in DataPage.Controls)
            {
                if (item is Label lbl)
                {
                    lbl.ForeColor = Color.White;
                }

                if (item is CheckBox ch)
                {
                    ch.ForeColor = Color.White;
                }
            }
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPage.BackColor = Color.White;
            foreach (var item in DataPage.Controls)
            {
                if (item is Label lbl)
                {
                    lbl.ForeColor = Color.Black;
                }

                if (item is CheckBox ch)
                {
                    ch.ForeColor = Color.Black;
                }
            }
        }
    }
}
