namespace MySchool_Desktop_System
{
    partial class SubjectForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.dgvSubject = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.cmbClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSubTeacher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubDegree = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(61, 252);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 55);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvSubject
            // 
            this.dgvSubject.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSubject.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubject.ColumnHeadersHeight = 36;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectId,
            this.SubjectName,
            this.Degree,
            this.Teacher,
            this.ClassName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubject.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvSubject.Location = new System.Drawing.Point(16, 360);
            this.dgvSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.ReadOnly = true;
            this.dgvSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSubject.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSubject.RowHeadersVisible = false;
            this.dgvSubject.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSubject.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubject.RowTemplate.Height = 26;
            this.dgvSubject.Size = new System.Drawing.Size(1014, 160);
            this.dgvSubject.TabIndex = 73;
            this.dgvSubject.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvSubject.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvSubject.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSubject.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSubject.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSubject.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSubject.ThemeStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvSubject.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvSubject.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvSubject.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSubject.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubject.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubject.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSubject.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvSubject.ThemeStyle.ReadOnly = true;
            this.dgvSubject.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSubject.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSubject.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cambria", 10F);
            this.dgvSubject.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubject.ThemeStyle.RowsStyle.Height = 26;
            this.dgvSubject.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvSubject.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellClick);
            this.dgvSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubject_CellContentClick);
            // 
            // SubjectId
            // 
            this.SubjectId.HeaderText = "الرقم";
            this.SubjectId.MinimumWidth = 6;
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "اسم المادة";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // Degree
            // 
            this.Degree.HeaderText = "درجة المادة";
            this.Degree.MinimumWidth = 6;
            this.Degree.Name = "Degree";
            this.Degree.ReadOnly = true;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "معلم المادة";
            this.Teacher.MinimumWidth = 6;
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "الصف";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(228, 252);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 55);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "إضافة مادة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(228, 190);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 53);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "تعديل مادة";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(338, 157);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "الصف:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnRemove.BorderRadius = 10;
            this.btnRemove.BorderThickness = 1;
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(61, 190);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 53);
            this.btnRemove.TabIndex = 62;
            this.btnRemove.Text = "حذف مادة";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.Transparent;
            this.cmbClass.BorderColor = System.Drawing.Color.Silver;
            this.cmbClass.BorderRadius = 10;
            this.cmbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClass.ForeColor = System.Drawing.Color.Black;
            this.cmbClass.ItemHeight = 30;
            this.cmbClass.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cmbClass.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cmbClass.Location = new System.Drawing.Point(61, 142);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(260, 36);
            this.cmbClass.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(916, 276);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 70;
            this.label6.Text = "معلم المادة:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSubTeacher
            // 
            this.cmbSubTeacher.BackColor = System.Drawing.Color.Transparent;
            this.cmbSubTeacher.BorderColor = System.Drawing.Color.Silver;
            this.cmbSubTeacher.BorderRadius = 10;
            this.cmbSubTeacher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSubTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubTeacher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSubTeacher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSubTeacher.ForeColor = System.Drawing.Color.Black;
            this.cmbSubTeacher.ItemHeight = 30;
            this.cmbSubTeacher.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.cmbSubTeacher.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cmbSubTeacher.Location = new System.Drawing.Point(539, 271);
            this.cmbSubTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubTeacher.Name = "cmbSubTeacher";
            this.cmbSubTeacher.Size = new System.Drawing.Size(364, 36);
            this.cmbSubTeacher.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(916, 214);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 68;
            this.label5.Text = "درجة المادة:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubDegree
            // 
            this.txtSubDegree.BorderColor = System.Drawing.Color.Silver;
            this.txtSubDegree.BorderRadius = 10;
            this.txtSubDegree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubDegree.DefaultText = "";
            this.txtSubDegree.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubDegree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubDegree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubDegree.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubDegree.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubDegree.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubDegree.ForeColor = System.Drawing.Color.Black;
            this.txtSubDegree.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubDegree.Location = new System.Drawing.Point(539, 210);
            this.txtSubDegree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubDegree.Name = "txtSubDegree";
            this.txtSubDegree.PlaceholderText = "";
            this.txtSubDegree.SelectedText = "";
            this.txtSubDegree.Size = new System.Drawing.Size(364, 44);
            this.txtSubDegree.TabIndex = 67;
            // 
            // txtSubName
            // 
            this.txtSubName.BorderColor = System.Drawing.Color.Silver;
            this.txtSubName.BorderRadius = 10;
            this.txtSubName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubName.DefaultText = "";
            this.txtSubName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubName.ForeColor = System.Drawing.Color.Black;
            this.txtSubName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubName.Location = new System.Drawing.Point(539, 152);
            this.txtSubName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.PlaceholderText = "";
            this.txtSubName.SelectedText = "";
            this.txtSubName.Size = new System.Drawing.Size(364, 44);
            this.txtSubName.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(925, 157);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 65;
            this.label3.Text = "اسم المادة:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 55);
            this.panel1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدارة المواد الدراسية";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 770);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSubTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubDegree);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2ComboBox cmbClass;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubTeacher;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2TextBox txtSubDegree;
        public Guna.UI2.WinForms.Guna2TextBox txtSubName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}