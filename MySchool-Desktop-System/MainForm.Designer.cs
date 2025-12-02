namespace MySchool_Desktop_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToggleTheme = new FontAwesome.Sharp.IconButton();
            this.btnSubject = new Guna.UI2.WinForms.Guna2Button();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentForm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Controls.Add(this.guna2PictureBox3);
            this.panelContainer.ForeColor = System.Drawing.Color.Black;
            this.panelContainer.Location = new System.Drawing.Point(-1, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1060, 770);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(257, 167);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(490, 366);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnToggleTheme);
            this.panel1.Controls.Add(this.btnSubject);
            this.panel1.Controls.Add(this.iconButtonBack);
            this.panel1.Controls.Add(this.guna2Button7);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.btnStudentForm);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1060, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(242, 770);
            this.panel1.TabIndex = 0;
            // 
            // btnToggleTheme
            // 
            this.btnToggleTheme.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleTheme.FlatAppearance.BorderSize = 0;
            this.btnToggleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleTheme.Font = new System.Drawing.Font("FontAwesome", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleTheme.ForeColor = System.Drawing.Color.Black;
            this.btnToggleTheme.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.btnToggleTheme.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnToggleTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToggleTheme.Location = new System.Drawing.Point(17, 9);
            this.btnToggleTheme.Name = "btnToggleTheme";
            this.btnToggleTheme.Size = new System.Drawing.Size(70, 49);
            this.btnToggleTheme.TabIndex = 6;
            this.btnToggleTheme.UseVisualStyleBackColor = false;
            this.btnToggleTheme.Click += new System.EventHandler(this.btnToggleTheme_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnSubject.BorderRadius = 5;
            this.btnSubject.BorderThickness = 1;
            this.btnSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubject.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubject.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.ForeColor = System.Drawing.Color.Black;
            this.btnSubject.Image = global::MySchool_Desktop_System.Properties.Resources.books;
            this.btnSubject.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSubject.ImageSize = new System.Drawing.Size(40, 35);
            this.btnSubject.Location = new System.Drawing.Point(5, 375);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(234, 54);
            this.btnSubject.TabIndex = 3;
            this.btnSubject.Text = "إدارة المواد الدراسية";
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // iconButtonBack
            // 
            this.iconButtonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButtonBack.FlatAppearance.BorderSize = 0;
            this.iconButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBack.ForeColor = System.Drawing.Color.Black;
            this.iconButtonBack.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.iconButtonBack.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButtonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBack.Location = new System.Drawing.Point(163, 6);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(76, 52);
            this.iconButtonBack.TabIndex = 4;
            this.iconButtonBack.UseVisualStyleBackColor = false;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.guna2Button7.BorderRadius = 5;
            this.guna2Button7.BorderThickness = 1;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.Image = global::MySchool_Desktop_System.Properties.Resources.management_7322860;
            this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button7.ImageSize = new System.Drawing.Size(40, 35);
            this.guna2Button7.Location = new System.Drawing.Point(6, 515);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(233, 54);
            this.guna2Button7.TabIndex = 3;
            this.guna2Button7.Text = "الوحدة المالية";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 35);
            this.guna2Button3.Location = new System.Drawing.Point(6, 445);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(234, 54);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "إدارة الصفوف";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::MySchool_Desktop_System.Properties.Resources.teacher;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 35);
            this.guna2Button2.Location = new System.Drawing.Point(3, 303);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(234, 55);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "إدارة المعلمين";
            this.guna2Button2.Click += new System.EventHandler(this.btnTeacherForm_Click);
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnStudentForm.BorderRadius = 5;
            this.btnStudentForm.BorderThickness = 1;
            this.btnStudentForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentForm.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudentForm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentForm.ForeColor = System.Drawing.Color.Black;
            this.btnStudentForm.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentForm.Image")));
            this.btnStudentForm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentForm.ImageSize = new System.Drawing.Size(40, 35);
            this.btnStudentForm.Location = new System.Drawing.Point(5, 230);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(234, 58);
            this.btnStudentForm.TabIndex = 1;
            this.btnStudentForm.Text = "إدارة الطلاب";
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.guna2Panel1.Controls.Add(this.lblUserName);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 82);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(233, 121);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(71, 85);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "اسم المستخدم";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2PictureBox1.Image = global::MySchool_Desktop_System.Properties.Resources.user__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(79, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(71, 69);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 770);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnStudentForm;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton iconButtonBack;
        private Guna.UI2.WinForms.Guna2Button btnSubject;
        private FontAwesome.Sharp.IconButton btnToggleTheme;
    }
}

