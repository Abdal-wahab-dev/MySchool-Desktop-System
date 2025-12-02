using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.BLL.Validation;
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
    public partial class SubjectForm : BaseForm
    {
        private readonly SubjectService _service = new SubjectService();
        private int _currentId = 0;
        public SubjectForm()
        {
            InitializeComponent();
            txtSubName.Validating += (s, e) => CheckName();
            txtSubDegree.Validating += (s, e) => CheckDegree();
            cmbClass.Validating += (s, e) => CheckClass();
            cmbSubTeacher.Validating += (s, e) => CheckTeacher();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                // 1. إعداد الجدول وربط الأعمدة يدوياً
                SetupGridColumns();

                // 2. تحميل القوائم والبيانات
                LoadComboBoxes();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التحميل: " + ex.Message);
            }
        }
        private bool CheckName()
        {
            if (!txtSubName.Text.IsRequired())
            {
                errorProvider1.SetError(txtSubName, "الرجاء إدخال اسم المادة");
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


        private bool CheckDegree()
        {
            if (!txtSubDegree.Text.IsRequired())
            {
                errorProvider1.SetError(txtSubDegree, "العنوان مطلوب");
                return false;
            }
            errorProvider1.SetError(txtSubDegree, "");
            return true;
        }

        private bool CheckClass()
        {
            string selectedValue = cmbClass.SelectedValue?.ToString();


            if (!selectedValue.IsIdSelected())
            {
                errorProvider1.SetError(cmbClass, "الرجاء اختيار الصف");
                return false;
            }

            errorProvider1.SetError(cmbClass, "");
            return true;
        }

        private bool CheckTeacher()
        {
            string selectedValue = cmbSubTeacher.SelectedValue?.ToString();


            if (!selectedValue.IsIdSelected())
            {
                errorProvider1.SetError(cmbSubTeacher, "الرجاء اختيار الشعبة");
                return false;
            }

            errorProvider1.SetError(cmbSubTeacher, "");
            return true;
        }


        private void SetupGridColumns()
        {
            dgvSubject.AutoGenerateColumns = false; 


            
            if (dgvSubject.Columns["SubjectId"] != null)
                dgvSubject.Columns["SubjectId"].DataPropertyName = "Id"; 

            if (dgvSubject.Columns["SubjectName"] != null)
                dgvSubject.Columns["SubjectName"].DataPropertyName = "Name"; 

            
            if (dgvSubject.Columns["Degree"] != null)
                dgvSubject.Columns["Degree"].DataPropertyName = "Grade"; 

            
            if (dgvSubject.Columns["ClassName"] != null)
                dgvSubject.Columns["ClassName"].DataPropertyName = "Classes";

            
            if (dgvSubject.Columns["Teacher"] != null)
                dgvSubject.Columns["Teacher"].DataPropertyName = "Teachers"; 
        }

        private void LoadComboBoxes()
        {
            
            cmbClass.DataSource = _service.GetClasses();
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "SchoolClassId";
            cmbClass.SelectedIndex = -1;

            
            cmbSubTeacher.DataSource = _service.GetTeachers();
            cmbSubTeacher.DisplayMember = "Name";
            cmbSubTeacher.ValueMember = "TeacherId";
            cmbSubTeacher.SelectedIndex = -1;
        }

        private void LoadGrid()
        {
            
            dgvSubject.DataSource = _service.GetSubjectsForGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_currentId == 0)
            {
                MessageBox.Show("الرجاء تحديد مادة من الجدول أولاً");
                return;
            }

            try
            {
                // 2. جلب البيانات الأصلية من السيرفس
                // (يمكنك استخدام GetSubjectById إذا أنشأتها، أو البحث في القائمة كما يلي)
                var allSubjects = _service.GetOriginalSubjects();
                var selectedSubject = allSubjects.FirstOrDefault(s => s.SubjectId == _currentId);

                if (selectedSubject != null)
                {
                    
                    txtSubName.Text = selectedSubject.SubjectName;
                    txtSubDegree.Text = selectedSubject.SubjectGrade;

                    
                    var firstClass = selectedSubject.SchoolClasses.FirstOrDefault();
                    if (firstClass != null)
                        cmbClass.SelectedValue = firstClass.SchoolClassId;
                    else
                        cmbClass.SelectedIndex = -1;

                    
                    var firstTeacher = selectedSubject.Teachers.FirstOrDefault();
                    if (firstTeacher != null)
                        cmbSubTeacher.SelectedValue = firstTeacher.TeacherId;
                    else
                        cmbSubTeacher.SelectedIndex = -1;

                    MessageBox.Show("تم جلب البيانات، يمكنك التعديل الآن ثم الضغط على حفظ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_currentId == 0) return;

            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _service.DeleteSubject(_currentId);
                LoadGrid();
                ClearFields();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isNameOk = CheckName();
            bool isDegreeOk = CheckDegree();
            bool isClassOk = CheckClass();
            bool isTeacherOk = CheckTeacher();

            if (isNameOk && isDegreeOk && isClassOk && isTeacherOk)
            {
                if (_currentId == 0)
                {
                    MessageBox.Show("الرجاء اختيار مادة من الجدول أولاً (أو الضغط على زر تعديل) لحفظ التغييرات عليها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {

                    var subject = new Subject
                    {
                        SubjectId = _currentId,
                        SubjectName = txtSubName.Text.Trim(),
                        SubjectGrade = txtSubDegree.Text.Trim()
                    };


                    int classId = Convert.ToInt32(cmbClass.SelectedValue);
                    int teacherId = Convert.ToInt32(cmbSubTeacher.SelectedValue);


                    _service.UpdateSubject(subject, classId, teacherId);


                    MessageBox.Show("تم حفظ التعديلات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadGrid();
                    ClearFields();
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
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isNameOk = CheckName();
            bool isDegreeOk = CheckDegree();
            bool isClassOk = CheckClass();
            bool isTeacherOk = CheckTeacher();

            if (isNameOk && isDegreeOk && isClassOk && isTeacherOk)
            {
                try
                {
                    if (cmbClass.SelectedValue == null || cmbSubTeacher.SelectedValue == null)
                    {
                        MessageBox.Show("الرجاء اختيار الصف والمعلم");
                        return;
                    }

                    var subject = new Subject
                    {
                        SubjectName = txtSubName.Text,
                        SubjectGrade = txtSubDegree.Text
                    };

                    int classId = Convert.ToInt32(cmbClass.SelectedValue);
                    int teacherId = Convert.ToInt32(cmbSubTeacher.SelectedValue);

                    _service.AddSubject(subject, classId, teacherId);

                    MessageBox.Show("تمت الإضافة بنجاح");
                    LoadGrid();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ: " + ex.Message);
                }
            }
            else
            {

                MessageBox.Show("يرجى تصحيح الحقول المؤشر عليها باللون الأحمر.", "بيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClearFields()
        {
            _currentId = 0;
            txtSubName.Clear();
            txtSubDegree.Clear();
            cmbClass.SelectedIndex = -1;
            cmbSubTeacher.SelectedIndex = -1;
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    
                    var idValue = dgvSubject.Rows[e.RowIndex].Cells[0].Value;

                    if (idValue != null)
                    {
                        _currentId = Convert.ToInt32(idValue);

                         }
                }
                catch
                {
                    _currentId = 0;
                }
            }
        }
    }
    }



