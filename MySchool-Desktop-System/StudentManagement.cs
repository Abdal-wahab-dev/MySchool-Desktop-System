
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
using static System.Windows.Forms.AxHost;

namespace MySchool_Desktop_System
{
    public partial class StudentManagement : Form
    {

        private readonly StudentServices studentServices = new StudentServices();
        public StudentManagement()
        {
            InitializeComponent();

        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            List<SchoolClass> classes = studentServices.GetAllClasses();
            comboClassName.Items.Clear();
            comboClassName.DataSource = classes;
            comboClassName.DisplayMember = "ClassName";
            comboClassName.ValueMember = "SchoolClassId";
            dgvstudent.AutoGenerateColumns = false;
            dgvstudent.Columns["StudentId"].DataPropertyName = "StudentId";
            dgvstudent.Columns["StudentName"].DataPropertyName = "StudentName";
            dgvstudent.Columns["ClassName"].DataPropertyName = "StudentClass";
            dgvstudent.Columns["State"].DataPropertyName = "StudentState";
            dgvstudent.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";

            LoadStudent();
        }
        private void LoadStudent()
        {
            var students = studentServices.GetStudent();
            dgvstudent.DataSource = students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string state = "";
            if (rdoActive.Checked)
                state = "نشط";
            else if (rdoUnsuccessful.Checked) state = "راسب";
            string gender = "";
            if (rdoMale.Checked) gender = "ذكر";
            else if (rdoFemale.Checked) gender = "انثى";

            var student = new Student
            {
                StudentName = txtStudentName.Text,
                Address = txtAddress.Text,
                StudentClass = comboClassName.Text,
                SectionId = (int)comboSection.SelectedValue,
                PhoneNumber = txtPhoneNumber.Text,
                Birthdate = dtpBirthdate.Value,
                Gender = gender,
                StudentState = state,
                ImagePath = StudentImage.ImageLocation,

            };
            studentServices.addSudent(student);
            LoadStudent();
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
            if (dgvstudent.CurrentRow != null) {
                var student = (Student)dgvstudent.CurrentRow.DataBoundItem;

                string state = "";
                if (rdoActive.Checked)
                    state = "نشط";
                else if (rdoUnsuccessful.Checked) state = "راسب";
                string gender = "";
                if (rdoMale.Checked) gender = "ذكر";
                else if (rdoFemale.Checked) gender = "انثى";

                student.StudentName = txtStudentName.Text;
                student.Address = txtAddress.Text;
                student.StudentClass = comboClassName.Text;
                student.SectionId = (int)comboSection.SelectedValue;
                student.PhoneNumber = txtPhoneNumber.Text;
                student.Birthdate = dtpBirthdate.Value;
                student.Gender = gender;
                student.StudentState = state;
                student.ImagePath = StudentImage.ImageLocation;

                studentServices.updateStudent(student);
                LoadStudent();
            }
        }

        private void comboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClassName.SelectedValue != null)
            {

                int selectedClassId = (int)comboClassName.SelectedValue;

                List<Section> sections = studentServices.GetSectionFilter(selectedClassId);
                comboSection.DataSource = sections;
                comboSection.DisplayMember = "SectionName";
                comboSection.ValueMember = "SctionId";
            }
        }

        
    }
}
