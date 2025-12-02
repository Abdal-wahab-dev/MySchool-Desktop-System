using SchoolManagementSystem.BLL.Services;
using SchoolManagementSystem.BLL.Validation;
using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
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
    public partial class RegisterForm : Form
    {
        private readonly UserService userService = new UserService();
        private readonly RigsterServices rigesterRepo = new RigsterServices();
        public RegisterForm()
        {
            InitializeComponent();
            FillUserTypes();

            txtName.Validating += (s, e) => CheckName();
            txtPassword.Validating += (s, e) => CheckPassword();
            
            comboType.Validating += (s, e) => CheckSpecialization();
            comboType.SelectedIndexChanged += (s, e) => CheckSpecialization();
        }
        private bool CheckName()
        {
            if (!txtName.Text.IsRequired())
            {
                errorProvider1.SetError(txtName, "الرجاء إدخال الاسم ");
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
        
        private bool CheckPassword()
        {
            
            if (!txtPassword.Text.IsValidNumericPassword(8))
            {
                errorProvider1.SetError(txtPassword, "كلمة المرور يجب أن تكون 8 أرقام على الأقل");
                return false;
            }

            errorProvider1.SetError(txtPassword, ""); 
            return true;
        }

        
        private bool CheckSpecialization()
        {
          
            string selectedValue = comboType.SelectedValue?.ToString();

           
            if (!selectedValue.IsIdSelected())
            {
                errorProvider1.SetError(comboType, "الرجاء اختيار الصفة");
                return false;
            }

            errorProvider1.SetError(comboType, ""); 
            return true;
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        private void FillUserTypes()
        {


            try
            {
                List<string> types = new List<string>();

                
                var dbTypes = userService.GetUserTypes();

                if (dbTypes != null) types.AddRange(dbTypes);

                if (types.Count == 0)
                {
                    types.Add("مدير");
                    types.Add("سكرتير");


                }
                comboType.DataSource = null;
                comboType.DataSource = types;


            }
            catch (Exception ex)
            {
               
                MessageBox.Show("FATAL DB ERROR: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isNameOk = CheckName();
            bool isPasswordOk = CheckPassword();
            bool isSelectedOk = CheckSpecialization();

            if (isNameOk && isPasswordOk)
            {
                var user = new User
                {
                    UserName = txtName.Text.Trim(),
                    Password = int.Parse(txtPassword.Text.Trim()),
                    Type = comboType.SelectedValue.ToString(),

                };


                rigesterRepo.AddUser(user);

                MessageBox.Show("تمت الإضافة بنجاح");
            }
            this.Close();
        }
    }
}



