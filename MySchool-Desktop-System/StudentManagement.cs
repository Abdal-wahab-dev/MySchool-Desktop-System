
using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.BLL.Validation;
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
    public partial class StudentManagement : BaseForm
    {
        private bool isLoading = false;
        private List<Section> allSections;


        private readonly StudentServices studentServices = new StudentServices();
        public StudentManagement()
        {

            InitializeComponent();
            menuStrip1.AutoSize = false;    // إيقاف الحجم التلقائي
            menuStrip1.Height = 50;
            txtStudentName.Validating += (s, e) => CheckName();
            txtAddress.Validating += (s, e) => CheckAddress();
            txtPhoneNumber.Validating += (s, e) => CheckPhone();
            comboSection.Validating += (s, e) => CheckSection();
            comboClassName.Validating += (s, e) => CheckClass();
            grpGender.Validating += (s, e) => CheckGender();
            dtpBirthdate.Validating += (s, e) => CheckBirthdate();
            grpState.Validating += (s, e) => CheckState();// الارتفاع الجديد


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
        private bool CheckName()
        {
            if (!txtStudentName.Text.IsRequired())
            {
                errorProvider1.SetError(txtStudentName, "الرجاء إدخال اسم الطالب");
                return false;
            }
            if (!txtStudentName.Text.IsValidNameFormat())
            {
                errorProvider1.SetError(txtStudentName, "الاسم يجب أن يحتوي على حروف فقط");
                return false;
            }
            errorProvider1.SetError(txtStudentName, "");
            return true;
        }
        private bool CheckAddress()
        {
            if (!txtAddress.Text.IsRequired())
            {
                errorProvider1.SetError(txtAddress, "العنوان مطلوب");
                return false;
            }
            errorProvider1.SetError(txtAddress, "");
            return true;
        }
        private bool CheckPhone()
        {
            if (!txtPhoneNumber.Text.IsDigitsOnly())
            {
                errorProvider1.SetError(txtPhoneNumber, "رقم الهاتف غير صحيح (أرقام فقط)");
                return false;
            }
            if (!txtPhoneNumber.Text.IsValidPhone(9))
            {
                errorProvider1.SetError(txtPhoneNumber, "رقم الهاتف يجب أن يتكون من 9 أرقام فقط");
                return false;
            }

            errorProvider1.SetError(txtPhoneNumber, "");
            return true;
        }
        private bool CheckGender()
        {
            if (!ValidationExtensions.IsValidGenderSelected(rdoMale.Checked, rdoFemale.Checked))
            {
                errorProvider1.SetError(rdoFemale, "يجب اختيار الجنس");
                return false;
            }
            errorProvider1.SetError(rdoFemale, "");
            return true;
        }
        private bool CheckState()
        {
            if (!ValidationExtensions.IsValidGenderSelected(rdoActive.Checked, rdoUnsuccessful.Checked))
            {
                errorProvider1.SetError(rdoUnsuccessful, "يجب اختيار الحالة");
                return false;
            }
            errorProvider1.SetError(rdoUnsuccessful, "");
            return true;
        }
        private bool CheckClass()
        {
            string selectedValue = comboClassName.SelectedValue?.ToString();


            if (!selectedValue.IsIdSelected())
            {
                errorProvider1.SetError(comboClassName, "الرجاء اختيار الصف");
                return false;
            }

            errorProvider1.SetError(comboClassName, "");
            return true;
        }

        private bool CheckSection()
        {
            string selectedValue = comboSection.SelectedValue?.ToString();


            if (!selectedValue.IsIdSelected())
            {
                errorProvider1.SetError(comboSection, "الرجاء اختيار الشعبة");
                return false;
            }

            errorProvider1.SetError(comboSection, "");
            return true;
        }

        private bool CheckBirthdate()
        {
            string selectedValue = dtpBirthdate.Value.ToString();


            if (!selectedValue.IsIdSelected())
            {
                errorProvider1.SetError(dtpBirthdate, "الرجاء اختيار التاريخ");
                return false;
            }

            errorProvider1.SetError(dtpBirthdate, "");
            return true;
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            bool isNameOk = CheckName();
            bool isAddressOk = CheckAddress();
            bool isPhoneOk = CheckPhone();
            bool isClassOk = CheckClass();
            bool isSection = CheckSection();
            bool isGenderOk = CheckGender();
            bool isStateOk = CheckState();
            bool isBirthdateOk = CheckBirthdate();

            if (isNameOk && isAddressOk && isPhoneOk && isGenderOk && isClassOk && isSection && isStateOk && isBirthdateOk)
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
            else
            {

                MessageBox.Show("يرجى تصحيح الحقول المؤشر عليها باللون الأحمر.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (this.TopLevelControl is MainForm mainForm)
            {
                // التأكد من اختيار طالب
                if (dgvstudent.CurrentRow != null)
                {
                    // استخراج كائن الطالب من السطر المحدد
                    var student = (Student)dgvstudent.CurrentRow.DataBoundItem;

                    // التحقق من أن الفورم الحالي موجود داخل Panel لتجنب الأخطاء

                    // 1. إنشاء فورم التعديل
                    // نمرر: الـ Panel، رقم الطالب، ودالة إعادة تحميل الجدول (LoadStudent)
                    UpdateStudent updateForm = new UpdateStudent(student.StudentId);

                    // 2. تعبئة البيانات (اختياري، لأنك غالباً تجلبها داخل UpdateStudent عبر الـ ID)
                    updateForm.LoadStudentData(student);

                    // 3. عرض الفورم
                    mainForm.OpenForm(updateForm);
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
       
        private void btnStudntDetails_Click(object sender, EventArgs e)
        {
            

        }

        private void تفاصيلعامةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopLevelControl is MainForm mainForm)
            {
                 if (dgvstudent.CurrentRow != null)
                {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;
                
                    // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                    DetailsForm detailsForm = new DetailsForm();
                    mainForm.OpenForm(detailsForm);

                    // تمرير بيانات الطالب إذا أردت
                    detailsForm.LoadStudentDetails(student);
                }
                // عرض الفورم داخل الـ Panel
                
            }
        }

        private void تفاصيلالرسومToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopLevelControl is MainForm mainForm)
            {
                if (dgvstudent.CurrentRow != null)
                {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;
                
                    // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                    DetailsFeeForm detailsForm = new DetailsFeeForm(student.StudentId);
                    detailsForm.LoadStudentDetails(student);
                    mainForm.OpenForm(detailsForm);
                }

                    //detailsForm.LoadStudentDetails(student);

                    // عرض الفورم داخل الـ Panel

                }
        }

        private void تفاصيلالدرجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopLevelControl is MainForm mainForm)
            {
                if (dgvstudent.CurrentRow != null)
                {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;
                
                    // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                    DetailsGradeForm detailsForm = new DetailsGradeForm(student.StudentId);
                    detailsForm.LoadStudentDetails(student);
                    mainForm.OpenForm(detailsForm);
                }
                // تمرير بيانات الطالب إذا أردت
                //detailsForm.LoadStudentDetails(student);

                // عرض الفورم داخل الـ Panel

            }
        }
    }
}
