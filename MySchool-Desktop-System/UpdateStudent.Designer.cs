namespace MySchool_Desktop_System
{
    partial class UpdateStudent
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
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.rdoActive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoUnsuccessful = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddImage = new Guna.UI2.WinForms.Guna2Button();
            this.StudentImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtpBirthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.comboClassName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStudentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGender.SuspendLayout();
            this.grpState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.Transparent;
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.ForeColor = System.Drawing.Color.Black;
            this.grpGender.Location = new System.Drawing.Point(257, 361);
            this.grpGender.Name = "grpGender";
            this.grpGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpGender.Size = new System.Drawing.Size(258, 58);
            this.grpGender.TabIndex = 63;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "الجنس";
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMale.CheckedState.BorderThickness = 0;
            this.rdoMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMale.CheckedState.InnerOffset = -4;
            this.rdoMale.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.Black;
            this.rdoMale.Location = new System.Drawing.Point(134, 23);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoMale.Size = new System.Drawing.Size(51, 24);
            this.rdoMale.TabIndex = 31;
            this.rdoMale.Text = "ذكر";
            this.rdoMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMale.UncheckedState.BorderThickness = 2;
            this.rdoMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFemale.CheckedState.BorderThickness = 0;
            this.rdoFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoFemale.CheckedState.InnerOffset = -4;
            this.rdoFemale.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.Black;
            this.rdoFemale.Location = new System.Drawing.Point(49, 23);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoFemale.Size = new System.Drawing.Size(52, 24);
            this.rdoFemale.TabIndex = 32;
            this.rdoFemale.Text = "أنثى";
            this.rdoFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoFemale.UncheckedState.BorderThickness = 2;
            this.rdoFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // grpState
            // 
            this.grpState.BackColor = System.Drawing.Color.Transparent;
            this.grpState.Controls.Add(this.rdoActive);
            this.grpState.Controls.Add(this.rdoUnsuccessful);
            this.grpState.ForeColor = System.Drawing.Color.Black;
            this.grpState.Location = new System.Drawing.Point(259, 287);
            this.grpState.Name = "grpState";
            this.grpState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpState.Size = new System.Drawing.Size(256, 66);
            this.grpState.TabIndex = 62;
            this.grpState.TabStop = false;
            this.grpState.Text = "الحالة";
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.BackColor = System.Drawing.Color.Transparent;
            this.rdoActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoActive.CheckedState.BorderThickness = 0;
            this.rdoActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoActive.CheckedState.InnerOffset = -4;
            this.rdoActive.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoActive.ForeColor = System.Drawing.Color.Black;
            this.rdoActive.Location = new System.Drawing.Point(132, 29);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoActive.Size = new System.Drawing.Size(53, 24);
            this.rdoActive.TabIndex = 42;
            this.rdoActive.Text = "نشط";
            this.rdoActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoActive.UncheckedState.BorderThickness = 2;
            this.rdoActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoActive.UseVisualStyleBackColor = false;
            // 
            // rdoUnsuccessful
            // 
            this.rdoUnsuccessful.AutoSize = true;
            this.rdoUnsuccessful.BackColor = System.Drawing.Color.Transparent;
            this.rdoUnsuccessful.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoUnsuccessful.CheckedState.BorderThickness = 0;
            this.rdoUnsuccessful.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoUnsuccessful.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoUnsuccessful.CheckedState.InnerOffset = -4;
            this.rdoUnsuccessful.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUnsuccessful.ForeColor = System.Drawing.Color.Black;
            this.rdoUnsuccessful.Location = new System.Drawing.Point(35, 29);
            this.rdoUnsuccessful.Name = "rdoUnsuccessful";
            this.rdoUnsuccessful.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoUnsuccessful.Size = new System.Drawing.Size(63, 24);
            this.rdoUnsuccessful.TabIndex = 43;
            this.rdoUnsuccessful.Text = "راسب";
            this.rdoUnsuccessful.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoUnsuccessful.UncheckedState.BorderThickness = 2;
            this.rdoUnsuccessful.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoUnsuccessful.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoUnsuccessful.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(436, 181);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "الشعبة:";
            // 
            // comboSection
            // 
            this.comboSection.BackColor = System.Drawing.Color.Transparent;
            this.comboSection.BorderColor = System.Drawing.Color.Silver;
            this.comboSection.BorderRadius = 10;
            this.comboSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSection.ForeColor = System.Drawing.Color.Black;
            this.comboSection.ItemHeight = 30;
            this.comboSection.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.comboSection.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.comboSection.Location = new System.Drawing.Point(294, 212);
            this.comboSection.Name = "comboSection";
            this.comboSection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboSection.Size = new System.Drawing.Size(199, 36);
            this.comboSection.TabIndex = 60;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnAddImage.BorderRadius = 10;
            this.btnAddImage.BorderThickness = 1;
            this.btnAddImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddImage.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddImage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.Black;
            this.btnAddImage.Location = new System.Drawing.Point(25, 370);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(228, 45);
            this.btnAddImage.TabIndex = 59;
            this.btnAddImage.Text = "إدراج صورة";
            // 
            // StudentImage
            // 
            this.StudentImage.BackColor = System.Drawing.Color.Transparent;
            this.StudentImage.FillColor = System.Drawing.SystemColors.ControlLight;
            this.StudentImage.ForeColor = System.Drawing.Color.Black;
            this.StudentImage.ImageRotate = 0F;
            this.StudentImage.Location = new System.Drawing.Point(25, 148);
            this.StudentImage.Name = "StudentImage";
            this.StudentImage.Size = new System.Drawing.Size(228, 205);
            this.StudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentImage.TabIndex = 58;
            this.StudentImage.TabStop = false;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpBirthdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.dtpBirthdate.Checked = true;
            this.dtpBirthdate.FillColor = System.Drawing.Color.White;
            this.dtpBirthdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.ForeColor = System.Drawing.Color.Black;
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthdate.Location = new System.Drawing.Point(521, 383);
            this.dtpBirthdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthdate.Size = new System.Drawing.Size(397, 36);
            this.dtpBirthdate.TabIndex = 57;
            this.dtpBirthdate.Value = new System.DateTime(2025, 11, 18, 0, 57, 39, 560);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(943, 333);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 20);
            this.lblPhoneNumber.TabIndex = 56;
            this.lblPhoneNumber.Text = "رقم التواصل:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(955, 218);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(53, 20);
            this.lblAddress.TabIndex = 55;
            this.lblAddress.Text = "العنوان:";
            // 
            // comboClassName
            // 
            this.comboClassName.BackColor = System.Drawing.Color.Transparent;
            this.comboClassName.BorderColor = System.Drawing.Color.Silver;
            this.comboClassName.BorderRadius = 10;
            this.comboClassName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClassName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboClassName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboClassName.ForeColor = System.Drawing.Color.Black;
            this.comboClassName.ItemHeight = 30;
            this.comboClassName.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.comboClassName.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.comboClassName.Location = new System.Drawing.Point(521, 262);
            this.comboClassName.Name = "comboClassName";
            this.comboClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboClassName.Size = new System.Drawing.Size(397, 36);
            this.comboClassName.TabIndex = 54;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(521, 208);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(397, 40);
            this.txtAddress.TabIndex = 53;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Black;
            this.lblClassName.Location = new System.Drawing.Point(955, 278);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClassName.Size = new System.Drawing.Size(59, 20);
            this.lblClassName.TabIndex = 52;
            this.lblClassName.Text = " الصف: ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtPhoneNumber.BorderRadius = 10;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(521, 323);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(397, 40);
            this.txtPhoneNumber.TabIndex = 51;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderColor = System.Drawing.Color.Silver;
            this.txtStudentName.BorderRadius = 10;
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.DefaultText = "";
            this.txtStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.Black;
            this.txtStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Location = new System.Drawing.Point(521, 148);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PlaceholderText = "";
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.Size = new System.Drawing.Size(397, 40);
            this.txtStudentName.TabIndex = 50;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.Black;
            this.lblBirthdate.Location = new System.Drawing.Point(944, 393);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBirthdate.Size = new System.Drawing.Size(83, 20);
            this.lblBirthdate.TabIndex = 49;
            this.lblBirthdate.Text = "تاريخ الميلاد:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(932, 158);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStudentName.Size = new System.Drawing.Size(76, 20);
            this.lblStudentName.TabIndex = 48;
            this.lblStudentName.Text = "اسم الطالب:";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Location = new System.Drawing.Point(34, 512);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(206, 41);
            this.Update.TabIndex = 64;
            this.Update.Text = "تحديث";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 723);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.grpState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSection);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.StudentImage);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.comboClassName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblStudentName);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateStudent";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpState.ResumeLayout(false);
            this.grpState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGender;
        private Guna.UI2.WinForms.Guna2RadioButton rdoMale;
        private Guna.UI2.WinForms.Guna2RadioButton rdoFemale;
        private System.Windows.Forms.GroupBox grpState;
        private Guna.UI2.WinForms.Guna2RadioButton rdoActive;
        private Guna.UI2.WinForms.Guna2RadioButton rdoUnsuccessful;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox comboSection;
        private Guna.UI2.WinForms.Guna2Button btnAddImage;
        private Guna.UI2.WinForms.Guna2PictureBox StudentImage;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI2.WinForms.Guna2ComboBox comboClassName;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label lblClassName;
        public Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        public Guna.UI2.WinForms.Guna2TextBox txtStudentName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}