﻿
namespace Onsuzdaislemir
{
    partial class StudentForm
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
            this.BackPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.GenderCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel5 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FadeEffectTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.BackPic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 100);
            this.panel1.TabIndex = 2;
            // 
            // BackPic
            // 
            this.BackPic.Image = global::Onsuzdaislemir.Properties.Resources.circleback1;
            this.BackPic.Location = new System.Drawing.Point(12, 9);
            this.BackPic.Name = "BackPic";
            this.BackPic.Size = new System.Drawing.Size(48, 48);
            this.BackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackPic.TabIndex = 3;
            this.BackPic.TabStop = false;
            this.BackPic.Click += new System.EventHandler(this.BackPic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // ExitBtn
            // 
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.Red;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(905, 3);
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
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Side";
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(87, 133);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(142, 10);
            this.guna2ShadowPanel3.TabIndex = 16;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderThickness = 0;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(87, 116);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(142, 20);
            this.guna2TextBox3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(87, 176);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(142, 10);
            this.guna2ShadowPanel2.TabIndex = 19;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderThickness = 0;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(87, 159);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(142, 20);
            this.guna2TextBox2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "DOB";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(87, 219);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(142, 30);
            this.guna2DateTimePicker1.TabIndex = 22;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 4, 16, 3, 9, 10, 140);
            // 
            // GenderCombo
            // 
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCombo.Location = new System.Drawing.Point(87, 192);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(142, 21);
            this.GenderCombo.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gender";
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(87, 281);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(142, 10);
            this.guna2ShadowPanel4.TabIndex = 26;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderThickness = 0;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Location = new System.Drawing.Point(87, 264);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(142, 20);
            this.guna2TextBox4.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Phone";
            // 
            // guna2ShadowPanel5
            // 
            this.guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel5.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel5.Location = new System.Drawing.Point(87, 367);
            this.guna2ShadowPanel5.Name = "guna2ShadowPanel5";
            this.guna2ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel5.Size = new System.Drawing.Size(142, 10);
            this.guna2ShadowPanel5.TabIndex = 32;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BorderThickness = 0;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.FocusedState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.HoverState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Location = new System.Drawing.Point(87, 350);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(142, 20);
            this.guna2TextBox5.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Class";
            // 
            // guna2ShadowPanel6
            // 
            this.guna2ShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel6.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel6.Location = new System.Drawing.Point(87, 324);
            this.guna2ShadowPanel6.Name = "guna2ShadowPanel6";
            this.guna2ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel6.Size = new System.Drawing.Size(142, 10);
            this.guna2ShadowPanel6.TabIndex = 29;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderThickness = 0;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.FocusedState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.HoverState.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Location = new System.Drawing.Point(87, 307);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.ShadowDecoration.Parent = this.guna2TextBox6;
            this.guna2TextBox6.Size = new System.Drawing.Size(142, 20);
            this.guna2TextBox6.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SlateBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(546, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 25);
            this.label11.TabIndex = 90;
            this.label11.Text = "Students List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 278);
            this.dataGridView1.TabIndex = 91;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.HomeBtn.CheckedState.Parent = this.HomeBtn;
            this.HomeBtn.CustomImages.Parent = this.HomeBtn;
            this.HomeBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.HoverState.Parent = this.HomeBtn;
            this.HomeBtn.Location = new System.Drawing.Point(31, 450);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
            this.HomeBtn.Size = new System.Drawing.Size(198, 45);
            this.HomeBtn.TabIndex = 95;
            this.HomeBtn.Text = "Home";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
            this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
            this.DeleteBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.HoverState.Parent = this.DeleteBtn;
            this.DeleteBtn.Location = new System.Drawing.Point(167, 406);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
            this.DeleteBtn.Size = new System.Drawing.Size(62, 38);
            this.DeleteBtn.TabIndex = 94;
            this.DeleteBtn.Text = "Delete";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.EditBtn.CheckedState.Parent = this.EditBtn;
            this.EditBtn.CustomImages.Parent = this.EditBtn;
            this.EditBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.HoverState.Parent = this.EditBtn;
            this.EditBtn.Location = new System.Drawing.Point(99, 406);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(62, 38);
            this.EditBtn.TabIndex = 93;
            this.EditBtn.Text = "Edit";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.AddBtn.CheckedState.Parent = this.AddBtn;
            this.AddBtn.CustomImages.Parent = this.AddBtn;
            this.AddBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.HoverState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(31, 406);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(62, 38);
            this.AddBtn.TabIndex = 92;
            this.AddBtn.Text = "Add";
            // 
            // FadeEffectTime
            // 
            this.FadeEffectTime.Tick += new System.EventHandler(this.FadeEffectTime_Tick);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 508);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guna2ShadowPanel5);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2ShadowPanel6);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2ShadowPanel4);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.GenderCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton ExitBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.ComboBox GenderCombo;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.PictureBox BackPic;
        private System.Windows.Forms.Timer FadeEffectTime;
    }
}