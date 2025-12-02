using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms; // تأكد من وجود هذه المكتبة

namespace MySchool_Desktop_System
{
    public static class ThemeManager
    {
        // ==========================================
        // 1. الألوان (Palette)
        // ==========================================
        private static readonly Color DarkBackground = Color.FromArgb(32, 32, 32);     // خلفية الفورم الغامقة
        private static readonly Color DarkPanelBack = Color.FromArgb(45, 45, 48);      // خلفية البانل الغامقة
        private static readonly Color DarkText = Color.WhiteSmoke;                   // نص عام
        private static readonly Color DarkControl = Color.FromArgb(60, 60, 60);        // خلفية الخانات الغامقة

        private static readonly Color LightBackground = SystemColors.ActiveCaption;    // خلفية الفورم الفاتحة
        private static readonly Color LightPanelBack = SystemColors.ControlLight;      // خلفية البانل الفاتحة
        private static readonly Color LightText = Color.Black;                       // نص عام
        private static readonly Color LightControl = Color.White;                    // خلفية الخانات الفاتحة

        // ==========================================
        // 2. الدالة الرئيسية
        // ==========================================
        public static void ApplyTheme(Form form, bool isDark, bool isMainForm)
        {
            form.BackColor = isDark ? DarkBackground : LightBackground;
            form.ForeColor = isDark ? DarkText : LightText;

            foreach (Control c in form.Controls)
            {
                ApplyStyleToControl(c, isDark, isMainForm);
            }
        }

        // ==========================================
        // 3. دالة تلوين الأدوات
        // ==========================================
        private static void ApplyStyleToControl(Control c, bool isDark, bool isMainForm)
        {
            // 1. اللون الافتراضي للنص (للجميع ما عدا الخانات)
            c.ForeColor = isDark ? DarkText : LightText;

            // تحديد لون الحاويات
            Color containerColor;
            if (isMainForm) containerColor = isDark ? DarkPanelBack : LightPanelBack;
            else containerColor = isDark ? Color.Transparent : Color.Transparent;

            // ---------------------------------------------------------
            // 🅰️ الحاويات (Containers)
            // ---------------------------------------------------------
            if (c is System.Windows.Forms.Panel || c is GroupBox || c is TabPage)
            {
                c.BackColor = containerColor;

                if (c.Name == "panelContainer")
                {
                    c.BackColor = isDark ?  DarkBackground: LightBackground;
                }
            }

            else if (c is Guna2Panel gPanel)
            {
                gPanel.FillColor = containerColor;
                gPanel.BackColor = Color.Transparent;
            }
            else if (c is Guna2GroupBox gGroup)
            {
                gGroup.FillColor = containerColor;
                gGroup.CustomBorderColor = isDark ? DarkControl : LightControl;
                gGroup.ForeColor = isDark ? Color.White : Color.Black; // نص عنوان الجروب
            }

            // ---------------------------------------------------------
            // 🅱️ أدوات الإدخال (Inputs) - (تصحيح الألوان هنا)
            // ---------------------------------------------------------
            // 1. أدوات Guna2
            else if (c is Guna2TextBox gText)
            {
                gText.FillColor = isDark ? DarkControl : LightControl;
                gText.ForeColor = isDark ? Color.White : Color.Black; // ✅ تصحيح النص
                gText.BorderColor = isDark ? Color.Gray : Color.Silver;
            }
            else if (c is Guna2ComboBox gCombo)
            {
                gCombo.FillColor = isDark ? DarkControl : LightControl;
                gCombo.ForeColor = isDark ? Color.White : Color.Black; // ✅ تصحيح النص
                gCombo.BorderColor = isDark ? Color.Gray : Color.Silver;
                gCombo.ItemsAppearance.BackColor = isDark ? DarkPanelBack : Color.White;
                gCombo.ItemsAppearance.ForeColor = isDark ? Color.White : Color.Black;
            }
            else if (c is Guna2DateTimePicker gDate)
            {
                gDate.FillColor = isDark ? DarkControl : LightControl;
                gDate.ForeColor = isDark ? Color.White : Color.Black; // ✅ تصحيح النص
            }

            // 2. أدوات Windows Forms العادية
            else if (c is System.Windows.Forms.TextBox || c is ComboBox || c is DateTimePicker || c is NumericUpDown)
            {
                c.BackColor = isDark ? DarkControl : LightControl;
                c.ForeColor = isDark ? Color.White : Color.Black; // ✅ تصحيح النص

                // إصلاح مشكلة الكومبو بوكس العادي
                if (c is ComboBox combo)
                {
                    combo.FlatStyle = isDark ? FlatStyle.Flat : FlatStyle.Standard;
                }
            }

            // ---------------------------------------------------------
            // 🆎 الأزرار (Buttons)
            // ---------------------------------------------------------
            else if (c is Guna2Button gBtn)
            {
                gBtn.FillColor = isDark ? DarkBackground : LightBackground;
                gBtn.ForeColor = isDark ? Color.WhiteSmoke : Color.Black;
            }
            else if (c is Button btn)
            {
                btn.BackColor = isDark ? DarkBackground : LightBackground;
                btn.ForeColor = isDark ? Color.WhiteSmoke : Color.Black;
            }

            // ---------------------------------------------------------
            // 🆑 الجداول (Grids)
            // ---------------------------------------------------------
            else if (c is Guna2DataGridView gDgv)
            {
                if (isDark)
                {
                    gDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
                    gDgv.BackgroundColor = DarkPanelBack;
                    gDgv.DefaultCellStyle.BackColor = DarkBackground;
                    gDgv.DefaultCellStyle.ForeColor = Color.White;
                    gDgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gDgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    gDgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light;
                    gDgv.BackgroundColor = SystemColors.AppWorkspace;
                    gDgv.DefaultCellStyle.BackColor = Color.White;
                    gDgv.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            else if (c is DataGridView dgv)
            {
                StyleStandardDataGridView(dgv, isDark);
            }

            // ---------------------------------------------------------
            // 👁️ أدوات شفافة (Labels)
            // ---------------------------------------------------------
            else if (c is Label || c is LinkLabel || c is RadioButton || c is CheckBox || c is PictureBox)
            {
                c.BackColor = Color.Transparent;
                // النص هنا سيأخذ اللون العام الذي وضعناه في بداية الدالة
            }

            // ---------------------------------------------------------
            // 🔁 التكرار (Recursion)
            // ---------------------------------------------------------
            if (c.HasChildren)
            {
                foreach (Control child in c.Controls)
                {
                    ApplyStyleToControl(child, isDark, isMainForm);
                }
            }
        }

        // ==========================================
        // 4. تنسيق جدول الويندوز العادي
        // ==========================================
        private static void StyleStandardDataGridView(DataGridView dgv, bool isDark)
        {
            dgv.EnableHeadersVisualStyles = false;
            if (isDark)
            {
                dgv.BackgroundColor = DarkPanelBack;
                dgv.GridColor = Color.Gray;
                dgv.DefaultCellStyle.BackColor = DarkBackground;
                dgv.DefaultCellStyle.ForeColor = Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            else
            {
                dgv.BackgroundColor = SystemColors.AppWorkspace;
                dgv.GridColor = SystemColors.ControlDark;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.WindowText;
            }
        }
    }
}