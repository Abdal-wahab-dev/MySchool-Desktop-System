using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MySchool_Desktop_System
{
    public partial class UpdateStudent : Form
    {
        private readonly StudentServices studentService = new StudentServices();

        private Panel parentPanel;

        private int studentId;
        private bool isLoading = false;
        private List<Section> allSections;
        public UpdateStudent(Panel panel, int StudentId)
        {
            InitializeComponent();
            parentPanel = panel;
            studentId = StudentId;
            FillComboBoxes();
        }

        public void ShowInPanel()
        {
            this.TopLevel = false;           // لا يظهر كنافذة مستقلة
            this.Dock = DockStyle.Fill;      // يملأ مساحة الـ Panel بالكامل
            this.FormBorderStyle = FormBorderStyle.None; // إزالة الحدود ليتناسق مع التصميم
            parentPanel.Controls.Add(this);  // إضافة الفورم للـ Panel
            this.BringToFront();             // يكون أمام كل شيء
            this.Show();
        }
        private void FillComboBoxes()
        {
            try
            {
                // جلب الصفوف
                List<SchoolClass> classes = studentService.GetAllClasses();
                comboClassName.DisplayMember = "ClassName";
                comboClassName.ValueMember = "SchoolClassId";
                comboClassName.DataSource = classes;

                // جلب الشعب
                allSections = studentService.GetAllSections();
                comboSection.DisplayMember = "SectionName";
                comboSection.ValueMember = "SectionId";
                comboSection.DataSource = allSections;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل القوائم: " + ex.Message);
            }
        }
        public void LoadStudentData(Student student)
        {

                // 1. تجهيز كائن المعلم بالبيانات الجديدة من الشاشة
                

                // مهم جداً: يجب تحديد الـ ID لنعرف من هو المعلم الذي يتم تحديثه
                student.StudentId = studentId;


                //if (student.SectionId == 1)
                //{
                //    txtSection.Text = "أ";
                //}
                //else if (student.SectionId == 2)
                //{
                //    txtSection.Text = "ب";
                //}
                //else if (student.SectionId == 3)
                //{
                //    txtSection.Text = "ج";
                //}
                //else txtSection.Text = "د";

                //txtNumber.Text = student.StudentId.ToString();
                txtStudentName.Text = student.StudentName;
                txtPhoneNumber.Text = student.PhoneNumber;
                comboClassName.Text = student.StudentClass;
                comboSection.Text = student.Section.ToString();
                txtAddress.Text = student.Address;
                dtpBirthdate.Value = student.Birthdate;

                if (student.Gender == "ذكر")
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = true;
                }
                if (student.StudentState == "نشط")
                {
                    rdoActive.Checked = true;
                }
                else
                {
                    rdoUnsuccessful.Checked = true;
                }
                if (!string.IsNullOrEmpty(student.ImagePath) && System.IO.File.Exists(student.ImagePath))
                {
                    StudentImage.Image = Image.FromFile(student.ImagePath);
                    StudentImage.SizeMode = PictureBoxSizeMode.StretchImage; // أو Zoom حسب الحاجة
                }
                else
                {
                    StudentImage.Image = null; // إذا لم يوجد صورة
                }

            }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. تجهيز كائن الطالب
                Student student = new Student();

                // تحديد الـ ID
                student.StudentId = studentId;

                // تعبئة البيانات النصية
                student.StudentName = txtStudentName.Text;
                student.PhoneNumber = txtPhoneNumber.Text;
                student.Address = txtAddress.Text;

                // تعبئة القوائم المنسدلة
                student.StudentClass = comboClassName.Text; // أو SelectedValue حسب تصميمك

                // تحويل SectionId إلى رقم (إذا كان الـ ValueMember مضبوطاً على Id)
                if (comboSection.SelectedValue != null)
                {
                    student.SectionId = Convert.ToInt32(comboSection.SelectedValue);
                }

                // ---------------------------------------------------------
                // ✅ تصحيح التاريخ: نأخذ القيمة من الأداة ونضعها في الطالب
                // ---------------------------------------------------------
                student.Birthdate = dtpBirthdate.Value;


                // تحديد الجنس
                if (rdoMale.Checked) student.Gender = "ذكر";
                else student.Gender = "أنثى"; // أو القيمة الإنجليزية حسب قاعدة البيانات

                // تحديد الحالة
                if (rdoActive.Checked) student.StudentState = "نشط";
                else student.StudentState = "غير نشط"; // أو راسب حسب المنطق لديك

                // 2. استدعاء الخدمة للتحديث
                studentService.updateStudent(student);

                // 3. رسالة نجاح وإغلاق
                MessageBox.Show("تم تحديث بيانات الطالب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }
        

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            //isLoading = true;
            //List<SchoolClass> classes = studentService.GetAllClasses();
            //comboClassName.Items.Clear();
            //comboClassName.DisplayMember = "ClassName";
            //comboClassName.ValueMember = "SchoolClassId";
            //comboClassName.DataSource = classes;

            //allSections = studentService.GetAllSections(); // دالة جديدة أو موجودة
            //comboSection.DisplayMember = "SectionName";
            //comboSection.ValueMember = "SectionId"; // تأكد من الاسم الصحيح
            //comboSection.DataSource = allSections;
        }
    }
}
