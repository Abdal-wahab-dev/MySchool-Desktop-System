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
    public partial class DetailsForm : BaseForm
    {
        // ❌ لم نعد نحتاج لتخزين الـ Panel كمتغير، لأنه يتم التعامل معه في MainForm

        // ✅ تم تبسيط الـ Constructor
        public DetailsForm()
        {
            InitializeComponent();
            // ❌ تم حذف parentPanel = panel;
        }

        // ❌ دالة ShowInPanel لم تعد ضرورية، سيتم حذفها أو عدم استخدامها

        // ✅ دالة تحميل بيانات الطالب (مع تصحيح التاريخ)
        public void LoadStudentDetails(Student student)
        {
            // منطق تحديد الشعبة بناءً على الـ ID يبقى كما هو
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

            // ✅ تصحيح التاريخ: تأكد من أن Birthdate ليس فارغاً قبل تحويله لنص
            if (student.Birthdate != null)
            {
                // إذا كنت تعرض العمر: (DateTime.Now.Year - student.Birthdate.Value.Year).ToString();
                // إذا كنت تعرض التاريخ: 
                txtAge.Text = student.Birthdate.ToString();
            }

            txtState.Text = student.StudentState;
            txtGendeer.Text = student.Gender;

            // ... (باقي كود الصورة يبقى كما هو) ...
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            // ...
        }

    }
}