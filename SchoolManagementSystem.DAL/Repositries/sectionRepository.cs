using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DAL.Repositries
{
    public class sectionRepository
    {
        private AppDbContext con = new AppDbContext();

        public void addSection(Section section)
        {
            con.Sections.Add(section);
            con.SaveChanges();
        }
        public void removeSection(Section section)
        {
            con.Sections.Remove(section);
            con.SaveChanges();
        }
        public List<Student> getStudents(Section section)
        {
            var studentsInDivision = con.Students.Where(s => s.SectionId == section.SectionId).ToList();

            return studentsInDivision;
            con.SaveChanges();
        }
    }
}
