using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BLL.Services
{
    public class sectionService
    {
        private sectionRepository sectionServ = new sectionRepository();
        public void addSection(Section section)
        {
            sectionServ.addSection(section);
        }
        public void removeSection(Section section)
        {
            sectionServ.removeSection(section);

        }
        public List<Student> getAllStudents(Section section)
        {
            return sectionServ.getStudents(section);
        }
    }
}

