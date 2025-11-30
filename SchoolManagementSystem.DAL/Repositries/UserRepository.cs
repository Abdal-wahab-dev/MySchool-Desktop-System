using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.DAL.Repositries
{
    public class UserRepository
    {
        // ❌ احذف هذا السطر: private readonly AppDbContext con = new AppDbContext();

        public User Login(string username, string password)
        {
            int passInt;

            // ✅ يتم فتح الاتصال وإغلاقه تلقائياً هنا
            using (var context = new AppDbContext())
            {
                if (int.TryParse(password, out passInt))
                {
                    // تأكد أنك تستخدم DbSet بصيغة الجمع: con.Users
                    return context.Users.FirstOrDefault(u => u.UserName == username && u.Password == passInt);
                }
                return null;
            }
        }

        public List<string> GetDistinctUserTypes()
        {
            // ✅ يتم فتح الاتصال وإغلاقه تلقائياً هنا
            using (var context = new AppDbContext())
            {
                return context.Users
                              .Select(u => u.Type)
                              .Distinct()
                              .ToList();
            }
        }
    }
}