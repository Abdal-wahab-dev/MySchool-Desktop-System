using SchoolManagementSystem.DAL.Repositries;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.DAL.Model;

namespace SchoolManagementSystem.BLL.Services
{
    public class classesServices
    {
        private schollClassRepo _classService = new schollClassRepo();

        public void addCalss(SchoolClass _class)
        {
            _classService.addClass(_class);
        }
        public void removeClass(SchoolClass _class)
        {
            _classService.removeClass(_class);
        }
        public List<Teacher> getTeachers(SchoolClass _class)
        {
            return _classService.getTeachers(_class);
        }
        public List<Subject> getSubgets(SchoolClass _class)
        {
            return _classService.getSubgets(_class);
        }
    }
}
