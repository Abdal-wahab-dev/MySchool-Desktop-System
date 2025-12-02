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

namespace MySchool_Desktop_System
{
    public partial class DetailsFeeForm : BaseForm
    {
        private int studentId;
        public DetailsFeeForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        // ❌ تم حذف دالة ShowInPanel بالكامل

        private void DetailsFeeForm_Load(object sender, EventArgs e)
        {
            // ... يمكنك هنا وضع كود جلب بيانات الرسوم ...
        }

        public void LoadStudentDetails(Student student)
        {
            txtName.Text = student.StudentName;
            txtClass.Text = student.StudentClass;
        }
    }
}