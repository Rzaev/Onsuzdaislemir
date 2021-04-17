
namespace Onsuzdaislemir
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.ClassBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.TeacherBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.StudentBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.LogoutBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.FadeEffectTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 100);
            this.panel1.TabIndex = 2;
            // 
            // ExitBtn
            // 
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(832, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(58, 54);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Side";
            // 
            // SubjectBtn
            // 
            this.SubjectBtn.BackColor = System.Drawing.Color.Black;
            this.SubjectBtn.CheckedState.Parent = this.SubjectBtn;
            this.SubjectBtn.CustomImages.Parent = this.SubjectBtn;
            this.SubjectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubjectBtn.ForeColor = System.Drawing.Color.White;
            this.SubjectBtn.HoverState.Parent = this.SubjectBtn;
            this.SubjectBtn.Location = new System.Drawing.Point(170, 295);
            this.SubjectBtn.Name = "SubjectBtn";
            this.SubjectBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SubjectBtn.ShadowDecoration.Parent = this.SubjectBtn;
            this.SubjectBtn.Size = new System.Drawing.Size(131, 129);
            this.SubjectBtn.TabIndex = 13;
            this.SubjectBtn.Text = "Subject";
            this.SubjectBtn.Click += new System.EventHandler(this.SubjectBtn_Click);
            // 
            // ClassBtn
            // 
            this.ClassBtn.BackColor = System.Drawing.Color.Black;
            this.ClassBtn.CheckedState.Parent = this.ClassBtn;
            this.ClassBtn.CustomImages.Parent = this.ClassBtn;
            this.ClassBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClassBtn.ForeColor = System.Drawing.Color.White;
            this.ClassBtn.HoverState.Parent = this.ClassBtn;
            this.ClassBtn.Location = new System.Drawing.Point(682, 118);
            this.ClassBtn.Name = "ClassBtn";
            this.ClassBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ClassBtn.ShadowDecoration.Parent = this.ClassBtn;
            this.ClassBtn.Size = new System.Drawing.Size(131, 129);
            this.ClassBtn.TabIndex = 12;
            this.ClassBtn.Text = "Classes";
            this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
            // 
            // TeacherBtn
            // 
            this.TeacherBtn.BackColor = System.Drawing.Color.Black;
            this.TeacherBtn.CheckedState.Parent = this.TeacherBtn;
            this.TeacherBtn.CustomImages.Parent = this.TeacherBtn;
            this.TeacherBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TeacherBtn.ForeColor = System.Drawing.Color.White;
            this.TeacherBtn.HoverState.Parent = this.TeacherBtn;
            this.TeacherBtn.Location = new System.Drawing.Point(321, 118);
            this.TeacherBtn.Name = "TeacherBtn";
            this.TeacherBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TeacherBtn.ShadowDecoration.Parent = this.TeacherBtn;
            this.TeacherBtn.Size = new System.Drawing.Size(131, 129);
            this.TeacherBtn.TabIndex = 11;
            this.TeacherBtn.Text = "Teacher";
            this.TeacherBtn.Click += new System.EventHandler(this.TeacherBtn_Click);
            // 
            // StudentBtn
            // 
            this.StudentBtn.BackColor = System.Drawing.Color.Black;
            this.StudentBtn.CheckedState.Parent = this.StudentBtn;
            this.StudentBtn.CustomImages.Parent = this.StudentBtn;
            this.StudentBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StudentBtn.ForeColor = System.Drawing.Color.White;
            this.StudentBtn.HoverState.Parent = this.StudentBtn;
            this.StudentBtn.Location = new System.Drawing.Point(29, 118);
            this.StudentBtn.Name = "StudentBtn";
            this.StudentBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.StudentBtn.ShadowDecoration.Parent = this.StudentBtn;
            this.StudentBtn.Size = new System.Drawing.Size(131, 129);
            this.StudentBtn.TabIndex = 10;
            this.StudentBtn.Text = "Student";
            this.StudentBtn.Click += new System.EventHandler(this.StudentBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Black;
            this.LogoutBtn.CheckedState.Parent = this.LogoutBtn;
            this.LogoutBtn.CustomImages.Parent = this.LogoutBtn;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.HoverState.Parent = this.LogoutBtn;
            this.LogoutBtn.Location = new System.Drawing.Point(506, 295);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LogoutBtn.ShadowDecoration.Parent = this.LogoutBtn;
            this.LogoutBtn.Size = new System.Drawing.Size(131, 129);
            this.LogoutBtn.TabIndex = 14;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // FadeEffectTime
            // 
            this.FadeEffectTime.Tick += new System.EventHandler(this.FadeEffectTime_Tick);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Onsuzdaislemir.Properties.Resources.blackboard;
            this.ClientSize = new System.Drawing.Size(939, 491);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.SubjectBtn);
            this.Controls.Add(this.ClassBtn);
            this.Controls.Add(this.TeacherBtn);
            this.Controls.Add(this.StudentBtn);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenuForm";
            this.Text = "MainManuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton ExitBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientCircleButton SubjectBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton ClassBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton TeacherBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton StudentBtn;
        private Guna.UI2.WinForms.Guna2GradientCircleButton LogoutBtn;
        private System.Windows.Forms.Timer FadeEffectTime;
    }
}