using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BLL.Services
{
    public class UserService
    {
        private readonly UserRepository userRepo = new UserRepository();

        // نرجع كائن User بالكامل لنستفيد من خاصية Type لاحقاً
        public User ValidateUser(string userName, string password ,string type)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(type))
            {
                return null;
            }

            return userRepo.Login(userName, password , type);
        }

        public List<string> GetUserTypes()
        {
            return userRepo.GetDistinctUserTypes();
        }
    }
}
