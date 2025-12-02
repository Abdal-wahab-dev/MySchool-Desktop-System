using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BLL.Services
{
    public class RigsterServices
    {
        private readonly RegisterRepo rigesterRepo = new RegisterRepo();
        public void AddUser(User user)
        {
            rigesterRepo.AddNewUser(user);
        }
    }
}
