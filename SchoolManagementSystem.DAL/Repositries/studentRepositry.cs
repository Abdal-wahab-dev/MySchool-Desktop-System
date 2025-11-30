
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations; // تأكد من وجود هذه المكتبة
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.DAL.Context;
using SchoolManagementSystem.DAL.Model;

namespace SchoolManagementSystem.DAL.Repositries
{
    public class studentRepositry
    {
        // يفضل جعل الـ Context يتجدد مع كل عملية لضمان عدم وجود بيانات قديمة
        // لكن سأبقيه كما هو بناء على كودك الحالي
        private readonly AppDbContext con = new AppDbContext();

        public List<Student> GetAllStudent()
        {
            return con.Students.Include("Section").ToList(); // يفضل إضافة Include لجلب البيانات المرتبطة
        }

        public void AddNewSudent(Student student)
        {
            con.Students.Add(student);
            con.SaveChanges();
        }

        public void RemoveStudent(Student student)
        {
            // عند الحذف، يفضل البحث عنه أولاً لضمان أنه مربوط بالكونتكس
            var s = con.Students.Find(student.StudentId);
            if (s != null)
            {
                con.Students.Remove(s);
                con.SaveChanges();
            }
        }

        
        public void UpdateStudent(Student student)
        {
            
            var student_a = con.Students.Find(student.StudentId);

            if (student_a != null)
            {
               
                student_a.SectionId = student.SectionId;

               
                student_a.StudentName = student.StudentName;
                student_a.Address = student.Address;
                student_a.ImagePath = student.ImagePath;
                student_a.StudentState = student.StudentState;
                student_a.StudentClass = student.StudentClass;
                student_a.Birthdate = student.Birthdate;
                student_a.Gender = student.Gender;

                
                student_a.PhoneNumber = student.PhoneNumber;

                
                con.SaveChanges();
            }
        }

        public Student ShowDetails(int studentId)
        {
            
            return con.Students.FirstOrDefault(s => s.StudentId == studentId);
        }

        public List<SchoolClass> GetClasses()
        {
            return con.Classes.ToList();
        }

        public List<Section> GetSections()
        {
            return con.Sections.ToList();
        }
    }
}