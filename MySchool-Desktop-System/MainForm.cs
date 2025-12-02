using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
// ❌ تم حذف مكتبات System.Web لتجنب الأخطاء

namespace MySchool_Desktop_System
{
    public partial class MainForm : BaseForm
    {
        // 1. كدس لحفظ الصفحات السابقة (التاريخ)
        private Stack<Form> _history = new Stack<Form>();

        // 2. متغير لمعرفة الصفحة المعروضة حالياً
        private Form _currentForm = null;

        public MainForm(string userName)
        {
            InitializeComponent();
            lblUserName.Text = userName;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        // =================================================================
        // ✅ الدالة المركزية لفتح الفورمات (Public لتستخدمها الفورمات الأخرى)
        // =================================================================
        public void OpenForm(Form newForm)
        {
            // 1. إذا كان هناك فورم مفتوح، احفظه في التاريخ وأزله من العرض
            if (_currentForm != null)
            {
                _history.Push(_currentForm); // حفظ في الكدس
                panelContainer.Controls.Remove(_currentForm); // إخفاء من البانل
            }

            // 2. تجهيز الفورم الجديد
            _currentForm = newForm;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;

            // 3. تطبيق الثيم الحالي عليه فوراً
            bool isDark = Properties.Settings.Default.IsDarkMode;
            ThemeManager.ApplyTheme(newForm, isDark, false); // false لأنه ليس الرئيسي

            // 4. عرضه في البانل
            panelContainer.Controls.Add(newForm);
            panelContainer.Tag = newForm;
            newForm.Show();
            newForm.BringToFront();
        }

        // =================================================================
        // 🔙 كود زر الرجوع (Back Button)
        // =================================================================
        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            if (_history.Count > 0)
            {
                // 1. إغلاق الفورم الحالي (لأننا انتهينا منه)
                if (_currentForm != null)
                {
                    _currentForm.Close();
                    panelContainer.Controls.Remove(_currentForm);
                }

                // 2. استرجاع الفورم السابق
                Form previousForm = _history.Pop();
                _currentForm = previousForm;

                // 3. إعادة عرضه
                // ملاحظة: قد يحتاج لإعادة تطبيق الثيم للتأكد
                bool isDark = Properties.Settings.Default.IsDarkMode;
                ThemeManager.ApplyTheme(previousForm, isDark, false);

                panelContainer.Controls.Add(previousForm);
                previousForm.Show();
                previousForm.BringToFront();
            }
            else
            {
                // (اختياري) رسالة إذا لم يكن هناك صفحات سابقة
                // MessageBox.Show("أنت في الصفحة الرئيسية");
            }
        }

        // =================================================================
        // 🎨 زر تغيير الثيم
        // =================================================================
        //private void btnToggleTheme_Click(object sender, EventArgs e)
        //{
        //    if (Properties.Settings.Default.IsDarkMode)
        //    {
        //        // إذا كان الوضع ليلي، حوله إلى نهاري (شمس)
        //        btnToggleThem.Text = "\uf185"; // Sun
        //    }
        //    else
        //    {
        //        // إذا كان الوضع نهاري، حوله إلى ليلي (قمر)
        //        btnToggleThem.Text = "\uf186"; // Moon
        //    }
        //    // 1. عكس الحالة وحفظها
        //    bool newMode = !Properties.Settings.Default.IsDarkMode;
        //    Properties.Settings.Default.IsDarkMode = newMode;
        //    Properties.Settings.Default.Save();

        //    // 2. تحديث جميع الفورمات المفتوحة (بما فيها الرئيسي والفرعي)
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        ThemeManager.ApplyTheme(form, newMode, form.Name == "MainForm");
        //    }
        //}

        // =================================================================
        // أزرار القائمة (تستخدم دالة OpenForm الآن)
        // =================================================================
        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            OpenForm(new StudentManagement());
        }

        private void btnTeacherForm_Click(object sender, EventArgs e)
        {
            OpenForm(new teacherManagement()); // تأكد من اسم الكلاس (Capital/Small)
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            OpenForm(new SubjectForm()); // أو SubjectsForm حسب التسمية عندك
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // أي كود تحميل
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            // غالباً لا تحتاج كود هنا
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.IsDarkMode)
            {
                // إذا كان الوضع ليلي، حوله إلى نهاري (شمس)
                btnToggleTheme.Text = "\uf185";
                btnToggleTheme.IconChar = FontAwesome.Sharp.IconChar.None;
            }
            else
            {
                // إذا كان الوضع نهاري، حوله إلى ليلي (قمر)
                btnToggleTheme.Text = "\uf186";
                btnToggleTheme.IconChar = FontAwesome.Sharp.IconChar.None;
            }
            // 1. عكس الحالة وحفظها
            bool newMode = !Properties.Settings.Default.IsDarkMode;
            Properties.Settings.Default.IsDarkMode = newMode;
            Properties.Settings.Default.Save();

            // 2. تحديث جميع الفورمات المفتوحة (بما فيها الرئيسي والفرعي)
            foreach (Form form in Application.OpenForms)
            {
                ThemeManager.ApplyTheme(form, newMode, form.Name == "MainForm");
            }
        }

        
    }
}