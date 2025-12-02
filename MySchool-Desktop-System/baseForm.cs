using System;
using System.Windows.Forms;

namespace MySchool_Desktop_System
{
    // هذا الفورم يرث من Form العادية
    public class BaseForm : Form
    {
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            // إذا أصبح الفورم مرئياً، طبق الثيم المحفوظ
            if (this.Visible)
            {
                bool isDark = Properties.Settings.Default.IsDarkMode;
                bool isMainForm = (this.Name == "MainForm");

                ThemeManager.ApplyTheme(this, isDark,isMainForm);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}