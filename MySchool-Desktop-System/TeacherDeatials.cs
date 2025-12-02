using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.BLL.Validation;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace MySchool_Desktop_System
{
    public partial class TeacherDeatials : BaseForm
    {
        private readonly TeacherService teacherService = new TeacherService();

        

        private int teacherId;

  
        public TeacherDeatials( int TeacherId)
        {
            InitializeComponent();
            teacherId = TeacherId;

            txtName.Validating += (s, e) => CheckName();
            txtAddress.Validating += (s, e) => CheckAddress();
            txtPhoneNumber.Validating += (s, e) => CheckPhone();
            txtSalary.Validating += (s, e) => CheckSalary();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
        public void LoadTeacherData(Teacher teacher)
        {
            
            txtName.Text =teacher.Name;
            txtPhoneNumber.Text = teacher.phoneNumber;
            txtAddress.Text = teacher.address;
            txtSalary.Text = teacher.salary.ToString();
            dtpGraduateDate.Value = teacher.dateGradute;
            Date.Value = teacher.Date;

            if (teacher.gender == "ذكر")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }

        }
        private void TeacherDeatials_Load(object sender, EventArgs e)
        {
           
        }

        private void Update_Click(object sender, EventArgs e)
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

                    Teacher updatedTeacher = new Teacher();


                    updatedTeacher.TeacherId = teacherId;

                    updatedTeacher.Name = txtName.Text;
                    updatedTeacher.phoneNumber = txtPhoneNumber.Text;
                    updatedTeacher.address = txtAddress.Text;
                    updatedTeacher.dateGradute = dtpGraduateDate.Value;
                    updatedTeacher.Date = Date.Value;


                    if (rdoMale.Checked) updatedTeacher.gender = "Male";
                    else updatedTeacher.gender = "Female";


                    if (double.TryParse(txtSalary.Text, out double sal))
                    {
                        updatedTeacher.salary = sal;
                    }
                    else
                    {
                        MessageBox.Show("الرجاء إدخال رقم صحيح للراتب.");
                        return;
                    }

                    teacherService.UpdateTeacher(updatedTeacher);


                    MessageBox.Show("تم تحديث بيانات المعلم بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (ArgumentException ex)
                {

                    MessageBox.Show(ex.Message, "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (KeyNotFoundException ex)
                {

                    MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("يرجى تصحيح الحقول المؤشر عليها باللون الأحمر.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

