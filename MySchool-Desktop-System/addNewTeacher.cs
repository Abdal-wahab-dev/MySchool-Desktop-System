using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.BLL.Validation;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Windows.Forms;

namespace MySchool_Desktop_System
{
    public partial class addNewTeacher : BaseForm
    {
        private readonly TeacherService teacherService = new TeacherService();

        
        public addNewTeacher()
        {
            InitializeComponent();

            
            txtName.Validating += (s, e) => CheckName();
            txtAddress.Validating += (s, e) => CheckAddress();
            txtPhone.Validating += (s, e) => CheckPhone();
            txtSalary.Validating += (s, e) => CheckSalary();
        }

        private bool CheckName()
        {
            if (!txtName.Text.IsRequired())
            {
                errorProvider1.SetError(txtName, "الرجاء إدخال اسم المعلم");
                return false;
            }
            if (!txtName.Text.IsValidNameFormat())
            {
                errorProvider1.SetError(txtName, "الاسم يجب أن يحتوي على حروف فقط");
                return false;
            }
            errorProvider1.SetError(txtName, ""); 
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
            if (!txtPhone.Text.IsDigitsOnly())
            {
                errorProvider1.SetError(txtPhone, "رقم الهاتف غير صحيح (أرقام فقط)");
                return false;
            }
            if (!txtPhone.Text.IsValidPhone(9))
            {
                errorProvider1.SetError(txtPhone, "رقم الهاتف يجب أن يتكون من 9 أرقام فقط");
                return false;
            }

            errorProvider1.SetError(txtPhone, ""); 
            return true;
        }

        
        private bool CheckSalary()
        {
            if (!txtSalary.Text.IsNumeric())
            {
                errorProvider1.SetError(txtSalary, "  الراتب يجب أن يكون قيمة رقمية ولايقل عن 20000");
                return false;
            }
            errorProvider1.SetError(txtSalary, "");
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
        private void SaveTeacher_Click_1(object sender, EventArgs e)
        {
            
            bool isNameOk = CheckName();
            bool isAddressOk = CheckAddress();
            bool isPhoneOk = CheckPhone();
            bool isSalaryOk = CheckSalary();
            bool isGenderOk = CheckGender();

            
            if (isNameOk && isAddressOk && isPhoneOk && isSalaryOk && isGenderOk)
            {
                try
                {
                    
                    var teacher = new Teacher
                    {
                        Name = txtName.Text.Trim(),
                        address = txtAddress.Text.Trim(),
                        phoneNumber = txtPhone.Text.Trim(),
                        dateGradute = dtpGraduateDate.Value,
                        Date = dtpDate.Value,
                        gender = rdoMale.Checked ? "ذكر" : "انثى",
                        salary = double.Parse(txtSalary.Text.Trim()) 
                    };

                    
                    teacherService.AddTeacher(teacher);

                    MessageBox.Show("تم إضافة المعلم بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFormControls();
                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء الحفظ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                MessageBox.Show("يرجى تصحيح الحقول المؤشر عليها باللون الأحمر.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void ClearFormControls()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtSalary.Clear();

            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            dtpGraduateDate.Value = DateTime.Today;
            dtpDate.Value = DateTime.Today;
        }

        private void addNewTeacher_Load(object sender, EventArgs e)
        {

        }

       
    }
}