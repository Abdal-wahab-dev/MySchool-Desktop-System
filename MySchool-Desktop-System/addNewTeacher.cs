using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MySchool_Desktop_System
{
    public partial class addNewTeacher : Form
    {
        // تهيئة طبقة الخدمة للتعامل مع منطق المعلمين
        private readonly TeacherService teacherService = new TeacherService();

        // متغير لحفظ الـ Panel الأب الذي يُعرض فيه هذا الفورم
        private Panel parentPanel;
        public teacherManagement managementForm;

        public addNewTeacher(Panel panel, teacherManagement form)
        {
            InitializeComponent();
            parentPanel = panel;
            managementForm = form;
        }

        // دالة لعرض الفورم داخل الـ Panel
        public void ShowInPanel()
        {
            this.TopLevel = false;           // لا يظهر كنافذة مستقلة
            this.Dock = DockStyle.Fill;      // يملأ مساحة الـ Panel بالكامل
            this.FormBorderStyle = FormBorderStyle.None; // إزالة الحدود ليتناسق مع التصميم
            parentPanel.Controls.Add(this);  // إضافة الفورم للـ Panel
            this.BringToFront();             // يكون أمام كل شيء
            this.Show();
        }

        // حدث زر الحفظ
        private void SaveTeacher_Click(object sender, EventArgs e)
        {
           
          
        }
        

        // دالة لتنظيف الحقول
        private void ClearFormControls()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtSalary.Clear();

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            dtpGraduateDate.Value = DateTime.Today;
            dtpDate.Value = DateTime.Today;
        }

        // زر الرجوع أو الإلغاء (اختياري - إذا كان لديك زر للعودة)
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveTeacher_Click_1(object sender, EventArgs e)
        {

            string gender = "";
            if (rdoMale.Checked) gender = "ذكر";
            else if (rdoFemale.Checked) gender = "انثى";


            var teacher = new Teacher
            {
                Name = txtName.Text.Trim(),
                address = txtAddress.Text.Trim(),
                phoneNumber = txtPhone.Text.Trim(),
                dateGradute = dtpGraduateDate.Value,
                Date = dtpDate.Value,
                gender = gender,
                salary = double.Parse(txtSalary.Text.Trim())



            };
            teacherService.AddTeacher(teacher);
            managementForm.LoadTeachersData();

            // 6. رسالة النجاح
            MessageBox.Show("تم إضافة المعلم بنجاح وتخزين البيانات في قاعدة البيانات.", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تفريغ الحقول لإضافة معلم آخر
            ClearFormControls();

            // ملاحظة: لتحديث الجدول في الشاشة السابقة، ستحتاج إلى إعادة تحميل البيانات في الفورم الأب.
        }
    }
}