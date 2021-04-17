
namespace Onsuzdaislemir
{
    partial class LoginForm
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ShowCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackgroundImage = global::Onsuzdaislemir.Properties.Resources.blackboard;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(390, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(320, 352);
            this.panelRight.TabIndex = 2;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoRoundedCorners = true;
            this.PasswordTxt.BorderRadius = 17;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.Parent = this.PasswordTxt;
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.FocusedState.Parent = this.PasswordTxt;
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTxt.ForeColor = System.Drawing.Color.Blue;
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.HoverState.Parent = this.PasswordTxt;
            this.PasswordTxt.Location = new System.Drawing.Point(35, 210);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '•';
            this.PasswordTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PasswordTxt.PlaceholderText = "Password";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.ShadowDecoration.Parent = this.PasswordTxt;
            this.PasswordTxt.Size = new System.Drawing.Size(200, 36);
            this.PasswordTxt.TabIndex = 12;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.MyTextChange);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.AutoRoundedCorners = true;
            this.UsernameTxt.BorderRadius = 17;
            this.UsernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxt.DefaultText = "";
            this.UsernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.DisabledState.Parent = this.UsernameTxt;
            this.UsernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxt.FocusedState.Parent = this.UsernameTxt;
            this.UsernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTxt.ForeColor = System.Drawing.Color.Blue;
            this.UsernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTxt.HoverState.Parent = this.UsernameTxt;
            this.UsernameTxt.Location = new System.Drawing.Point(35, 158);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PasswordChar = '\0';
            this.UsernameTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UsernameTxt.PlaceholderText = "Username";
            this.UsernameTxt.SelectedText = "";
            this.UsernameTxt.ShadowDecoration.Parent = this.UsernameTxt;
            this.UsernameTxt.Size = new System.Drawing.Size(200, 36);
            this.UsernameTxt.TabIndex = 11;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.MyTextChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Onsuzdaislemir.Properties.Resources.graduation;
            this.pictureBox1.Location = new System.Drawing.Point(90, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.CheckedState.Parent = this.ClearBtn;
            this.ClearBtn.CustomImages.Parent = this.ClearBtn;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.HoverState.Parent = this.ClearBtn;
            this.ClearBtn.Location = new System.Drawing.Point(35, 288);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.ShadowDecoration.Parent = this.ClearBtn;
            this.ClearBtn.Size = new System.Drawing.Size(61, 34);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.Red;
            this.LoginBtn.HoverState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(257, 238);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(80, 72);
            this.LoginBtn.TabIndex = 15;
            this.LoginBtn.Text = "Log in";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ShowCheck
            // 
            this.ShowCheck.AutoSize = true;
            this.ShowCheck.Location = new System.Drawing.Point(49, 253);
            this.ShowCheck.Name = "ShowCheck";
            this.ShowCheck.Size = new System.Drawing.Size(102, 17);
            this.ShowCheck.TabIndex = 16;
            this.ShowCheck.Text = "Show Password";
            this.ShowCheck.UseVisualStyleBackColor = true;
            this.ShowCheck.CheckedChanged += new System.EventHandler(this.ShowCheck_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 352);
            this.Controls.Add(this.ShowCheck);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelRight);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.TextChanged += new System.EventHandler(this.MyTextChange);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button ClearBtn;
        private Guna.UI2.WinForms.Guna2CircleButton LoginBtn;
        private System.Windows.Forms.CheckBox ShowCheck;
    }
}