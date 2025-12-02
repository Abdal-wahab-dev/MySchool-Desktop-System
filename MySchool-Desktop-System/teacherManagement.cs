using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MySchool_Desktop_System
{
    public partial class teacherManagement : BaseForm
    {
        private readonly TeacherService _teacherService = new TeacherService();

      
        
        public teacherManagement()
        {
            InitializeComponent();
           
        }

        
        private MainForm GetMainForm()
        {
            return this.TopLevelControl as MainForm;
        }

        public void LoadTeachersData()
        {
            try
            {
                
                dgvTeachers.AutoGenerateColumns = false;
                dgvTeachers.Columns["TeacherId"].DataPropertyName = "TeacherId";
                dgvTeachers.Columns["TeacherName"].DataPropertyName = "Name"; 
                dgvTeachers.Columns["salary"].DataPropertyName = "salary";
                dgvTeachers.Columns["PhoneNumber"].DataPropertyName = "phoneNumber";

                List<Teacher> teachers = _teacherService.GetTeachers();
                dgvTeachers.DataSource = teachers;

                
                 if (label5 != null) { label5.Text = teachers.Count.ToString(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل بيانات المعلمين: {ex.Message}", "خطأ في التحميل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teacherManagement_Load(object sender, EventArgs e)
        {
            
            LoadTeachersData();
        }

         private void AddNewTeacher_Click(object sender, EventArgs e)
        {
            MainForm main = GetMainForm();
            if (main != null)
            {
                
                addNewTeacher form = new addNewTeacher(); 
                main.OpenForm(form); 
            }
            else
            {
                MessageBox.Show("لا يمكن العثور على اللوحة الرئيسية للتنقل.");
            }
        }

          private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow != null)
            {
                var teacher = (Teacher)dgvTeachers.CurrentRow.DataBoundItem;
                MainForm main = GetMainForm();
                
                if (main != null)
                {
                    
                    TeacherDeatials teacherDetails = new TeacherDeatials(teacher.TeacherId); 
                    
                    
                     teacherDetails.LoadTeacherData(teacher);

                    main.OpenForm(teacherDetails); 
                }
            }
        }

             private void btnRemove_Click(object sender, EventArgs e)
             {
            if (dgvTeachers.CurrentRow != null)
            {
                var teacher = (Teacher)dgvTeachers.CurrentRow.DataBoundItem;
                var result = MessageBox.Show($"هل تريد حذف المعلم {teacher.Name}؟",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _teacherService.RemoveTeacher(teacher);
                    LoadTeachersData(); 
                }
            }
        }
        
        
    }
}