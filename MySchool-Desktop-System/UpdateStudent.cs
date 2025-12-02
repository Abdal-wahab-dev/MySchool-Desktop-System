using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.BLL.Validation;
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
    public partial class UpdateStudent : BaseForm
    {
        private readonly StudentServices studentService = new StudentServices();

        

        private int studentId;
        private bool isLoading = false;
        private List<Section> allSections;
        public UpdateStudent( int StudentId)
        {
            InitializeComponent();
            studentId = StudentId;
            FillComboBoxes();
            txtStudentName.Validating += (s, e) => CheckName();
            txtAddress.Validating += (s, e) => CheckAddress();
            txtPhoneNumber.Validating += (s, e) => CheckPhone();
            comboSection.Validating += (s, e) => CheckSection();
            comboClassName.Validating += (s, e) => CheckClass();
            grpGender.Validating += (s, e) => CheckGender();
            dtpBirthdate.Validating += (s, e) => CheckBirthdate();
            grpState.Validating += (s, e) => CheckState();
        }


        
        private void FillComboBoxes()
        {
            try
            {
               
                List<SchoolClass> classes = studentService.GetAllClasses();
                comboClassName.DisplayMember = "ClassName";
                comboClassName.ValueMember = "SchoolClassId";
                comboClassName.DataSource = classes;

                
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
        private bool CheckName()
        {
            if (!txtStudentName.Text.IsRequired())
            {
                errorProvider1.SetError(txtStudentName, "الرجاء إدخال اسم المعلم");
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
        public void LoadStudentData(Student student)
        {

                
                

               
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
                    StudentImage.SizeMode = PictureBoxSizeMode.StretchImage; 
                }
                else
                {
                    StudentImage.Image = null; 
                }

            }
        private void Update_Click(object sender, EventArgs e)
        {
            bool isNameOk = CheckName();
            bool isAddressOk = CheckAddress();
            bool isPhoneOk = CheckPhone();
            bool isClassOk = CheckClass();
            bool isSection = CheckSection();
            bool isGenderOk = CheckGender();
            bool isStateOk = CheckState();
            bool isBirthdateOk = CheckBirthdate();
            


            if (isNameOk && isAddressOk && isPhoneOk && isGenderOk && isClassOk && isSection && isStateOk && isBirthdateOk )
            {
                try
                {

                    Student student = new Student();


                    student.StudentId = studentId;


                    student.StudentName = txtStudentName.Text;
                    student.PhoneNumber = txtPhoneNumber.Text;
                    student.Address = txtAddress.Text;


                    student.StudentClass = comboClassName.Text;


                    if (comboSection.SelectedValue != null)
                    {
                        student.SectionId = Convert.ToInt32(comboSection.SelectedValue);
                    }


                    student.Birthdate = dtpBirthdate.Value;



                    if (rdoMale.Checked) student.Gender = "ذكر";
                    else student.Gender = "أنثى";


                    if (rdoActive.Checked) student.StudentState = "نشط";
                    else student.StudentState = "راسب";


                    studentService.updateStudent(student);


                    MessageBox.Show("تم تحديث بيانات الطالب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ: " + ex.Message);
                }
            }
            else
            {

                MessageBox.Show("يرجى تصحيح الحقول المؤشر عليها باللون الأحمر.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
           
        }
    }
}
