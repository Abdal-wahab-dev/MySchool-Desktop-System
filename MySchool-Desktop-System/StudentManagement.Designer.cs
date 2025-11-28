namespace MySchool_Desktop_System
{
    partial class StudentManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStudntDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.dgvstudent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboClassName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStudentName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rdoFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAddImage = new Guna.UI2.WinForms.Guna2Button();
            this.lblSchoolYear = new System.Windows.Forms.Label();
            this.comboSchoolYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.StudentImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.rdoUnsuccessful = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoActive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblState = new System.Windows.Forms.Label();
            this.comboSection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(447, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدارة الطلاب";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnStudntDetails);
            this.panel3.Controls.Add(this.btnModifyStudent);
            this.panel3.Controls.Add(this.btnRemoveStudent);
            this.panel3.Controls.Add(this.btnAddStudent);
            this.panel3.Location = new System.Drawing.Point(11, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 89);
            this.panel3.TabIndex = 1;
            // 
            // btnStudntDetails
            // 
            this.btnStudntDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnStudntDetails.BorderRadius = 10;
            this.btnStudntDetails.BorderThickness = 1;
            this.btnStudntDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudntDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudntDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudntDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudntDetails.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudntDetails.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudntDetails.ForeColor = System.Drawing.Color.Black;
            this.btnStudntDetails.Location = new System.Drawing.Point(65, 29);
            this.btnStudntDetails.Name = "btnStudntDetails";
            this.btnStudntDetails.Size = new System.Drawing.Size(151, 45);
            this.btnStudntDetails.TabIndex = 3;
            this.btnStudntDetails.Text = "تفاصيل";
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnModifyStudent.BorderRadius = 10;
            this.btnModifyStudent.BorderThickness = 1;
            this.btnModifyStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifyStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifyStudent.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifyStudent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyStudent.ForeColor = System.Drawing.Color.Black;
            this.btnModifyStudent.Location = new System.Drawing.Point(346, 29);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(158, 45);
            this.btnModifyStudent.TabIndex = 2;
            this.btnModifyStudent.Text = "تعديل";
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnRemoveStudent.BorderRadius = 10;
            this.btnRemoveStudent.BorderThickness = 1;
            this.btnRemoveStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveStudent.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveStudent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveStudent.Location = new System.Drawing.Point(607, 29);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(149, 45);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "حذف";
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnAddStudent.BorderRadius = 10;
            this.btnAddStudent.BorderThickness = 1;
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStudent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddStudent.Location = new System.Drawing.Point(834, 29);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(152, 45);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "إضافة";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvstudent
            // 
            this.dgvstudent.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvstudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvstudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvstudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvstudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvstudent.ColumnHeadersHeight = 36;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.ClassName,
            this.State,
            this.PhoneNumber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvstudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvstudent.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvstudent.Location = new System.Drawing.Point(11, 560);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvstudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvstudent.RowHeadersVisible = false;
            this.dgvstudent.RowHeadersWidth = 51;
            this.dgvstudent.RowTemplate.Height = 26;
            this.dgvstudent.Size = new System.Drawing.Size(1029, 59);
            this.dgvstudent.TabIndex = 2;
            this.dgvstudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvstudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvstudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvstudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvstudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvstudent.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvstudent.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvstudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvstudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvstudent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvstudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvstudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvstudent.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvstudent.ThemeStyle.ReadOnly = false;
            this.dgvstudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvstudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvstudent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvstudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvstudent.ThemeStyle.RowsStyle.Height = 26;
            this.dgvstudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvstudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "الرقم";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "الاسم";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "الصف";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            // 
            // State
            // 
            this.State.HeaderText = "الحالة";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "رقم التواصل";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // comboClassName
            // 
            this.comboClassName.BackColor = System.Drawing.Color.Transparent;
            this.comboClassName.BorderRadius = 10;
            this.comboClassName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClassName.FillColor = System.Drawing.SystemColors.ControlLight;
            this.comboClassName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboClassName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboClassName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboClassName.ForeColor = System.Drawing.Color.Black;
            this.comboClassName.ItemHeight = 30;
            this.comboClassName.Location = new System.Drawing.Point(537, 246);
            this.comboClassName.Name = "comboClassName";
            this.comboClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboClassName.Size = new System.Drawing.Size(397, 36);
            this.comboClassName.TabIndex = 22;
            this.comboClassName.SelectedIndexChanged += new System.EventHandler(this.comboClassName_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(537, 192);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(397, 40);
            this.txtAddress.TabIndex = 21;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Black;
            this.lblClassName.Location = new System.Drawing.Point(971, 262);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblClassName.Size = new System.Drawing.Size(59, 20);
            this.lblClassName.TabIndex = 19;
            this.lblClassName.Text = " الصف: ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.txtPhoneNumber.BorderRadius = 10;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(537, 307);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(397, 40);
            this.txtPhoneNumber.TabIndex = 18;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.txtStudentName.BorderRadius = 10;
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentName.DefaultText = "";
            this.txtStudentName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentName.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtStudentName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.Black;
            this.txtStudentName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentName.Location = new System.Drawing.Point(537, 132);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PlaceholderText = "";
            this.txtStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.Size = new System.Drawing.Size(397, 40);
            this.txtStudentName.TabIndex = 17;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.Black;
            this.lblBirthdate.Location = new System.Drawing.Point(960, 377);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBirthdate.Size = new System.Drawing.Size(83, 20);
            this.lblBirthdate.TabIndex = 16;
            this.lblBirthdate.Text = "تاريخ الميلاد:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(948, 142);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStudentName.Size = new System.Drawing.Size(76, 20);
            this.lblStudentName.TabIndex = 15;
            this.lblStudentName.Text = "اسم الطالب:";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(971, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddress.Size = new System.Drawing.Size(53, 20);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "العنوان:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(959, 317);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPhoneNumber.Size = new System.Drawing.Size(84, 20);
            this.lblPhoneNumber.TabIndex = 24;
            this.lblPhoneNumber.Text = "رقم التواصل:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 10.2F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(262, 68);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(387, 43);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpBirthdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.dtpBirthdate.Checked = true;
            this.dtpBirthdate.FillColor = System.Drawing.SystemColors.ControlLight;
            this.dtpBirthdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthdate.Location = new System.Drawing.Point(537, 367);
            this.dtpBirthdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthdate.Size = new System.Drawing.Size(397, 36);
            this.dtpBirthdate.TabIndex = 27;
            this.dtpBirthdate.Value = new System.DateTime(2025, 11, 18, 0, 57, 39, 560);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFemale.CheckedState.BorderThickness = 0;
            this.rdoFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoFemale.CheckedState.InnerOffset = -4;
            this.rdoFemale.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.Black;
            this.rdoFemale.Location = new System.Drawing.Point(308, 379);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoFemale.Size = new System.Drawing.Size(52, 24);
            this.rdoFemale.TabIndex = 32;
            this.rdoFemale.Text = "أنثى";
            this.rdoFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoFemale.UncheckedState.BorderThickness = 2;
            this.rdoFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMale.CheckedState.BorderThickness = 0;
            this.rdoMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMale.CheckedState.InnerOffset = -4;
            this.rdoMale.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.Black;
            this.rdoMale.Location = new System.Drawing.Point(394, 379);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoMale.Size = new System.Drawing.Size(51, 24);
            this.rdoMale.TabIndex = 31;
            this.rdoMale.Text = "ذكر";
            this.rdoMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMale.UncheckedState.BorderThickness = 2;
            this.rdoMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(476, 379);
            this.lblGender.Name = "lblGender";
            this.lblGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGender.Size = new System.Drawing.Size(49, 20);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "الجنس:";
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
            this.btnAddImage.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddImage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.Black;
            this.btnAddImage.Location = new System.Drawing.Point(41, 354);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(228, 45);
            this.btnAddImage.TabIndex = 37;
            this.btnAddImage.Text = "إدراج صورة";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lblSchoolYear
            // 
            this.lblSchoolYear.AutoSize = true;
            this.lblSchoolYear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolYear.ForeColor = System.Drawing.Color.Black;
            this.lblSchoolYear.Location = new System.Drawing.Point(932, 75);
            this.lblSchoolYear.Name = "lblSchoolYear";
            this.lblSchoolYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSchoolYear.Size = new System.Drawing.Size(92, 23);
            this.lblSchoolYear.TabIndex = 39;
            this.lblSchoolYear.Text = "السنة الدراسية:";
            // 
            // comboSchoolYear
            // 
            this.comboSchoolYear.BackColor = System.Drawing.Color.Transparent;
            this.comboSchoolYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.comboSchoolYear.BorderRadius = 20;
            this.comboSchoolYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSchoolYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSchoolYear.FillColor = System.Drawing.SystemColors.ControlLight;
            this.comboSchoolYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSchoolYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSchoolYear.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSchoolYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboSchoolYear.ItemHeight = 30;
            this.comboSchoolYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033"});
            this.comboSchoolYear.Location = new System.Drawing.Point(728, 67);
            this.comboSchoolYear.Name = "comboSchoolYear";
            this.comboSchoolYear.Size = new System.Drawing.Size(198, 36);
            this.comboSchoolYear.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(187, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 43);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "بحث";
            // 
            // StudentImage
            // 
            this.StudentImage.FillColor = System.Drawing.SystemColors.ControlLight;
            this.StudentImage.ImageRotate = 0F;
            this.StudentImage.Location = new System.Drawing.Point(41, 132);
            this.StudentImage.Name = "StudentImage";
            this.StudentImage.Size = new System.Drawing.Size(228, 205);
            this.StudentImage.TabIndex = 36;
            this.StudentImage.TabStop = false;
            // 
            // rdoUnsuccessful
            // 
            this.rdoUnsuccessful.AutoSize = true;
            this.rdoUnsuccessful.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoUnsuccessful.CheckedState.BorderThickness = 0;
            this.rdoUnsuccessful.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoUnsuccessful.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoUnsuccessful.CheckedState.InnerOffset = -4;
            this.rdoUnsuccessful.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUnsuccessful.ForeColor = System.Drawing.Color.Black;
            this.rdoUnsuccessful.Location = new System.Drawing.Point(297, 337);
            this.rdoUnsuccessful.Name = "rdoUnsuccessful";
            this.rdoUnsuccessful.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoUnsuccessful.Size = new System.Drawing.Size(63, 24);
            this.rdoUnsuccessful.TabIndex = 43;
            this.rdoUnsuccessful.Text = "راسب";
            this.rdoUnsuccessful.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoUnsuccessful.UncheckedState.BorderThickness = 2;
            this.rdoUnsuccessful.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoUnsuccessful.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoActive.CheckedState.BorderThickness = 0;
            this.rdoActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoActive.CheckedState.InnerOffset = -4;
            this.rdoActive.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoActive.ForeColor = System.Drawing.Color.Black;
            this.rdoActive.Location = new System.Drawing.Point(394, 337);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoActive.Size = new System.Drawing.Size(53, 24);
            this.rdoActive.TabIndex = 42;
            this.rdoActive.Text = "نشط";
            this.rdoActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoActive.UncheckedState.BorderThickness = 2;
            this.rdoActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(476, 336);
            this.lblState.Name = "lblState";
            this.lblState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblState.Size = new System.Drawing.Size(45, 20);
            this.lblState.TabIndex = 41;
            this.lblState.Text = "الحالة:";
            // 
            // comboSection
            // 
            this.comboSection.BackColor = System.Drawing.Color.Transparent;
            this.comboSection.BorderRadius = 10;
            this.comboSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSection.FillColor = System.Drawing.SystemColors.ControlLight;
            this.comboSection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSection.ForeColor = System.Drawing.Color.Black;
            this.comboSection.ItemHeight = 30;
            this.comboSection.Location = new System.Drawing.Point(297, 246);
            this.comboSection.Name = "comboSection";
            this.comboSection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboSection.Size = new System.Drawing.Size(199, 36);
            this.comboSection.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(441, 212);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "الشعبة:";
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 770);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSection);
            this.Controls.Add(this.rdoUnsuccessful);
            this.Controls.Add(this.rdoActive);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSchoolYear);
            this.Controls.Add(this.comboSchoolYear);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.StudentImage);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.comboClassName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.dgvstudent);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentManagement";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnModifyStudent;
        private Guna.UI2.WinForms.Guna2Button btnRemoveStudent;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private Guna.UI2.WinForms.Guna2DataGridView dgvstudent;
        private Guna.UI2.WinForms.Guna2Button btnStudntDetails;
        private Guna.UI2.WinForms.Guna2ComboBox comboClassName;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label lblClassName;
        public Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        public Guna.UI2.WinForms.Guna2TextBox txtStudentName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthdate;
        private Guna.UI2.WinForms.Guna2RadioButton rdoFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rdoMale;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI2.WinForms.Guna2PictureBox StudentImage;
        private Guna.UI2.WinForms.Guna2Button btnAddImage;
        private System.Windows.Forms.Label lblSchoolYear;
        private Guna.UI2.WinForms.Guna2ComboBox comboSchoolYear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2RadioButton rdoUnsuccessful;
        private Guna.UI2.WinForms.Guna2RadioButton rdoActive;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private Guna.UI2.WinForms.Guna2ComboBox comboSection;
        private System.Windows.Forms.Label label2;
    }
}