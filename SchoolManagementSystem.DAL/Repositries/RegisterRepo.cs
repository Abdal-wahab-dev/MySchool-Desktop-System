using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Repositries
{
    public class RegisterRepo
    {
        private readonly AppDbContext con = new AppDbContext();

        public void AddNewUser(User user)
        {
            con.Users.Add(user);
            con.SaveChanges();
        }
    }
}
