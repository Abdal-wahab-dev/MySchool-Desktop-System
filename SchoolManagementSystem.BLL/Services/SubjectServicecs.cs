using SchoolManagementSystem.DAL.Model;
using SchoolManagementSystem.DAL.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.BLL.Services
{
    public class SubjectService
    {
        private readonly SubjectRepository repo = new SubjectRepository();

        // ✅✅ دالة خاصة لتجهيز البيانات للجدول (Flattening) ✅✅
        public object GetSubjectsForGrid()
        {
            var subjects = repo.GetAllSubjects();

            // نقوم بإنشاء شكل جديد للبيانات يناسب الجدول
            return subjects.Select(s => new
            {
                Id = s.SubjectId,
                Name = s.SubjectName,
                Grade = s.SubjectGrade,
                // دمج أسماء الصفوف بفاصلة
                Classes = string.Join(", ", s.SchoolClasses.Select(c => c.ClassName)),
                // دمج أسماء المعلمين بفاصلة
                Teachers = string.Join(", ", s.Teachers.Select(t => t.Name))
            }).ToList();
        }

        public void AddSubject(Subject subject, int classId, int teacherId)
        {
            if (string.IsNullOrWhiteSpace(subject.SubjectName)) throw new ArgumentException("اسم المادة مطلوب");
            repo.AddSubject(subject, classId, teacherId);
        }

        public void UpdateSubject(Subject subject, int classId, int teacherId)
        {
            repo.UpdateSubject(subject, classId, teacherId);
        }

        public void DeleteSubject(int id)
        {
            repo.DeleteSubject(id);
        }

        public List<SchoolClass> GetClasses() => repo.GetAllClasses();
        public List<Teacher> GetTeachers() => repo.GetAllTeachers();

        // نحتاج هذه الدالة لجلب المادة الأصلية عند الضغط على الجدول لتعبئة الحقول
        public List<Subject> GetOriginalSubjects() => repo.GetAllSubjects();
    
    public Subject GetSubjectById(int id)
        {
            return repo.GetSubjectById(id);
      
        }
    } 
}
