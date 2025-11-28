using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;

namespace SchoolManagementSystem.DAL.Repositries
{
    public  class studentRepositry
    {
        private readonly AppDbContext con = new AppDbContext(); 

        public List<Student> GetAllStudent()
        {
            return con.Students.ToList();
        }
        public void AddNewSudent(Student student)
        {
            con.Students.Add(student); 
            con.SaveChanges();
        }

        public void RemoveStudent(Student student)
        {
            con.Students.Remove(student);
            con.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            var student_a = con.Students.Find(student.StudentId);
            student_a.Section = student.Section;
            student_a.StudentName = student.StudentName;
            student_a.Address = student.Address;
            student_a.ImagePath = student.ImagePath;
            student_a.StudentState = student.StudentState;
            student_a.StudentClass = student.StudentClass;
            student_a.Birthdate = student.Birthdate;
            con.SaveChanges();
        }     

        public Student ShowDetails(Student student)
        {
            Student student_s = con.Students.FirstOrDefault(s => s.StudentId == student.StudentId);

            return student_s ;
        }

        public List<SchoolClass> GetClasses()
        {
            return con.Classes.ToList();
        }

        public List<Section> GetSectionById(int classId) { 
            return con.Sections.Where(s => s.SchoolClassId == classId).ToList();
        }

        



    }
}
