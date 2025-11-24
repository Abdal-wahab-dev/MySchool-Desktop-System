using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.BLL.Validation;
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
    public partial class ClassManagmentForm : Form
    {
        private readonly classesServices _service = new classesServices();
        private readonly TeacherService t_service = new TeacherService();

        private int _currentId = 0;
        public ClassManagmentForm()
        {
            InitializeComponent();
            txtSubName.Validating += (s, e) => CheckName();
           
            cmbSubTeacher.Validating += (s, e) => CheckTeacher();
            SetupGridColumns();
            LoadComboBoxes();
            LoadGrid();

        }
        private bool CheckName()
        {
            if (!txtSubName.Text.IsRequired())
            {
                errorProvider1.SetError(txtSubName, "الرجاء إدخال اسم  الصف");
                return false;
            }
            if (!txtSubName.Text.IsValidNameFormat())
            {
                errorProvider1.SetError(txtSubName, "الاسم يجب أن يحتوي على حروف فقط");
                return false;
            }
            errorProvider1.SetError(txtSubName, "");
            return true;
        }
        private bool CheckTeacher()
        {
            string selectedValue = cmbSubTeacher.SelectedValue?.ToString();


            if (!selectedValue.IsIdSelected())
            {
                errorProvider2.SetError(cmbSubTeacher, "الرجاء اختيار المعلم");
                return false;
            }

            errorProvider2.SetError(cmbSubTeacher, "");
            return true;
        }
        private void LoadComboBoxes()
        { 
            cmbSubTeacher.DataSource = t_service.GetTeachers();
            cmbSubTeacher.DisplayMember = "Name";
            cmbSubTeacher.ValueMember = "TeacherId";
            cmbSubTeacher.SelectedIndex = -1;
        }
        private void SetupGridColumns()
        {
            dgvClasses.AutoGenerateColumns = false;



            if (dgvClasses.Columns["ClassId"] != null)
                dgvClasses.Columns["ClassId"].DataPropertyName = "Id";




            if (dgvClasses.Columns["ClassName"] != null)
                dgvClasses.Columns["ClassName"].DataPropertyName = "Classes";


            if (dgvClasses.Columns["ClassBreader"] != null)
                dgvClasses.Columns["ClassBreader"].DataPropertyName = "Teachers";
            if (dgvClasses.Columns["SectionsCountColumn"] != null)
            {
                dgvClasses.Columns["SectionsCountColumn"].DataPropertyName = "SectionsCount";
            }
        }

        private void LoadGrid()
        {
           
            
            dgvClasses.DataSource = _service.getAllClasses();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClassManagmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
