using SchoolManagementSystem.BLL.Services;
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
    public partial class TeacherDeatials : Form
    {
        private readonly TeacherService teacherService = new TeacherService();

        private Panel parentPanel;

        private int teacherId;
  
        public TeacherDeatials(Panel panel, int TeacherId)
        {
            InitializeComponent();
            parentPanel = panel;
            teacherId = TeacherId;
            


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
        public void ShowInPanel()
        {
            this.TopLevel = false;           // لا يظهر كنافذة مستقلة
            this.Dock = DockStyle.Fill;      // يملأ مساحة الـ Panel بالكامل
            this.FormBorderStyle = FormBorderStyle.None; // إزالة الحدود ليتناسق مع التصميم
            parentPanel.Controls.Add(this);  // إضافة الفورم للـ Panel
            this.BringToFront();             // يكون أمام كل شيء
            this.Show();
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
         
            try
            {
                // 1. تجهيز كائن المعلم بالبيانات الجديدة من الشاشة
                Teacher updatedTeacher = new Teacher();

                // مهم جداً: يجب تحديد الـ ID لنعرف من هو المعلم الذي يتم تحديثه
                updatedTeacher.TeacherId = teacherId;

                updatedTeacher.Name = txtName.Text;
                updatedTeacher.phoneNumber = txtPhoneNumber.Text;
                updatedTeacher.address = txtAddress.Text;
                updatedTeacher.dateGradute = dtpGraduateDate.Value;
                updatedTeacher.Date = Date.Value;

                // تحديد الجنس
                if (rdoMale.Checked) updatedTeacher.gender = "Male";
                else updatedTeacher.gender = "Female";

                // تحويل الراتب
                if (double.TryParse(txtSalary.Text, out double sal))
                {
                    updatedTeacher.salary = sal;
                }
                else
                {
                    MessageBox.Show("الرجاء إدخال رقم صحيح للراتب.");
                    return;
                }

                // 2. استدعاء الخدمة (BLL) لتنفيذ التحديث
                // هذه الدالة ستقوم بالتحقق من الشروط التي كتبتها (الاسم، الراتب، الهاتف)
                teacherService.UpdateTeacher(updatedTeacher);

                // 3. رسالة نجاح وإغلاق
                MessageBox.Show("تم تحديث بيانات المعلم بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
            }
            catch (ArgumentException ex)
            {
                // التقاط أخطاء التحقق (مثل: الراتب سالب، الاسم فارغ) وعرضها للمستخدم
                MessageBox.Show(ex.Message, "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (KeyNotFoundException ex)
            {
                // التقاط خطأ عدم وجود المعلم
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // التقاط أي أخطاء أخرى غير متوقعة
                MessageBox.Show("حدث خطأ غير متوقع: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }

