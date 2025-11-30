using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.BLL.Services
{
 public  class StudentServices
    {
         public readonly studentRepositry studentService = new studentRepositry();

        public List<Student> GetStudent()
        {
            return studentService.GetAllStudent();
        }
        public void updateStudent(Student student)
        {
            studentService.UpdateStudent(student);
        }
        public void addSudent(Student student)
        {
            studentService.AddNewSudent(student);
        }
        public void removeSudent(Student student)
        {
            studentService.RemoveStudent(student);
        }
        public Student showDetails(int studentId)
        {
            return studentService.ShowDetails(studentId);
        }

        public List<SchoolClass> GetAllClasses()
        {
            return studentService.GetClasses();
        }

        public List<Section> GetAllSections()
        {
            return studentService.GetSections();
        }



    }
}


