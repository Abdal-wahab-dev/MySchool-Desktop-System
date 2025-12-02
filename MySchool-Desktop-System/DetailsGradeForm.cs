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
    public partial class DetailsGradeForm : BaseForm
    {
        private int studentId;
        public DetailsGradeForm(int StudentId)
        {
            InitializeComponent();
            studentId = StudentId;
        }

        
        private void DetailsGradeForm_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadStudentDetails(Student student)
        {
            txtName.Text = student.StudentName;
            txtClass.Text = student.StudentClass;
        }
    }
}
