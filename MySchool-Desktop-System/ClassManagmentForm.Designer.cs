namespace MySchool_Desktop_System
{
    partial class ClassManagmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubTeacher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvClasses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassBreader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowSection = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnShowSubject = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 45);
            this.panel1.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(350, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدارة الفصول الدراسية";
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
            this.cmbSubTeacher.Location = new System.Drawing.Point(505, 173);
            this.cmbSubTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSubTeacher.Name = "cmbSubTeacher";
            this.cmbSubTeacher.Size = new System.Drawing.Size(313, 36);
            this.cmbSubTeacher.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(824, 173);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "معلم الصف:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(824, 100);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "اسم الصف:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.txtSubName.Location = new System.Drawing.Point(505, 100);
            this.txtSubName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.PlaceholderText = "";
            this.txtSubName.SelectedText = "";
            this.txtSubName.Size = new System.Drawing.Size(312, 36);
            this.txtSubName.TabIndex = 73;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvClasses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClasses.ColumnHeadersHeight = 36;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassId,
            this.ClassName,
            this.ClassBreader,
            this.SectionNumber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClasses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvClasses.Location = new System.Drawing.Point(12, 257);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClasses.RowHeadersVisible = false;
            this.dgvClasses.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClasses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClasses.RowTemplate.Height = 26;
            this.dgvClasses.Size = new System.Drawing.Size(869, 130);
            this.dgvClasses.TabIndex = 74;
            this.dgvClasses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
            this.dgvClasses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvClasses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClasses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClasses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClasses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClasses.ThemeStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvClasses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.dgvClasses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvClasses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClasses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClasses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClasses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClasses.ThemeStyle.HeaderStyle.Height = 36;
            this.dgvClasses.ThemeStyle.ReadOnly = true;
            this.dgvClasses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClasses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClasses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cambria", 10F);
            this.dgvClasses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClasses.ThemeStyle.RowsStyle.Height = 26;
            this.dgvClasses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvClasses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ClassId
            // 
            this.ClassId.HeaderText = "الرقم";
            this.ClassId.MinimumWidth = 6;
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "اسم  الصف";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // ClassBreader
            // 
            this.ClassBreader.HeaderText = "مربي الصف";
            this.ClassBreader.MinimumWidth = 6;
            this.ClassBreader.Name = "ClassBreader";
            this.ClassBreader.ReadOnly = true;
            // 
            // SectionNumber
            // 
            this.SectionNumber.HeaderText = "عدد الشعب ";
            this.SectionNumber.MinimumWidth = 6;
            this.SectionNumber.Name = "SectionNumber";
            this.SectionNumber.ReadOnly = true;
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
            this.btnAdd.Location = new System.Drawing.Point(317, 188);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 45);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.Text = "اضافة ";
            // 
            // btnShowSection
            // 
            this.btnShowSection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnShowSection.BorderRadius = 10;
            this.btnShowSection.BorderThickness = 1;
            this.btnShowSection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowSection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowSection.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowSection.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSection.ForeColor = System.Drawing.Color.Black;
            this.btnShowSection.Location = new System.Drawing.Point(163, 188);
            this.btnShowSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowSection.Name = "btnShowSection";
            this.btnShowSection.Size = new System.Drawing.Size(133, 45);
            this.btnShowSection.TabIndex = 77;
            this.btnShowSection.Text = "الشعب";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnShowSubject
            // 
            this.btnShowSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(77)))), ((int)(((byte)(118)))));
            this.btnShowSubject.BorderRadius = 10;
            this.btnShowSubject.BorderThickness = 1;
            this.btnShowSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowSubject.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowSubject.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSubject.ForeColor = System.Drawing.Color.Black;
            this.btnShowSubject.Location = new System.Drawing.Point(163, 129);
            this.btnShowSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowSubject.Name = "btnShowSubject";
            this.btnShowSubject.Size = new System.Drawing.Size(133, 45);
            this.btnShowSubject.TabIndex = 78;
            this.btnShowSubject.Text = "عرض المواد";
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
            this.btnRemove.Location = new System.Drawing.Point(317, 129);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(133, 45);
            this.btnRemove.TabIndex = 79;
            this.btnRemove.Text = "حذف فصل ";
            // 
            // ClassManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 587);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnShowSubject);
            this.Controls.Add(this.btnShowSection);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSubTeacher);
            this.Controls.Add(this.panel1);
            this.Name = "ClassManagmentForm";
            this.Text = "ClassManagmentForm";
            this.Load += new System.EventHandler(this.ClassManagmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSubTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtSubName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClasses;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnShowSection;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnShowSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassBreader;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNumber;
    }
}