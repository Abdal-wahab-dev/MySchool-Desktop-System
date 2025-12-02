using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SchoolManagementSystem.DAL.Repositries
{
    public class schollClassRepo
    {
        private AppDbContext con = new AppDbContext();

        public void addClass(SchoolClass newClass)
        {
            con.Classes.Add(newClass);
            con.SaveChanges();
        }
        public void removeClass(SchoolClass remoClass)
        {
            con.Classes.Remove(remoClass);
            con.SaveChanges();
        }
        public List<Teacher> getTeachers(SchoolClass _class)
        {
            var teachersForClass = con.Teachers
            .Where(t => t.SchoolClasses.Any(sc => sc.SchoolClassId == _class.SchoolClassId)).ToList();

            return teachersForClass;
            con.SaveChanges();
        }
        public List<Subject> getSubgets(SchoolClass _class)
        {
            var subjectsForClass = con.Classes.Where(sc => sc.SchoolClassId == _class.SchoolClassId).SelectMany(sc => sc.Subjects).ToList();

            return subjectsForClass;
            con.SaveChanges();
        }
    }
}
