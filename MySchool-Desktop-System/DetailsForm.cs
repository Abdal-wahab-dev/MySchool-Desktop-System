using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MySchool_Desktop_System
{
    public partial class DetailsForm : Form
    {

        private Panel parentPanel;

        public DetailsForm(Panel panel)
        {
            InitializeComponent();
            parentPanel = panel;
        }

        public void ShowInPanel()
        {
            this.TopLevel = false;           // لا يظهر كنافذة مستقلة
            this.Dock = DockStyle.Fill;      // يملأ مساحة الـ Panel بالكامل
            parentPanel.Controls.Add(this);  // إضافة الفورم للـ Panel
            this.BringToFront();             // يكون أمام كل شيء
            this.Show();
        }
        public void LoadStudentDetails(Student student)
        {
            if (student.SectionId == 1)
            {
                txtSection.Text = "أ";
            }
            else if (student.SectionId == 2)
            {
                txtSection.Text = "ب";
            }
            else if (student.SectionId == 3)
            {
                txtSection.Text = "ج";
            }
            else txtSection.Text = "د";

                txtNumber.Text = student.StudentId.ToString();
            txtName.Text = student.StudentName;
            txtPhoneNumber.Text = student.PhoneNumber;
            txtClass.Text = student.StudentClass;
            txtAddress.Text = student.Address;
            txtAge.Text = student.Birthdate.ToString();
            txtState.Text = student.StudentState;
            txtGendeer.Text = student.Gender;
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

        private void DetailsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void FeeDetails_Click(object sender, EventArgs e)
        {


                // إنشاء الفورم وإرساله نفس الـ Panel الموجود في MainForm
                DetailsForm detailsForm = new DetailsForm(this.Parent as Panel);

                // تمرير بيانات الطالب إذا أردت
                //detailsForm.LoadStudentDetails(student);

                // عرض الفورم داخل الـ Panel
                detailsForm.ShowInPanel();
            }
    }
}


