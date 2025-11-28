using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MySchool_Desktop_System
{
    public partial class MainForm : Form
    {
        private Stack<Form> formStack = new Stack<Form>();
        private Form CurrentForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFormInPanel(Form form)
        {
            if (CurrentForm != null) {
                CurrentForm.Hide();
                formStack.Push(CurrentForm);
            }
            CurrentForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;
            if (!panelContainer.Controls.Contains(form)) {
                panelContainer.Controls.Add(form);
            }
            form.BringToFront();
            form.Show();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new StudentManagement());
        }

        private void iconButtonBack_Click(object sender, EventArgs e)
        {
            if (formStack.Count > 0) {
                CurrentForm.Hide();
                CurrentForm = formStack.Pop();
                CurrentForm.Show();
            }
        }
    }
}
