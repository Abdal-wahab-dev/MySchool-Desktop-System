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
    public partial class DetailsFeeForm : Form
    {
        private Panel parentPanel;
        public DetailsFeeForm(Panel panel)
        {
            InitializeComponent();
            parentPanel = panel;
        }

        public void ShowInPanel()
        {
            this.TopLevel = false;           // لا يظهر كنافذة مستقلة
            this.Dock = DockStyle.Fill;      // يملأ مساحة الـ Panel بالكامل
            parentPanel.Controls.Add(this);  // إضافة الفورم للـ Panel
            this.BringToFront();             // يكون أمام كل شيء
            this.Show();
        }

        private void DetailsFeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
