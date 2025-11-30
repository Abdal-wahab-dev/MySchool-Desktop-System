using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.BLL.Services;
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
    public partial class LoginForm : Form
    {
        private readonly UserService userService = new UserService();
        public LoginForm()
        {
            InitializeComponent();
            FillUserTypes();
            this.Load += new EventHandler(LoginForm_Load);

            // وأيضاً اربط زر الدخول يدوياً للتأكد
            btnLogin.Click += new EventHandler(btnLogin_Click);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        private void FillUserTypes()
        {
            

            try
            {
                List<string> types = new List<string>();

                // ❌ يرجى إزالة الـ Where و ToList() من هذا السطر مؤقتاً للتأكد
                var dbTypes = userService.GetUserTypes();

                if (dbTypes != null) types.AddRange(dbTypes);

                
                // إذا كانت القائمة فارغة، أضف الثوابت
                if (types.Count == 0)
                {
                    types.Add("مدير");
                    types.Add("مستخدم");

                   
                }

                // 🔴🔴 نقطة الاختبار 4: هل يتم ربط البيانات بالـ ComboBox؟
                comboType.DataSource = null;
                comboType.DataSource = types;

                
            }
            catch (Exception ex)
            {
                // 🔴🔴 نقطة الاختبار 5: إذا وصلت هنا، فهناك خطأ حقيقي في الاتصال 🔴🔴
                MessageBox.Show("FATAL DB ERROR: " + ex.Message);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUserName.Text.Trim();
                string pass = txtPassword.Text.Trim(); // تأكد أن التيكست بوكس هذا خاصيته PasswordChar = '*'

                // استدعاء الخدمة
                User loggedInUser = userService.ValidateUser(user, pass);

                if (loggedInUser != null)
                {
                    // تسجيل الدخول ناجح
                    MessageBox.Show($"مرحباً بك يا {loggedInUser.UserName}، صفتك: {loggedInUser.Type}", "نجاح");

                    // فتح الفورم الرئيسي
                    MainForm mainForm = new MainForm(loggedInUser.UserName);

                    // (اختياري) يمكنك تمرير نوع المستخدم للفورم الرئيسي للتحكم بالصلاحيات
                    // mainForm.SetUserType(loggedInUser.Type); 

                    mainForm.Show();
                    this.Hide();

                    // إغلاق البرنامج بالكامل عند إغلاق الفورم الرئيسي
                    mainForm.FormClosed += (s, args) => Application.Exit();
                }
                else
                {
                    MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في الاتصال: " + ex.Message);
            }
        }

        
    }
}

