using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.DAL.Model;

namespace MySchool_Desktop_System
{
    public partial class teacherManagement : Form
    {
        // يجب أن تكون الخدمة مهيأة
        private readonly TeacherService _teacherService = new TeacherService();

        public teacherManagement()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------------
        // دالة تحميل وربط البيانات
        // --------------------------------------------------------------------
        public void LoadTeachersData()
        {
            try
            {
                // 1. ضمان تعطيل توليد الأعمدة التلقائي 
                //    (هذا ضروري لأنك أنشأت الأعمدة يدوياً في المصمم)
                dgvTeachers.AutoGenerateColumns = false;

                // 2. تعيين خاصية DataPropertyName لكل عمود
                //    (نربط الأعمدة التي أنشأتها يدوياً بأسماء خصائص الكيان Teacher)

                // التأكد من أن اسم العمود في الـ DGV (الطرف الأيسر) يطابق الاسم الذي وضعته في المصمم
                // والتأكد من أن اسم الخاصية (الطرف الأيمن) يطابق اسم الخاصية في كلاس Teacher (حساس لحالة الأحرف)

                dgvTeachers.Columns["TeacherId"].DataPropertyName = "TeacherId";
                dgvTeachers.Columns["TeacherName"].DataPropertyName = "Name"; // يربط بعمود الاسم بـ خاصية Name في الكيان
                dgvTeachers.Columns["salary"].DataPropertyName = "salary";
                dgvTeachers.Columns["PhoneNumber"].DataPropertyName = "phoneNumber";

                // 3. استدعاء الخدمة لجلب قائمة المعلمين
                List<Teacher> teachers = _teacherService.GetTeachers();

                // 4. تعيين مصدر البيانات للـ DataGridView
                dgvTeachers.DataSource = teachers;

                // (اختياري) تحديث إجمالي عدد المعلمين
                if (label5 != null)
                {
                    label5.Text = teachers.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء تحميل بيانات المعلمين: {ex.Message}", "خطأ في التحميل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --------------------------------------------------------------------
        // حدث تحميل الفورم (Form Load Event)
        // --------------------------------------------------------------------
        private void teacherManagement_Load(object sender, EventArgs e)
        {
            // تحميل البيانات عند فتح الفورم
            LoadTeachersData();
        }

        // --------------------------------------------------------------------
        // حدث زر الإضافة (لإعادة التحميل بعد إضافة معلم جديد)
        // --------------------------------------------------------------------
        private void AddNewTeacher_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel parentPanel)
            {
                // 2. تمرير الـ Panel الأب، وتمرير (this) لتحديث البيانات لاحقاً
                addNewTeacher form = new addNewTeacher(parentPanel, this);
                form.ShowInPanel();
            }
            else
            {
                MessageBox.Show("لا يمكن العثور على اللوحة الرئيسية");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow != null)
            {
                var teacher = (Teacher)dgvTeachers.CurrentRow.DataBoundItem;

                // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                TeacherDeatials teacherDetails = new TeacherDeatials(this.Parent as Panel,teacher.TeacherId);

                // تمرير بيانات الطالب إذا أردت
                teacherDetails.LoadTeacherData(teacher);

                // عرض الفورم داخل الـ Panel
                teacherDetails.ShowInPanel();
            }
        }

        // ... (بقية الأحداث والدوال) ...
    }
}