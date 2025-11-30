
using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace MySchool_Desktop_System
{
    public partial class StudentManagement : Form
    {
        private bool isLoading = false;
        private List<Section> allSections;


        private readonly StudentServices studentServices = new StudentServices();
        public StudentManagement()
        {

            InitializeComponent();
            menuStrip1.AutoSize = false;    // إيقاف الحجم التلقائي
            menuStrip1.Height = 50;         // الارتفاع الجديد


        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            isLoading = true;
            

            // جلب الصفوف
            List<SchoolClass> classes = studentServices.GetAllClasses();

            comboClassName.Items.Clear();
            comboClassName.DisplayMember = "ClassName";
            comboClassName.ValueMember = "SchoolClassId";
            comboClassName.DataSource = classes;

            // جلب الشعب مرة واحدة لكل الصفوف
            allSections = studentServices.GetAllSections(); // دالة جديدة أو موجودة
            comboSection.DisplayMember = "SectionName";
            comboSection.ValueMember = "SectionId"; // تأكد من الاسم الصحيح
            comboSection.DataSource = allSections;

            isLoading = false;
          
            dgvstudent.AutoGenerateColumns = false;
           
          // لضبط الارتفاع حسب النص
            dgvstudent.Columns["StudentId"].DataPropertyName = "StudentId";
            dgvstudent.Columns["StudentName"].DataPropertyName = "StudentName";
            dgvstudent.Columns["ClassName"].DataPropertyName = "StudentClass";
            dgvstudent.Columns["State"].DataPropertyName = "StudentState";
            dgvstudent.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
           // لضبط الارتفاع حسب النص

            LoadStudent();
        }


        private void LoadStudent()
        {
            List<Student> students = studentServices.GetStudent();
            dgvstudent.DataSource = students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // التحقق من صحة المدخلات الأساسية
                if (string.IsNullOrWhiteSpace(txtStudentName.Text))
                {
                    MessageBox.Show("الرجاء إدخال اسم الطالب");
                    return;
                }

                if (comboSection.SelectedValue == null)
                {
                    MessageBox.Show("الرجاء اختيار الشعبة");
                    return;
                }

                // تحديد الحالة
                string state = rdoActive.Checked ? "نشط" : "راسب"; // افتراضي

                // تحديد الجنس
                string gender = rdoMale.Checked ? "ذكر" : "انثى";

                var student = new Student
                {
                    StudentName = txtStudentName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    StudentClass = comboClassName.Text,

                    // تحويل آمن للـ ID
                    SectionId = Convert.ToInt32(comboSection.SelectedValue),

                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Birthdate = dtpBirthdate.Value,
                    Gender = gender,
                    StudentState = state,
                    ImagePath = StudentImage.ImageLocation,
                };

                studentServices.addSudent(student);

                MessageBox.Show("تمت الإضافة بنجاح");

                // إعادة تحميل الجدول لرؤية الطالب الجديد
                LoadStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الإضافة: " + ex.Message);
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StudentImage.ImageLocation = ofd.FileName;

                }
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (dgvstudent.CurrentRow != null)
            {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;
                var result = MessageBox.Show($"هل تريد حذف الطالب {student.StudentName}؟",
                    "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    studentServices.removeSudent(student);
                    LoadStudent();
                }
            }
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
           
 // التأكد من اختيار طالب
            if (dgvstudent.CurrentRow != null)
            {
                // استخراج كائن الطالب من السطر المحدد
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;

                // التحقق من أن الفورم الحالي موجود داخل Panel لتجنب الأخطاء
                if (this.Parent is Panel parentPanel)
                {
                    // 1. إنشاء فورم التعديل
                    // نمرر: الـ Panel، رقم الطالب، ودالة إعادة تحميل الجدول (LoadStudent)
                    UpdateStudent updateForm = new UpdateStudent(parentPanel, student.StudentId);

                    // 2. تعبئة البيانات (اختياري، لأنك غالباً تجلبها داخل UpdateStudent عبر الـ ID)
                    updateForm.LoadStudentData(student);

                    // 3. عرض الفورم
                    updateForm.ShowInPanel();
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار طالب لتعديله");
            }
        }

        // متغير على مستوى الفورم لتخزين الطالب الحالي
        private Student currentStudent = null;

        // حدث عند الضغط على صف في DataGridView
        private void dgvstudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvstudent.CurrentRow != null)
            {
                // جلب معرف الطالب فقط من الصف
                int studentId = (int)dgvstudent.CurrentRow.Cells["StudentId"].Value;

                // جلب البيانات الكاملة من قاعدة البيانات
                currentStudent = studentServices.showDetails(studentId); // دالة Service ترجع Student كامل

                if (currentStudent != null)
                {
                    // تعبئة حقول الإدخال بالقيم
                    txtStudentName.Text = currentStudent.StudentName;
                    txtAddress.Text = currentStudent.Address;
                    comboClassName.Text = currentStudent.StudentClass;
                    comboSection.SelectedValue = currentStudent.SectionId;
                    txtPhoneNumber.Text = currentStudent.PhoneNumber;
                    dtpBirthdate.Value = currentStudent.Birthdate;

                    // تحديد الجنس
                    rdoMale.Checked = currentStudent.Gender == "ذكر";
                    rdoFemale.Checked = currentStudent.Gender == "انثى";

                    // تحديد الحالة
                    rdoActive.Checked = currentStudent.StudentState == "نشط";
                    rdoUnsuccessful.Checked = currentStudent.StudentState == "راسب";

                    // عرض الصورة
                    if (!string.IsNullOrEmpty(currentStudent.ImagePath))
                        StudentImage.ImageLocation = currentStudent.ImagePath;
                    else
                        StudentImage.Image = null; // أو صورة افتراضية
                }
            }
        }


        private void comboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (isLoading) return;

            //if (comboClassName.SelectedValue != null)
            //{

            //    int selectedClassId = Convert.ToInt32(comboClassName.SelectedValue);


            //    List<Section> sections = studentServices.GetSectionFilter(selectedClassId);
            //    MessageBox.Show($"عدد الشعب: {sections.Count}");
            //    //comboSection.DataSource = sections;
            //    comboSection.DisplayMember = "SectionName";
            //    comboSection.ValueMember = "SctionId";
            //    comboSection.DataSource = sections;
            //}
        }
       
        private void btnStudntDetails_Click(object sender, EventArgs e)
        {
            

        }

        private void تفاصيلعامةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvstudent.CurrentRow != null)
            {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;

                // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                DetailsForm detailsForm = new DetailsForm(this.Parent as Panel);

                // تمرير بيانات الطالب إذا أردت
                detailsForm.LoadStudentDetails(student);

                // عرض الفورم داخل الـ Panel
                detailsForm.ShowInPanel();
            }
        }

        private void تفاصيلالرسومToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvstudent.CurrentRow != null)
            {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;

                // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                DetailsFeeForm detailsForm = new DetailsFeeForm(this.Parent as Panel);

                // تمرير بيانات الطالب إذا أردت
                //detailsForm.LoadStudentDetails(student);

                // عرض الفورم داخل الـ Panel
                detailsForm.ShowInPanel();
            }
        }

        private void تفاصيلالدرجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvstudent.CurrentRow != null)
            {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;

                // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                DetailsGradeForm detailsForm = new DetailsGradeForm (this.Parent as Panel);

                // تمرير بيانات الطالب إذا أردت
                //detailsForm.LoadStudentDetails(student);

                // عرض الفورم داخل الـ Panel
                detailsForm.ShowInPanel();
            }
        }
    }
}
